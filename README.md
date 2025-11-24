### Requirements

- [dotnet](https://dotnet.microsoft.com/)
- A Twilio account - [sign up](https://www.twilio.com/try-twilio)
- A Twilio Phone Number provisioned for voice
- An MP3 (upload to a space that is available on the web, such as [Twilio assets](https://www.twilio.com/docs/serverless/functions-assets/assets))

### Twilio Account Settings

This application should give you a ready-made starting point for writing your
own application. Before we begin, we need to collect
all the config values we need to run the application:
- Account SID
- Auth Token
- Twilio Phone Number
- Incoming Phone Number


### Local development

After the above requirements have been met:

1. Clone this repository and `cd` into it

```bash
git clone git@github.com:twilio-samples/add-mp3-to-phone-call
cd add-mp3-to-phone-call
```

2. Add necessary nuget packages

```bash
dotnet add package Twilio
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.UserSecrets


```
3. Set necessary user secrets by getting the credentials from your Twilio dashboard:

```bash
dotnet user-secrets init
dotnet user-secrets set Twilio:AccountSid [TWILIO_ACCOUNT_SID]
dotnet user-secrets set Twilio:AuthToken [TWILIO_AUTH_TOKEN]
dotnet user-secrets set Twilio:PhoneNumber [TWILIO_PHONE_NUMBER]
dotnet user-secrets set ReceivingNumber [NUMBER_TO_CALL]
```

4. Replace placeholder value ASSET_URL in the application with the URL of your MP3 Asset


5. Build to install the dependencies

```bash
dotnet build
```

6. Run the application

```bash
dotnet run
```



