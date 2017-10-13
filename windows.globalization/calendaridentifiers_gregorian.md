---
-api-id: P:Windows.Globalization.CalendarIdentifiers.Gregorian
-api-type: winrt property
---

<!-- Property syntax
public string Gregorian { get; }
-->

# Windows.Globalization.CalendarIdentifiers.Gregorian

## -description
Gets the identifier for the Gregorian calendar.

## -property-value
The string "GregorianCalendar", which is the identifier for the Gregorian calendar.

## -remarks
The returned identifier is suitable for use anywhere a calendar identifier is required.



The Gregorian calendar recognizes two eras: B.C. or B.C.E., and A.D. or C.E. This implementation of the Gregorian calendar system recognizes only the current era (A.D.).

A leap year in the Gregorian calendar is defined as a year that is evenly divisible by four, except if it is divisible by 100. However, years that are divisible by 400 are leap years. For example, the year 1900 was not a leap year, but the year 2000 was. A common year has 365 days and a leap year has 366 days.

The Gregorian calendar has 12 months with 28 to 31 days each: January (31 days), February (28 or 29 days), March (31 days), April (30 days), May (31 days), June (30 days), July (31 days), August (31 days), September (30 days), October (31 days), November (30 days), and December (31 days). February has 29 days during leap years and 28 during common years.

Gregorian calendar strings for day of the week names and month names are localized for all supported locales and hence will appear in the language corresponding to the [ResolvedLanguage](calendar_resolvedlanguage.md) property of the calendar object.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)