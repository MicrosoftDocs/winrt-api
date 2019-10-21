---
-api-id: T:Windows.UI.WebUI.WebUIAppointmentsProviderReplaceAppointmentActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUIAppointmentsProviderReplaceAppointmentActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IAppointmentsProviderActivatedEventArgs, Windows.ApplicationModel.Activation.IAppointmentsProviderReplaceAppointmentActivatedEventArgs, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUIAppointmentsProviderReplaceAppointmentActivatedEventArgs

## -description
Provides data when an app is activated to replace an appointment in the user’s calendar.

## -remarks
This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](https://docs.microsoft.com/previous-versions/windows/apps/br212679(v=win.10)) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **appointmentsProvider**.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

## -see-also
[IAppointmentsProviderReplaceAppointmentActivatedEventArgs](../windows.applicationmodel.activation/iappointmentsproviderreplaceappointmentactivatedeventargs.md), [IAppointmentsProviderActivatedEventArgs](../windows.applicationmodel.activation/iappointmentsprovideractivatedeventargs.md), [IActivatedEventArgs](../windows.applicationmodel.activation/iactivatedeventargs.md), [IActivatedEventArgsDeferral](iactivatedeventargsdeferral.md)
