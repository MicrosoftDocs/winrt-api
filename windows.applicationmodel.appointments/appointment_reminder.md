---
-api-id: P:Windows.ApplicationModel.Appointments.Appointment.Reminder
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.TimeSpan> Reminder { get;  set; }
-->

# Windows.ApplicationModel.Appointments.Appointment.Reminder

## -description
Gets or sets a time span value. The value declares the amount of time to subtract from the [StartTime](appointment_starttime.md), and that time used as the issue time for a reminder for an appointment. A **null** value indicates that the appointment will not issue a reminder. [Reminder](appointment_reminder.md) is of type [IReference(TimeSpan)](../windows.foundation/ireference_1.md).

## -property-value
A time span value, or **null** to issue no reminder.

## -remarks
This property uses a time span value, which is represented differently depending on which language you are programming with. For more information about how to use a time span value, see the [Duration](appointment_duration.md) property.

## -examples

## -see-also
