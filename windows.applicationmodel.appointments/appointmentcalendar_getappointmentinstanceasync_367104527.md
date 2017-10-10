---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentCalendar.GetAppointmentInstanceAsync(System.String,Windows.Foundation.DateTime)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Appointments.Appointment> GetAppointmentInstanceAsync(System.String localId, Windows.Foundation.DateTime instanceStartTime)
-->

# Windows.ApplicationModel.Appointments.AppointmentCalendar.GetAppointmentInstanceAsync

## -description
Asynchronously retrieves the appointment instance of the specified master appointment that has the specified start time.

## -parameters
### -param localId
The ID of the master appointment to which the retrieved appointment instance belongs.

### -param instanceStartTime
The start time of the appointment instance to be retrieved.

## -returns
An asynchronous operation that returns [Appointment](appointment.md) on successful completion.

## -remarks
The *instanceStartTime* parameter must be the original start date of the instance.

## -examples

## -see-also

## -capabilities
appointmentsSystem
