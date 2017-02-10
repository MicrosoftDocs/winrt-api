---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentManager.ShowReplaceAppointmentAsync(System.String,Windows.ApplicationModel.Appointments.Appointment,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> ShowReplaceAppointmentAsync(System.String appointmentId, Windows.ApplicationModel.Appointments.Appointment appointment, Windows.Foundation.Rect selection)
-->

# Windows.ApplicationModel.Appointments.AppointmentManager.ShowReplaceAppointmentAsync

## -description
Shows the Appointments provider Replace Appointment UI, to enable the user to replace an appointment.

## -parameters
### -param appointmentId
The appointment identifier of the current appointment. This is typically obtained from the async return value of a previous [ShowAddAppointmentAsync](appointmentmanager_showaddappointmentasync.md) or [ShowReplaceAppointmentAsync](appointmentmanager_showreplaceappointmentasync.md) call.

### -param appointment
The object representing the information for the appointment to replace the current appointment.

### -param selection
The [Rect](../windows.foundation/rect.md) is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Replace Appointment UI, not within that rectangular area. For example, if an app uses a button to show the [Rect](../windows.foundation/rect.md), pass the [Rect](../windows.foundation/rect.md) of the button so the Replace Appointment UI displays around the button, not overlapping it.

## -returns
When this method completes, it returns a **String** object that represents the appointment. This serves as an appointment identifier for future reference when updating or removing. If the appointment identifier returned is an empty string, the appointment was not replaced in the Appointments provider app.

## -remarks

## -examples

## -see-also
[ShowReplaceAppointmentAsync(String, Appointment, Rect, Placement)](appointmentmanager_showreplaceappointmentasync_1519758191.md), [ShowReplaceAppointmentAsync(String, Appointment, Rect, Placement, DateTime)](appointmentmanager_showreplaceappointmentasync_1458488223.md)