---
-api-id: T:Windows.UI.WebUI.WebUILockScreenCallActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUILockScreenCallActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs, Windows.ApplicationModel.Activation.ILaunchActivatedEventArgs, Windows.ApplicationModel.Activation.ILockScreenCallActivatedEventArgs, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUILockScreenCallActivatedEventArgs

## -description
Provides event information when communication to and from the lock screen is required.

## -remarks
This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](/previous-versions/windows/apps/br212679(v=win.10)) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **lockScreenCall**.


<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

## -examples

## -see-also
[ILockScreenCallActivatedEventArgs](../windows.applicationmodel.activation/ilockscreencallactivatedeventargs.md), [ILaunchActivatedEventArgs](../windows.applicationmodel.activation/ilaunchactivatedeventargs.md), [IActivatedEventArgs](../windows.applicationmodel.activation/iactivatedeventargs.md), [IApplicationViewActivatedEventArgs](../windows.applicationmodel.activation/iapplicationviewactivatedeventargs.md), [IActivatedEventArgsDeferral](iactivatedeventargsdeferral.md)
