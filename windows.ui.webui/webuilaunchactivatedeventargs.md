---
-api-id: T:Windows.UI.WebUI.WebUILaunchActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUILaunchActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs, Windows.ApplicationModel.Activation.ILaunchActivatedEventArgs, Windows.ApplicationModel.Activation.IPrelaunchActivatedEventArgs, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUILaunchActivatedEventArgs

## -description
Provides event information when an app is launched.

## -remarks
This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](/previous-versions/windows/apps/br212679(v=win.10)) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **launch**.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | TileActivatedInfo |
| 1607 | 14393 | User |

## -examples

## -see-also
