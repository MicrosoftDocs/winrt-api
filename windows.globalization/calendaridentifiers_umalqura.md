---
-api-id: P:Windows.Globalization.CalendarIdentifiers.UmAlQura
-api-type: winrt property
---

<!-- Property syntax
public string UmAlQura { get; }
-->

# Windows.Globalization.CalendarIdentifiers.UmAlQura

## -description
Gets the identifier for the Um Al-Qura calendar.


## -property-value
The string "UmAlQuraCalendar", which is the identifier for the Um Al-Qura calendar.

## -remarks

The Um Al-Qura calendar or Saudi Hijri system is nearly identical to the [Hijri](calendaridentifiers_hijri.md) calendar system, except in using a table-based algorithm licensed from the Saudi government to calculate dates, and in supporting dates only for the years 1318 to 1500 (corresponding approximately to Gregorian dates April 30, 1900 through November 16, 2077).

For the Um Al-Qura calendar, each month has either 29 or 30 days, but usually in no discernible order. Whereas the documentation for the Hijri calendar gives a table that shows the corresponding days in each month, no such general table can be produced for the Um Al-Qura calendar.

Like the Hijri calendar, Um Al-Qura calendar strings for day of the week names and month names are not localized and hence will appear in Arabic regardless of the current value of the [ResolvedLanguage](calendar_resolvedlanguage.md) property of the calendar object.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)