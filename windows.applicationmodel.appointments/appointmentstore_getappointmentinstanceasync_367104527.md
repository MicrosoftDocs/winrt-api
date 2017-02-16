---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentStore.GetAppointmentInstanceAsync(System.String,Windows.Foundation.DateTime)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Appointments.Appointment> GetAppointmentInstanceAsync(System.String localId, Windows.Foundation.DateTime instanceStartTime)
-->

# Windows.ApplicationModel.Appointments.AppointmentStore.GetAppointmentInstanceAsync

## -description
Retrieves the instance of the [Appointment](appointment.md) with the specified [LocalId](appointment_localid.md) and the specified start time.

## -parameters
### -param localId
The [LocalId](appointment_localid.md) of the appointment instance to be retrieved.

### -param instanceStartTime
The start time of the appointment instance to be retrieved. The value of this parameter must be the original start date of the instance.

## -returns
An asynchronous operation that returns an [Appointment](appointment.md) upon successful completion.

## -remarks

## -examples

## -see-also
