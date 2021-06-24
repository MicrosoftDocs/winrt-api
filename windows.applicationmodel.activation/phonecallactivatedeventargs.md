---
-api-id: T:Windows.ApplicationModel.Activation.PhoneCallActivatedEventArgs
-api-type: winrt class
---

# Windows.ApplicationModel.Activation.PhoneCallActivatedEventArgs

<!--
public sealed class PhoneCallActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IPhoneCallActivatedEventArgs
-->


## -description

Represents the launch arguments for the application. The app’s `OnActivated` method will be invoked with the `PhoneCallActivatedEventArgs` class being the `activatedEventArg` payload.

## -remarks

> [!IMPORTANT]
> To use this API, your application needs to declare in its `Package.appxmanifest` file `windows.phonecallactivation` as a `uap13:Extension` category. Otherwise, the application won't be able to be activated to facilitate in-app call progress control UI.

## -see-also

## -examples


