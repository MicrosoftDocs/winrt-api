---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentManagerForUser.ShowReplaceAppointmentAsync(System.String,Windows.ApplicationModel.Appointments.Appointment,Windows.Foundation.Rect,Windows.UI.Popups.Placement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> ShowReplaceAppointmentAsync(System.String appointmentId, Windows.ApplicationModel.Appointments.Appointment appointment, Windows.Foundation.Rect selection, Windows.UI.Popups.Placement preferredPlacement)
-->

# Windows.ApplicationModel.Appointments.AppointmentManagerForUser.ShowReplaceAppointmentAsync

## -description
Shows the Appointments provider Replace Appointment UI, to enable the user to replace an appointment.

## -parameters
### -param appointmentId
The appointment identifier of the current appointment. This is typically obtained from the async return value of a previous [ShowAddAppointmentAsync](appointmentmanagerforuser_showaddappointmentasync_253292089.md) or [ShowReplaceAppointmentAsync](appointmentmanagerforuser_showreplaceappointmentasync_1336777815.md) call.

### -param appointment
The object representing the information for the appointment to replace the current appointment.

### -param selection
The [Rect](../windows.foundation/rect.md) is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Replace Appointment UI, not within that rectangular area. For example, if an app uses a button to show the [Rect](../windows.foundation/rect.md), pass the [Rect](../windows.foundation/rect.md) of the button so the Replace Appointment UI displays around the button, not overlapping it.

### -param preferredPlacement
The [Placement](../windows.ui.popups/placement.md) that describes the preferred placement of the Replace Appointment UI.

## -returns
When this method completes, it returns a **String** object that represents the appointment. This serves as an appointment identifier for future reference when updating or removing. If the appointment identifier returned is an empty string, the appointment was not replaced in the Appointments provider app.

## -remarks

## -examples

## -see-also
[ShowReplaceAppointmentAsync(String, Appointment, Rect)](appointmentmanagerforuser_showreplaceappointmentasync_1336777815.md), [ShowReplaceAppointmentAsync(String, Appointment, Rect, Placement, DateTime)](appointmentmanagerforuser_showreplaceappointmentasync_1458488223.md)
## -capabilities
appointmentsSystem
