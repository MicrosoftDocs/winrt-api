---
-api-id: P:Windows.Globalization.CalendarIdentifiers.Hebrew
-api-type: winrt property
---

<!-- Property syntax
public string Hebrew { get; }
-->

# Windows.Globalization.CalendarIdentifiers.Hebrew

## -description
Gets the identifier for the Hebrew calendar.

## -property-value
The string "HebrewCalendar", which is the identifier for the Hebrew calendar.

## -remarks

The Hebrew calendar recognizes two eras: B.C.E. (before the common era) and C.E. (current era). This implementation of the Hebrew calendar system recognizes only the current era (C.E.) and the Hebrew years 5343 to 5999 (1583 to 2239 in the [Gregorian](calendaridentifiers_gregorian.md) calendar).

In every 19-year cycle that ends with a year that is evenly divisible by 19, the 3rd, 6th, 8th, 11th, 14th, 17th, and 19th years are leap years. A common year can have from 353 to 355 days, depending on the placement of Jewish holidays. A leap year can have from 383 to 385 days.

The Hebrew calendar has 12 months during common years and 13 months during leap years:

| [MonthAsNumericString](calendar_monthasnumericstring_952914344.md) (common year) | [MonthAsNumericString](calendar_monthasnumericstring_952914344.md) (leap year) | Month | Days in common years | Days in leap years |
|---|---|---|---|---|
| 1 | 1 | תשרי (Tishrei) | 30 | 30 |
| 2 | 2 | חשון (Cheshvan) | 29/30 | 29/30 |
| 3 | 3 | כסלו (Kislev) | 29/30 | 29/30 |
| 4 | 4 | טבת (Tevet) | 29 | 29 |
| 5 | 5 | שבט (Shevat) | 30 | 30 |
| 6 | - | אדר (Adar) | 29 | - |
| - | 6 | אדר א (Adar Alef) | - | 30 |
| - | 7 | אדר ב (Adar Beit) | - | 29 |
| 7 | 8 | ניסן (Nissan) | 30 | 30 |
| 8 | 9 | אייר (Iyar) | 29 | 29 |
| 9 | 10 | סיון (Sivan) | 30 | 30 |
| 10 | 11 | תמוז (Tamuz) | 29 | 29 |
| 11 | 12 | אב (Av) | 30 | 30 |
| 12 | 13 | אלול (Elul) | 29 | 29 |

The days in Cheshvan and Kislev vary depending on the placement of Jewish holidays. During leap years, Adar is replaced by Adar Alef with 30 days and Adar Beit with 29 days. Adar Beit is considered the leap month. The last day of Adar Alef and all the days in Adar Beit are considered leap days.

The date January 1, 2012 A.D. in the Gregorian calendar is equivalent to the sixth day of Tevet in the year 5772 C.E. in the Hebrew calendar.

Hebrew calendar strings for day of the week names and month names are not localized and hence will appear in Hebrew regardless of the current value of the [ResolvedLanguage](calendar_resolvedlanguage.md) property of the calendar object.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)