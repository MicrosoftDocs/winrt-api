---
-api-id: P:Windows.Globalization.CalendarIdentifiers.ChineseLunar
-api-type: winrt property
---

<!-- Property syntax
public string ChineseLunar { get; }
-->

# Windows.Globalization.CalendarIdentifiers.ChineseLunar

## -description
Gets the identifier for the Chinese lunisolar calendar.

## -property-value
The string "ChineseLunarCalendar", which is the identifier for the Chinese lunar calendar.

## -remarks
<!--Should I/how much can I adapt from https://msdn.microsoft.com/library/system.globalization.chineselunisolarcalendar ?-->
This calendar supports the sexagenary year cycle (which repeats every 60 years) in addition to solar years and lunar months. Each solar year in the calendar is associated with a Sexagenary Year, a Celestial Stem, and a Terrestrial Branch, and these calendars can have leap months after any month of the year. The calendar calculates years based on solar calculations, and months and days based on lunar calculations.

A leap month can occur after any month in a year. For example, when you get a month from this calendar, you get a number between 1 and 13 that indicates the month associated with a specified date. If there is a leap month between the eighth and ninth months of the year, getting the month returns 8 for the eighth month, 9 for the leap eighth month, and 10 for the ninth month.

Currently, this calendar is not used by any of the supported cultures. Therefore, this value can be used only to calculate dates in the Chinese lunisolar calendar.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)