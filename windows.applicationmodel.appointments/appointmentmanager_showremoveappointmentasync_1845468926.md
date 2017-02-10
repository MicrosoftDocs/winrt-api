---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentManager.ShowRemoveAppointmentAsync(System.String,Windows.Foundation.Rect,Windows.UI.Popups.Placement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> ShowRemoveAppointmentAsync(System.String appointmentId, Windows.Foundation.Rect selection, Windows.UI.Popups.Placement preferredPlacement)
-->

# Windows.ApplicationModel.Appointments.AppointmentManager.ShowRemoveAppointmentAsync

## -description
Shows the Appointments provider Remove Appointment UI, to enable the user to remove an appointment.

## -parameters
### -param appointmentId
The appointment identifier. This is typically obtained from the async return value of a previous [ShowAddAppointmentAsync](appointmentmanager_showaddappointmentasync.md) call.

### -param selection
The [Rect](../windows.foundation/rect.md) is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Remove Appointment UI, not within that rectangular area. For example, if an app uses a button to show the [Rect](../windows.foundation/rect.md), pass the [Rect](../windows.foundation/rect.md) of the button so the Remove Appointment UI displays around the button, not overlapping it.

### -param preferredPlacement
The [Placement](../windows.ui.popups/placement.md) that describes the preferred placement of the Remove Appointment UI.

## -returns
When this method completes, it returns a **Boolean** value that indicates whether the Appointment provider app removed the appointment.

## -remarks
See the remarks section of this overload: [ShowRemoveAppointmentAsync](appointmentmanager_showremoveappointmentasync_1734575458.md).

## -examples

## -see-also
[ShowRemoveAppointmentAsync(String, Rect)](appointmentmanager_showremoveappointmentasync_1734575458.md), [ShowRemoveAppointmentAsync(String, Rect, Placement, DateTime)](appointmentmanager_showremoveappointmentasync_339596666.md)