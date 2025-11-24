using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Microsoft.Extensions.Configuration;

class Program {
  public static async Task Main(string[] args) {

       var config = new ConfigurationBuilder()
           .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .AddUserSecrets<Program>()
           .Build();

      string accountSid = config["Twilio:AccountSid"];
      string authToken = config["Twilio:AuthToken"];
      string incomingNumber = config["ReceivingNumber"];
      string outgoingNumber = config["Twilio:PhoneNumber"];

      TwilioClient.Init(accountSid, authToken);
      var url = new Uri("https://wisteria-mandrill-7217.twil.io/assets/magical-sound-effect-7137.mp3");

      var call = await CallResource.CreateAsync(
          twiml: new Twilio.Types.Twiml("<Response><Play>" + url + "</Play></Response>"),
          to: new Twilio.Types.PhoneNumber(incomingNumber),
          from: new Twilio.Types.PhoneNumber(outgoingNumber));

      Console.WriteLine(call.Sid);
  }
}
