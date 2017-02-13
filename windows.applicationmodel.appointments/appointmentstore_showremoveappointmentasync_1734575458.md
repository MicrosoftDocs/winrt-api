---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentStore.ShowRemoveAppointmentAsync(System.String,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> ShowRemoveAppointmentAsync(System.String localId, Windows.Foundation.Rect selection)
-->

# Windows.ApplicationModel.Appointments.AppointmentStore.ShowRemoveAppointmentAsync

## -description
Shows the Appointments provider Remove Appointment UI, to enable the user to remove an appointment.

## -parameters
### -param localId
The [LocalId](appointment_localid.md) of the appointment to be removed.

### -param selection
The [Rect](../windows.foundation/rect.md) is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Remove Appointment UI, not within that rectangular area. For example, if an app uses a button to show the [Rect](../windows.foundation/rect.md), pass the [Rect](../windows.foundation/rect.md) of the button so the Remove Appointment UI displays around the button, not overlapping it.

## -returns
When this method completes, it returns a **Boolean** value that indicates whether the Appointment provider app removed the appointment.

## -remarks

## -examples

## -see-also
[ShowRemoveAppointmentAsync(String, Rect, Placement, DateTime)](appointmentstore_showremoveappointmentasync_339596666.md)