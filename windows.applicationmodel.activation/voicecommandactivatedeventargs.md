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
Access this object by overriding either the Windows Library for JavaScript (WinJS) [onactivated](/previous-versions/windows/apps/br212679(v=win.10)) event or the Extensible Application Markup Language (XAML) [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) method, when the value of [IActivatedEventArgs.Kind](iactivatedeventargs_kind.md) is **VoiceCommand**.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

## -see-also
[IVoiceCommandActivatedEventArgs](ivoicecommandactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)
