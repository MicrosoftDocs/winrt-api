---
-api-id: T:Windows.UI.WebUI.WebUICameraSettingsActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUICameraSettingsActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.ICameraSettingsActivatedEventArgs, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUICameraSettingsActivatedEventArgs

## -description
Enables a camera settings app to handle the activation parameters for the app.

## -remarks
This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](/previous-versions/windows/apps/br212679(v=win.10)) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **cameraSettings**.

Do not declare device capabilities for webcam or location. Those capabilities will cause a prompt for permissions to appear, which will obstruct the UI in your UWP app.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

## -examples

## -see-also
