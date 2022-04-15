---
-api-id: P:Windows.Globalization.CalendarIdentifiers.Japanese
-api-type: winrt property
---

<!-- Property syntax
public string Japanese { get; }
-->

# Windows.Globalization.CalendarIdentifiers.Japanese

## -description
Gets the identifier for the Japanese calendar.

## -property-value
The string "JapaneseCalendar", which is the identifier for the Japanese calendar.

## -remarks

The Japanese calendar, also known as the Wareki calendar, works exactly like the [Gregorian](calendaridentifiers_gregorian.md) calendar, except that the year and era are different.

The Japanese calendar recognizes one era for every emperor's reign. The current era is the Heisei era, which began in the Gregorian calendar year 1989. The era name is typically displayed before the year. For example, the Gregorian calendar year 2012 is the Japanese calendar year Heisei 24.

The [CalendarIdentifiers](calendaridentifiers.md) class assigns numbers to the Japanese eras as follows:

| [Era](calendar_era.md) value | [EraAsString](calendar_eraasstring_1742852677.md) | Gregorian Dates |
|---|---|---|
| 4 | 平成 (Heisei) | January 8, 1989 to present |
| 3 | 昭和 (Showa) | December 25, 1926 to January 7, 1989 |
| 2 | 大正 (Taisho) | July 30, 1912 to December 24, 1926 |
| 1 | 明治 (Meiji) | January 1, 1868 to July 29, 1912 |

The [CalendarIdentifiers](calendaridentifiers.md) class handles dates only from the first day of the first month in the year Meiji 1 (January 1, 1868 of the Gregorian calendar). Although the Japanese calendar was switched from a lunar calendar to a solar calendar in the year Meiji 6 (1873 of the Gregorian calendar), this implementation is based on the solar calendar only.

Leap years in the Japanese calendar correspond to the same leap years in the Gregorian calendar. A leap year in the Gregorian calendar is defined as a Gregorian year that is evenly divisible by four, except if it is divisible by 100. However, Gregorian years that are divisible by 400 are leap years. A common year has 365 days and a leap year has 366 days.

The Japanese calendar has 12 months with 28 to 31 days each:

| [MonthAsNumericString](calendar_monthasnumericstring_952914344.md) | Month | English | Days in common years | Days in leap years |
|---|---|---|---|---|
| 1 | 1月 (Ichigatsu) | January | 31 | 31 |
| 2 | 2月 (Nigatsu) | February | 28 | 29 |
| 3 | 3月 (Sangatsu) | March | 31 | 31 |
| 4 | 4月 (Shigatsu) | April | 30 | 30 |
| 5 | 5月 (Gogatsu) | May | 31 | 31 |
| 6 | 6月 (Rokugatsu) | June | 30 | 30 |
| 7 | 7月 (Shichigatsu) | July | 31 | 31 |
| 8 | 8月 (Hachigatsu) | August | 31 | 31 |
| 9 | 9月 (Kugatsu) | September | 30 | 30 |
| 10 | 10月 (Juugatsu) | October | 31 | 31 |
| 11 | 11月 (Juuichigatsu) | November | 30 | 30 |
| 12 | 12月 (Juunigatsu) | December | 31 | 31 |

Nigatsu, which is equivalent to the Gregorian calendar month of February, has 29 days during leap years and 28 during common years.

The date January 1, 2012 A.D. in the Gregorian calendar is equivalent to the first day of Ichigatsu in the year Heisei 24 in the Japanese calendar.

Japanese calendar strings for era, day of the week names and month names are not localized and hence will appear in Japanese regardless of the current value of the [ResolvedLanguage](calendar_resolvedlanguage.md) property of the calendar object.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)