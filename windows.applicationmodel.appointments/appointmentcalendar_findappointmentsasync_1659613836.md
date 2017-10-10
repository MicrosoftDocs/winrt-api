---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentCalendar.FindAppointmentsAsync(Windows.Foundation.DateTime,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Appointments.Appointment>> FindAppointmentsAsync(Windows.Foundation.DateTime rangeStart, Windows.Foundation.TimeSpan rangeLength)
-->

# Windows.ApplicationModel.Appointments.AppointmentCalendar.FindAppointmentsAsync

## -description
Asynchronously retrieves a list of appointments belonging to the current [AppointmentCalendar](appointmentcalendar.md) that meet the specified criteria.

## -parameters
### -param rangeStart
The start time of the time window for which appointments are retrieved.

### -param rangeLength
The length of the time window for which appointments are retrieved. If the *rangeLength* parameter is set to 0, no appointments will be returned. Even if appointments exist on the device that have a [StartTime](appointment_starttime.md) that is exactly the same as the *rangeStart* value, the returned list will be empty.

## -returns
An asynchronous operation that returns an [IVectorView](../windows.foundation.collections/ivectorview_1.md) list of [Appointment](appointment.md) objects upon successful completion.

## -remarks

## -examples

## -see-also
[FindAppointmentsAsync(DateTime, TimeSpan, FindAppointmentsOptions)](appointmentcalendar_findappointmentsasync_541298316.md), [Appointment](appointment.md)
## -capabilities
appointmentsSystem
