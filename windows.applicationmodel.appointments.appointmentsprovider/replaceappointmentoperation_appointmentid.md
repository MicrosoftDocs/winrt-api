---
-api-id: P:Windows.ApplicationModel.Appointments.AppointmentsProvider.ReplaceAppointmentOperation.AppointmentId
-api-type: winrt property
---

<!-- Property syntax
public string AppointmentId { get; }
-->

# Windows.ApplicationModel.Appointments.AppointmentsProvider.ReplaceAppointmentOperation.AppointmentId

## -description
Gets the unique identifier of the appointment to replace.

## -property-value
The unique identifier of the appointment to replace.

## -remarks
The identifier is typically a value that the appointments provider app previously returned through an [AddAppointmentOperation.ReportCompleted](addappointmentoperation_reportcompleted.md) call. If the identifier doesn't correspond to any known appointment, the appointment doesn't exist in the user’s calendar. Because the user's intent was to replace the original appointment, we recommend that the appointment provider app create a new appointment and add it to the calendar.
<!--and probably should not display UI? without an ID to lookup the info there would be nothing useful to display-->

## -examples

## -see-also

## -capabilities
appointmentsSystem
