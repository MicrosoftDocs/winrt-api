---
-api-id: T:Windows.ApplicationModel.Activation.AppointmentsProviderAddAppointmentActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class AppointmentsProviderAddAppointmentActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IAppointmentsProviderActivatedEventArgs, Windows.ApplicationModel.Activation.IAppointmentsProviderAddAppointmentActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.AppointmentsProviderAddAppointmentActivatedEventArgs

## -description
Provides data when an app is activated to add an appointment to the user’s calendar.



> **JavaScript**
> This type appears as [WebUIAppointmentsProviderAddAppointmentActivatedEventArgs](../windows.ui.webui/webuiappointmentsprovideraddappointmentactivatedeventargs.md).

## -remarks
This object is accessed when you override the [OnActivated](../windows.ui.xaml/application_onactivated.md) method, [IActivatedEventArgs.Kind](iactivatedeventargs_kind.md) is **AppointmentsProvider**, and [IAppointmentsProviderActivatedEventArgs.Verb](iappointmentsprovideractivatedeventargs_verb.md) is equal to the value of the [AppointmentsProviderLaunchActionVerbs.AddAppointment](../windows.applicationmodel.appointments.appointmentsprovider/appointmentsproviderlaunchactionverbs_addappointment.md) property.

## -examples

## -see-also
[IAppointmentsProviderAddAppointmentActivatedEventArgs](iappointmentsprovideraddappointmentactivatedeventargs.md), [IAppointmentsProviderActivatedEventArgs](iappointmentsprovideractivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)