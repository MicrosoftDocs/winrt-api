---
-api-id: T:Windows.ApplicationModel.Activation.AppointmentsProviderShowAppointmentDetailsActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class AppointmentsProviderShowAppointmentDetailsActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IAppointmentsProviderActivatedEventArgs, Windows.ApplicationModel.Activation.IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.AppointmentsProviderShowAppointmentDetailsActivatedEventArgs

## -description
Provides data when an app is activated to show the details of an appointment.

## -remarks
This object is accessed when you override the [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) method, [IActivatedEventArgs.Kind](iactivatedeventargs_kind.md) is **AppointmentsProvider**, and [IAppointmentsProviderActivatedEventArgs.Verb](iappointmentsprovideractivatedeventargs_verb.md) is equal to the value of the [AppointmentsProviderLaunchActionVerbs.ShowAppointmentDetails](../windows.applicationmodel.appointments.appointmentsprovider/appointmentsproviderlaunchactionverbs_showappointmentdetails.md) property.

## -examples

## -see-also
[IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs](iappointmentsprovidershowappointmentdetailsactivatedeventargs.md), [IAppointmentsProviderActivatedEventArgs](iappointmentsprovideractivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)