---
-api-id: P:Windows.Globalization.CalendarIdentifiers.Taiwan
-api-type: winrt property
---

<!-- Property syntax
public string Taiwan { get; }
-->

# Windows.Globalization.CalendarIdentifiers.Taiwan

## -description
Gets the identifier for the Taiwan calendar.

## -property-value
The string "TaiwanCalendar", which is the identifier for the Taiwan calendar.

## -remarks

The Taiwan calendar works exactly like the [Gregorian](calendaridentifiers_gregorian.md) calendar, except that the year and era are different. The Taiwan calendar system recognizes only the current era.

Leap years in the Taiwan calendar correspond to the same leap years in the Gregorian calendar. A leap year in the Gregorian calendar is defined as a Gregorian year that is evenly divisible by four, except if it is divisible by 100. However, Gregorian years that are divisible by 400 are leap years. A common year has 365 days and a leap year has 366 days.

The Taiwan calendar has 12 months with 28 to 31 days each:

| [MonthAsNumericString](calendar_monthasnumericstring_952914344.md) | Month | Days in common years | Days in leap years |
|---|---|---|---|
| 1 | 1月 (January) | 31 | 31 |
| 2 | 2月 (February) | 28 | 29 |
| 3 | 3月 (March) | 31 | 31 |
| 4 | 4月 (April) | 30 | 30 |
| 5 | 5月 (May) | 31 | 31 |
| 6 | 6月 (June) | 30 | 30 |
| 7 | 7月 (July) | 31 | 31 |
| 8 | 8月 (August) | 31 | 31 |
| 9 | 9月 (September) | 30 | 30 |
| 10 | 10月 (October) | 31 | 31 |
| 11 | 11月 (November) | 30 | 30 |
| 12 | 12月 (December) | 31 | 31 |

February has 29 days during leap years and 28 during common years.

The date January 1, 2012 C.E. in the Gregorian calendar is equivalent to the first day of January in the year 101 of the current era in the Taiwan calendar.

Because the Taiwan calendar corresponds to the Gregorian calendar, Taiwan calendar strings for day of the week names and month names are localized for all supported locales and hence will appear in the language corresponding to the [ResolvedLanguage](calendar_resolvedlanguage.md) property of the calendar object.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)