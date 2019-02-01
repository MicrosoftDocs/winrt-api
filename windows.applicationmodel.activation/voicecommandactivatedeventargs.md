---
-api-id: T:Windows.ApplicationModel.Activation.VoiceCommandActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class VoiceCommandActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IVoiceCommandActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.VoiceCommandActivatedEventArgs

## -description
Contains info for the app's activated event when the app is launched through a voice command.

## -remarks
Access this object by overriding either the Windows Library for JavaScript (WinJS) [onactivated](https://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4) event or the Extensible Application Markup Language (XAML) [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) method, when the value of [IActivatedEventArgs.Kind](iactivatedeventargs_kind.md) is **VoiceCommand**.

## -examples

## -see-also
[IVoiceCommandActivatedEventArgs](ivoicecommandactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)