---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentStore.ShowAddAppointmentAsync(Windows.ApplicationModel.Appointments.Appointment,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> ShowAddAppointmentAsync(Windows.ApplicationModel.Appointments.Appointment appointment, Windows.Foundation.Rect selection)
-->

# Windows.ApplicationModel.Appointments.AppointmentStore.ShowAddAppointmentAsync

## -description
Shows the Appointments provider Add Appointment UI, to enable the user to add an appointment.

## -parameters
### -param appointment
The object representing the information for the appointment to add.

### -param selection
The [Rect](../windows.foundation/rect.md) is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the Add Appointment UI, not within that rectangular area. For example, if an app uses a button to show the [Rect](../windows.foundation/rect.md), pass the [Rect](../windows.foundation/rect.md) of the button so the Add Appointment UI displays around the button, not overlapping it.

## -returns
When this method completes, it returns a **String** object that represents the [RoamingId](appointment_roamingid.md) of the appointment. If the appointment identifier returned is an empty string, the appointment was not added to the Appointments provider app.

## -remarks
> For Windows Phone Store app, this method behaves the same as [ShowEditNewAppointmentAsync](appointmentmanager_showeditnewappointmentasync.md), in that the fields in the Add Appointment UI are editable by the user.

## -examples

## -see-also
