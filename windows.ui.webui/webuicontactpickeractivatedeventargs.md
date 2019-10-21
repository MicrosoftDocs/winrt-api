---
-api-id: T:Windows.UI.WebUI.WebUIContactPickerActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUIContactPickerActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IContactPickerActivatedEventArgs, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUIContactPickerActivatedEventArgs

## -description
Provides data when an app is activated because it uses the Contact Picker.

## -remarks
This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](https://docs.microsoft.com/previous-versions/windows/apps/br212679(v=win.10)) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **contactPicker**.



> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275)
<!--[jjacks - removed this link (https://go.microsoft.com/fwlink/p/?linkid=258277 404->http://msdn.microsoft.com/library/windows/apps/jj157115.aspx) because it doesn't work] and Using Windows Runtime objects in a multithreaded environment (.NET)-->
.

## -examples

## -see-also