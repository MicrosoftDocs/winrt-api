---
-api-id: T:Windows.ApplicationModel.Appointments.AppointmentCalendarOtherAppReadAccess
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Appointments.AppointmentCalendarOtherAppReadAccess : int
-->

# AppointmentCalendarOtherAppReadAccess

## -description
Specifies the level of read access provided to an app calendar.

## -enum-fields
### -field SystemOnly:0
Only the operating system can read data from the app calendar.

### -field Limited:1
Other apps on the device can read the [Subject](appointment_subject.md), [StartTime](appointment_starttime.md), [Duration](appointment_duration.md), [AllDay](appointment_allday.md), [LocalId](appointment_localid.md) properties of appointments in the calendar and the [LocalId](appointmentcalendar_localid.md) property of the calendar

### -field Full:2
Other apps on the device can read all properties of appointments in the calendar.

### -field None:3
Other apps on the device cannot read any properties of appointments in the calendar.


## -remarks

## -examples

## -see-also
## -capabilities
appointmentsSystem
