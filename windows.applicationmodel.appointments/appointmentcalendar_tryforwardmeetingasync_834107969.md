---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentCalendar.TryForwardMeetingAsync(Windows.ApplicationModel.Appointments.Appointment,Windows.Foundation.Collections.IIterable{Windows.ApplicationModel.Appointments.AppointmentInvitee},System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryForwardMeetingAsync(Windows.ApplicationModel.Appointments.Appointment meeting, Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Appointments.AppointmentInvitee> invitees, System.String subject, System.String forwardHeader, System.String comment)
-->

# Windows.ApplicationModel.Appointments.AppointmentCalendar.TryForwardMeetingAsync

## -description
Asynchronously attempts to forward a meeting.

## -parameters
### -param meeting
The meeting to forward.

### -param invitees
A list of new invitees to receive the forwarded meeting.

### -param subject
The subject of the meeting invitation.

### -param forwardHeader
A new meeting header that includes the new invitees.

### -param comment
The body of the forwarded meeting invitation.

## -returns
A Boolean value indicating if the operation was successful.

## -remarks

## -examples

## -see-also

## -capabilities
appointmentsSystem
