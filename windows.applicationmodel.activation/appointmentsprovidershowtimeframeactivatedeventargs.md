---
-api-id: T:Windows.ApplicationModel.Activation.AppointmentsProviderShowTimeFrameActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class AppointmentsProviderShowTimeFrameActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IAppointmentsProviderActivatedEventArgs, Windows.ApplicationModel.Activation.IAppointmentsProviderShowTimeFrameActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.AppointmentsProviderShowTimeFrameActivatedEventArgs

## -description
Provides data when an app is activated to show a specified time frame on the user’s calendar.



> **JavaScript**
> This type appears as [WebUIAppointmentsProviderShowTimeFrameActivatedEventArgs](../windows.ui.webui/webuiappointmentsprovidershowtimeframeactivatedeventargs.md).

## -remarks
This object is accessed when you override the [OnActivated](../windows.ui.xaml/application_onactivated.md) method, [IActivatedEventArgs.Kind](iactivatedeventargs_kind.md) is **AppointmentsProvider**, and [IAppointmentsProviderActivatedEventArgs.Verb](iappointmentsprovideractivatedeventargs_verb.md) is equal to the value of the [AppointmentsProviderLaunchActionVerbs.ShowTimeFrame](../windows.applicationmodel.appointments.appointmentsprovider/appointmentsproviderlaunchactionverbs_showtimeframe.md) property.

## -examples

## -see-also
[IAppointmentsProviderShowTimeFrameActivatedEventArgs](iappointmentsprovidershowtimeframeactivatedeventargs.md), [IAppointmentsProviderActivatedEventArgs](iappointmentsprovideractivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)