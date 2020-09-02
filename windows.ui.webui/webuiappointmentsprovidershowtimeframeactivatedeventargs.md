---
-api-id: T:Windows.UI.WebUI.WebUIAppointmentsProviderShowTimeFrameActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUIAppointmentsProviderShowTimeFrameActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IAppointmentsProviderActivatedEventArgs, Windows.ApplicationModel.Activation.IAppointmentsProviderShowTimeFrameActivatedEventArgs, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUIAppointmentsProviderShowTimeFrameActivatedEventArgs

## -description
Provides data when an app is activated to show a specified time frame on the user’s calendar.

## -remarks
This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](/previous-versions/windows/apps/br212679(v=win.10)) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **appointmentsProvider**.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

## -see-also
[IAppointmentsProviderShowTimeFrameActivatedEventArgs](../windows.applicationmodel.activation/iappointmentsprovidershowtimeframeactivatedeventargs.md), [IAppointmentsProviderActivatedEventArgs](../windows.applicationmodel.activation/iappointmentsprovideractivatedeventargs.md), [IActivatedEventArgs](../windows.applicationmodel.activation/iactivatedeventargs.md), [IActivatedEventArgsDeferral](iactivatedeventargsdeferral.md)
