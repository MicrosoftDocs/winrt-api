---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentStore.ShowReplaceAppointmentAsync(System.String,Windows.ApplicationModel.Appointments.Appointment,Windows.Foundation.Rect,Windows.UI.Popups.Placement,Windows.Foundation.DateTime)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> ShowReplaceAppointmentAsync(System.String localId, Windows.ApplicationModel.Appointments.Appointment appointment, Windows.Foundation.Rect selection, Windows.UI.Popups.Placement preferredPlacement, Windows.Foundation.DateTime instanceStartDate)
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

### -param preferredPlacement
The [Placement](../windows.ui.popups/placement.md) that describes the preferred placement of the Replace Appointment UI.

### -param instanceStartDate
The start date and time of the appointment instance to replace.

## -returns
When this method completes, it returns a **String** object that represents the [RoamingId](appointment_roamingid.md) of the appointment that replaced the existing appointment.

## -remarks
The instanceStartTime parameter must be the original start date of the instance.

## -examples

## -see-also
[ShowReplaceAppointmentAsync(String, Appointment, Rect)](appointmentstore_showreplaceappointmentasync_1336777815.md)
## -capabilities
appointmentsSystem
