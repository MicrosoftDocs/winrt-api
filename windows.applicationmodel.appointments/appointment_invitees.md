---
-api-id: P:Windows.ApplicationModel.Appointments.Appointment.Invitees
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.ApplicationModel.Appointments.AppointmentInvitee> Invitees { get; }
-->

# Windows.ApplicationModel.Appointments.Appointment.Invitees

## -description
Gets the list of participants for the appointment. [Invitees](appointment_invitees.md) is of type [IVector(AppointmentInvitee)](../windows.foundation.collections/ivector_1.md). If an organizer is set and invitee length is greater than 0, a call to an [AppointmentManager](appointmentmanager.md)API fails with **E_INVALIDARG**. The number of invitees is unlimited.

## -property-value
The list of participants for the appointment.

## -remarks

## -examples

## -see-also

## -capabilities
appointmentsSystem
