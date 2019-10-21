---
-api-id: T:Windows.ApplicationModel.Appointments.AppointmentsProvider.AddAppointmentOperation
-api-type: winrt class
---

<!-- Class syntax.
public class AddAppointmentOperation : Windows.ApplicationModel.Appointments.AppointmentsProvider.IAddAppointmentOperation
-->

# Windows.ApplicationModel.Appointments.AppointmentsProvider.AddAppointmentOperation

## -description
Represents the operation object associated with adding a new appointment. Appointments provider apps use this info to perform the operation.

## -remarks
This class is used as the value of the [AddAppointmentOperation](../windows.applicationmodel.activation/appointmentsprovideraddappointmentactivatedeventargs_addappointmentoperation.md) event data property from the [AppointmentsProviderAddAppointmentActivatedEventArgs](../windows.applicationmodel.activation/appointmentsprovideraddappointmentactivatedeventargs.md) event data class. An appointments provider app typically goes through a series of casts and property checks starting from the [IActivatedEventArgs](../windows.applicationmodel.activation/iactivatedeventargs.md) event data of a general activation event handler. If the activation indicates that it's an **AppointmentsProvider** app activation kind with **Add** as the verb, then it's appropriate to cast event data to [AppointmentsProviderAddAppointmentActivatedEventArgs](../windows.applicationmodel.activation/appointmentsprovideraddappointmentactivatedeventargs.md).

Providers call methods of AddAppointmentOperation to indicate whether the operation was completed, was canceled, or when a provider error prevented the operation from being completed. Calling these methods influences the async results that the activating app gets back from its [ShowAddAppointmentAsync](/uwp/api/windows.applicationmodel.appointments.appointmentmanager.showaddappointmentasync) call. All of the reporting methods ([ReportCompleted](addappointmentoperation_reportcompleted_458863373.md), [ReportCanceled](addappointmentoperation_reportcanceled_1921025216.md), [ReportError](addappointmentoperation_reporterror_1034694985.md)) dismiss the Add Appointment UI.

## -examples

## -see-also
## -capabilities
appointmentsSystem
