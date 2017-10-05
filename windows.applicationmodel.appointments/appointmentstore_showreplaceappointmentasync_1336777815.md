---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentStore.ShowReplaceAppointmentAsync(System.String,Windows.ApplicationModel.Appointments.Appointment,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> ShowReplaceAppointmentAsync(System.String localId, Windows.ApplicationModel.Appointments.Appointment appointment, Windows.Foundation.Rect selection)
-->

# Windows.ApplicationModel.Appointments.AppointmentStore.ShowReplaceAppointmentAsync

## -description
Shows the Appointments provider Replace Appointment UI, to enable the user to replace an appointment.

## -parameters
### -param localId
The [LocalId](appointment_localid.md) of the appointment to be replaced.

### -param appointment
The object representing the appointment to replace the existing appointment.

### -param selection
The [Rect](../windows.foundation/rect.md) is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Replace Appointment UI, not within that rectangular area. For example, if an app uses a button to show the [Rect](../windows.foundation/rect.md), pass the [Rect](../windows.foundation/rect.md) of the button so the Replace Appointment UI displays around the button, not overlapping it.

## -returns
When this method completes, it returns a **String** object that represents the [RoamingId](appointment_roamingid.md) of the appointment that replaced the existing appointment.

## -remarks

## -examples

## -see-also
[ShowReplaceAppointmentAsync(String, Appointment, Rect, Placement, DateTime)](appointmentstore_showreplaceappointmentasync_1458488223.md)
## -capabilities
appointmentsSystem
