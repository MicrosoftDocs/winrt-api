---
-api-id: P:Windows.Globalization.CalendarIdentifiers.Julian
-api-type: winrt property
---

<!-- Property syntax
public string Julian { get; }
-->

# Windows.Globalization.CalendarIdentifiers.Julian

## -description
Gets the identifier for the Julian calendar.

## -property-value
The string "JulianCalendar", which is the identifier for the Julian calendar.

## -remarks

In 45 B.C., Julius Caesar ordered a calendar reform, which resulted in the calendar called the Julian calendar. The Julian calendar is the predecessor of the [Gregorian](calendaridentifiers_gregorian.md) calendar.

The Julian calendar system recognizes only the current era.

Unlike the Gregorian calendar, the Julian calendar defines a leap year as a year that is evenly divisible by four with no exceptions. Therefore, the calendar is inaccurate by one day every 128 years. A common year has 365 days and a leap year has 366 days.

Like the Gregorian calendar, the Julian calendar has 12 months with 28 to 31 days each: January (31 days), February (28 or 29 days), March (31 days), April (30 days), May (31 days), June (30 days), July (31 days), August (31 days), September (30 days), October (31 days), November (30 days), and December (31 days). February has 29 days during leap years and 28 during common years.

The date January 1, 2012 A.D. in the Gregorian calendar is equivalent to the 19th day of December in the year 2011 in the Julian calendar.

Julian calendar strings for day of the week names and month names are localized for all supported locales and hence will appear in the language corresponding to the [ResolvedLanguage](calendar_resolvedlanguage.md) property of the calendar object.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)