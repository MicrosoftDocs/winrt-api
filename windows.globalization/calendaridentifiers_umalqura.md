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
<!--{annotation author="v-dedlug" time="8/3/2011 3:05:05 PM"}A search on the web indicates that "UmAlQura" should not be run together into one word (unless it's part of a programming element name, of course); the spelling I put here seems to be the most common one, although there are others.-->

## -property-value
The string "UmAlQuraCalendar", which is the identifier for the Um Al-Qura calendar.

## -remarks
<!--{annotation author="raymonsh" time="9/6/2012 3:01:23 PM"}The following remarks are adapted from http://msdn.microsoft.com/en-us/library/system.globalization.umalquracalendar-->
The Um Al-Qura calendar or Saudi Hijri system is nearly identical to the [Hijri](calendaridentifiers_hijri.md) calendar system, except in using a table-based algorithm licensed from the Saudi government to calculate dates, and in supporting dates only for the years 1318 to 1500 (corresponding approximately to Gregorian dates April 30, 1900 through November 16, 2077).

For the Um Al-Qura calendar, each month has either 29 or 30 days, but usually in no discernible order. Whereas the documentation for the Hijri calendar gives a table that shows the corresponding days in each month, no such general table can be produced for the Um Al-Qura calendar.

Like the Hijri calendar, Um Al-Qura calendar strings for day of the week names and month names are not localized and hence will appear in Arabic regardless of the current value of the [ResolvedLanguage](calendar_resolvedlanguage.md) property of the calendar object.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)