---
-api-id: T:Windows.ApplicationModel.Activation.RestrictedLaunchActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class RestrictedLaunchActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IRestrictedLaunchActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.RestrictedLaunchActivatedEventArgs

## -description
Provides event information when a restricted app is launched.



> **JavaScript**
> This type appears as [WebUIRestrictedLaunchActivatedEventArgs](../windows.ui.webui/webuirestrictedlaunchactivatedeventargs.md).

## -remarks
This object is accessed when you respond to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events when [ActivationKind](activationkind.md) is **RestrictedLaunch**.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

## -see-also
[IRestrictedLaunchActivatedEventArgs](irestrictedlaunchactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)
