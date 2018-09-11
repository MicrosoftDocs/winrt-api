---
-api-id: P:Windows.ApplicationModel.Appointments.AppointmentsProvider.RemoveAppointmentOperation.AppointmentId
-api-type: winrt property
---

<!-- Property syntax
public string AppointmentId { get; }
-->

# Windows.ApplicationModel.Appointments.AppointmentsProvider.RemoveAppointmentOperation.AppointmentId

## -description
Gets the unique identifier of the appointment to remove.

## -property-value
The unique identifier of the appointment to remove.

## -remarks
The identifier is usually a value the appointment provider app previously returned through an [AddAppointmentOperation.ReportCompleted](addappointmentoperation_reportcompleted_458863373.md) call. If the identifier doesn't correspond to any known appointment, the appointment doesn't exist in the user’s calendar. Because the user's intent was to remove the appointment, we recommend that you treat the operation as successful.
<!--and probably should not display UI? without an ID to lookup the info there would be nothing useful to display-->

## -examples

## -see-also

## -capabilities
appointmentsSystem
