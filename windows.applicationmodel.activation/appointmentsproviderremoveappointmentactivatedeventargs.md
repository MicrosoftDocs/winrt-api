---
-api-id: T:Windows.ApplicationModel.Activation.AppointmentsProviderRemoveAppointmentActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class AppointmentsProviderRemoveAppointmentActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IAppointmentsProviderActivatedEventArgs, Windows.ApplicationModel.Activation.IAppointmentsProviderRemoveAppointmentActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.AppointmentsProviderRemoveAppointmentActivatedEventArgs

## -description
Provides data when an app is activated to remove an appointment from the user’s calendar.



> **JavaScript**
> This type appears as [WebUIAppointmentsProviderRemoveAppointmentActivatedEventArgs](../windows.ui.webui/webuiappointmentsproviderremoveappointmentactivatedeventargs.md).

## -remarks
This object is accessed when you override the [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) method, [IActivatedEventArgs.Kind](iactivatedeventargs_kind.md) is **AppointmentsProvider**, and [IAppointmentsProviderActivatedEventArgs.Verb](iappointmentsprovideractivatedeventargs_verb.md) is equal to the value of the [AppointmentsProviderLaunchActionVerbs.RemoveAppointment](../windows.applicationmodel.appointments.appointmentsprovider/appointmentsproviderlaunchactionverbs_removeappointment.md) property.

## -examples

## -see-also
[IAppointmentsProviderRemoveAppointmentActivatedEventArgs](iappointmentsproviderremoveappointmentactivatedeventargs.md), [IAppointmentsProviderActivatedEventArgs](iappointmentsprovideractivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)