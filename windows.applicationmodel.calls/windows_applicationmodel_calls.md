---
-api-id: N:Windows.ApplicationModel.Calls
-api-type: winrt namespace
---

# Windows.ApplicationModel.Calls

## -description

Controls multiple aspects of how an application can interact with a phone device, including lock-screen interaction, the phone call history, and various telephony options and information.

## -remarks

This namespace is divided into three primary categories of classes and enumerations. These categories are the lock screen, the phone call history, and the telephony options and information.

The lock-screen-call contract lets an app, with user consent, perform these tasks:

+ Raise a notification toast with up to three additional buttons: Accept with Video, Accept with Audio, Ignore.
+ If the notification toast appears on the lock screen and the user chooses to accept the call, the app displays its call UI directly on the lock screen without requiring the user to unlock.

The telephony options and information classes use the **CallsPhoneContract**. In order to use these classes, you will need to declare the `phoneCall` capability in your manifest.

> [!IMPORTANT]
> If your application uses the **phoneCall** capability, you must request a waiver if you want to publish your application in China. Contact your premier support representative if you need the waiver.

## -examples

An example that demonstrates how to use much of the functionality of the Windows.ApplicationModel.Calls API can be found
[here](https://github.com/microsoft/Windows-universal-samples/tree/v8.0.7/archived/PhoneCall).

## -see-also

[Phone call sample](https://github.com/microsoft/Windows-universal-samples/tree/v8.0.7/archived/PhoneCall),
[Communication blocking and filtering sample](https://github.com/microsoft/Windows-universal-samples/tree/v8.0.7/archived/CommunicationBlockAndFilter),
[Voice over IP (VoIP) sample](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/VoIP)

## -capabilities

phoneCallHistory, phoneCallHistorySystem
