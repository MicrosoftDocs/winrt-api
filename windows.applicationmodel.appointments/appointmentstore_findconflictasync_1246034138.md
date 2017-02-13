---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentStore.FindConflictAsync(Windows.ApplicationModel.Appointments.Appointment,Windows.Foundation.DateTime)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Appointments.AppointmentConflictResult> FindConflictAsync(Windows.ApplicationModel.Appointments.Appointment appointment, Windows.Foundation.DateTime instanceStartTime)
-->

# Windows.ApplicationModel.Appointments.AppointmentStore.FindConflictAsync

## -description
Returns an [AppointmentConflictResult](appointmentconflictresult.md) representing a conflict between the specified appointment and an existing appointment instance in the appointment store.

## -parameters
### -param appointment
The appointment for which a conflict is sought.

### -param instanceStartTime
The start time of the appointment instance for which a conflict is sought.

## -returns
An asynchronous operation that returns an [AppointmentConflictResult](appointmentconflictresult.md) upon successful completion. For conflicts that are in the past, the returned [AppointmentConflictResult](appointmentconflictresult.md) object will have a [Type](appointmentconflictresult_type.md) of [AppointmentConflictType.None](appointmentconflicttype.md).

## -remarks

## -examples

## -see-also
[FindConflictAsync(Appointment)](appointmentstore_findconflictasync_734762440.md)