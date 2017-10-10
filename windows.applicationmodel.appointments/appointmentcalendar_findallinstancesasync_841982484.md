---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentCalendar.FindAllInstancesAsync(System.String,Windows.Foundation.DateTime,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Appointments.Appointment>> FindAllInstancesAsync(System.String masterLocalId, Windows.Foundation.DateTime rangeStart, Windows.Foundation.TimeSpan rangeLength)
-->

# Windows.ApplicationModel.Appointments.AppointmentCalendar.FindAllInstancesAsync

## -description
Asynchronously retrieves a list of appointment instances of the specified master appointment that meet the specified criteria.

## -parameters
### -param masterLocalId
The [LocalId](appointment_localid.md) of the master appointment for which appointment instances are retrieved.

### -param rangeStart
The start time of the time window for which appointment instances are retrieved.

### -param rangeLength
The length of the time window for which appointment instances are retrieved.

## -returns
An asynchronous operation that returns [IVectorView](../windows.foundation.collections/ivectorview_1.md) on successful completion.

## -remarks

## -examples

## -see-also
[FindAllInstancesAsync(String, DateTime, TimeSpan, FindAppointmentsOptions)](appointmentcalendar_findallinstancesasync_1216357868.md)
## -capabilities
appointmentsSystem
