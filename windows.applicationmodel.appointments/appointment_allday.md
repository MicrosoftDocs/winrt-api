---
-api-id: P:Windows.ApplicationModel.Appointments.Appointment.AllDay
-api-type: winrt property
---

<!-- Property syntax
public bool AllDay { get;  set; }
-->

# Windows.ApplicationModel.Appointments.Appointment.AllDay

## -description
Gets or sets a [Boolean](/dotnet/api/system.boolean?view=dotnet-uwp-10.0&preserve-view=true) value that indicates whether the appointment will last all day. The default is **FALSE** for won't last all day.

## -property-value
A [Boolean](/dotnet/api/system.boolean?view=dotnet-uwp-10.0&preserve-view=true) value that indicates whether the appointment will last all day. **TRUE** indicates that the appointment will last all day; otherwise **FALSE**.

## -remarks
When creating an appointment with **AllDay** set to true, you should set the [StartTime](appointment_starttime.md) of the appointment to midnight (00:00:00).

## -examples

## -see-also

## -capabilities
appointmentsSystem
