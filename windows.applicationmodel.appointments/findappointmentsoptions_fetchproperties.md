---
-api-id: P:Windows.ApplicationModel.Appointments.FindAppointmentsOptions.FetchProperties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> FetchProperties { get; }
-->

# Windows.ApplicationModel.Appointments.FindAppointmentsOptions.FetchProperties

## -description
Gets the list of appointment property names that will be populated with data in the find appointment query results.

## -property-value
A list of appointment property names.

## -remarks
The following properties are always returned from a find appointment query, even if they are not explicitly specified in the **FetchProperties** list.


+ [CalendarId](appointment_calendarid.md)
+ [LocalId](appointment_localid.md)
+ [OriginalStartTime](appointment_originalstarttime.md)
+ [Recurrence](appointment_recurrence.md)
+ [RoamingId](appointment_roamingid.md)


The list of valid properties is documented in the [AppointmentProperties](appointmentproperties.md) class.

## -examples

## -see-also
[AppointmentProperties](appointmentproperties.md)
## -capabilities
appointmentsSystem
