---
-api-id: T:Windows.ApplicationModel.Activation.AppointmentsProviderReplaceAppointmentActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class AppointmentsProviderReplaceAppointmentActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IAppointmentsProviderActivatedEventArgs, Windows.ApplicationModel.Activation.IAppointmentsProviderReplaceAppointmentActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.AppointmentsProviderReplaceAppointmentActivatedEventArgs

## -description
Provides data when an app is activated to replace an appointment in the user’s calendar.



> **JavaScript**
> This type appears as [WebUIAppointmentsProviderReplaceAppointmentActivatedEventArgs](../windows.ui.webui/webuiappointmentsproviderreplaceappointmentactivatedeventargs.md).

## -remarks
This object is accessed when you override the [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) method, [IActivatedEventArgs.Kind](iactivatedeventargs_kind.md) is **AppointmentsProvider**, and [IAppointmentsProviderActivatedEventArgs.Verb](iappointmentsprovideractivatedeventargs_verb.md) is equal to the value of the [AppointmentsProviderLaunchActionVerbs.ReplaceAppointment](../windows.applicationmodel.appointments.appointmentsprovider/appointmentsproviderlaunchactionverbs_replaceappointment.md) property.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

## -see-also
[IAppointmentsProviderReplaceAppointmentActivatedEventArgs](iappointmentsproviderreplaceappointmentactivatedeventargs.md), [IAppointmentsProviderActivatedEventArgs](iappointmentsprovideractivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)
