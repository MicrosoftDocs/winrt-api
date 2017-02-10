---
-api-id: P:Windows.ApplicationModel.Appointments.AppointmentRecurrence.TimeZone
-api-type: winrt property
---

<!-- Property syntax
public string TimeZone { get;  set; }
-->

# Windows.ApplicationModel.Appointments.AppointmentRecurrence.TimeZone

## -description
Gets or sets the time zone for the recurrence.

## -property-value
The time zone for the recurrence.

## -remarks
[StartTime](appointment_starttime.md) is projected to type **DateTimeOffset** in C# and JavaScript and DateTime in C++. Because these types represents absolute point in time, setting the **TimeZone** of the recurrence will not change what time the appointment occurs. This field can be used by your app's UI to simply show the time zone value or to localize the appointment time to the time zone.

## -examples

## -see-also
