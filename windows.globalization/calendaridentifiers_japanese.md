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

The [CalendarIdentifiers](calendaridentifiers.md) class assigns numbers to the Japanese eras as follows:<table>
   <tr><th>[Era](calendar_era.md) value</th><th>[EraAsString](calendar_eraasstring_1742852677.md)</th><th>Gregorian Dates</th></tr>
   <tr><td>4</td><td>平成 (Heisei)</td><td>January 8, 1989 to present</td></tr>
   <tr><td>3</td><td>昭和 (Showa)</td><td>December 25, 1926 to January 7, 1989</td></tr>
   <tr><td>2</td><td>大正 (Taisho)</td><td>July 30, 1912 to December 24, 1926</td></tr>
   <tr><td>1</td><td>明治 (Meiji)</td><td>January 1, 1868 to July 29, 1912</td></tr>
</table>

The [CalendarIdentifiers](calendaridentifiers.md) class handles dates only from the first day of the first month in the year Meiji 1 (January 1, 1868 of the Gregorian calendar). Although the Japanese calendar was switched from a lunar calendar to a solar calendar in the year Meiji 6 (1873 of the Gregorian calendar), this implementation is based on the solar calendar only.

Leap years in the Japanese calendar correspond to the same leap years in the Gregorian calendar. A leap year in the Gregorian calendar is defined as a Gregorian year that is evenly divisible by four, except if it is divisible by 100. However, Gregorian years that are divisible by 400 are leap years. A common year has 365 days and a leap year has 366 days.

The Japanese calendar has 12 months with 28 to 31 days each:<table>
   <tr><th>[MonthAsNumericString](calendar_monthasnumericstring_952914344.md)</th><th>Month</th><th>English</th><th>Days in common years</th><th>Days in leap years</th></tr>
   <tr><td>1</td><td>1月 (Ichigatsu)</td><td>January</td><td>31</td><td>31</td></tr>
   <tr><td>2</td><td>2月 (Nigatsu)</td><td>February</td><td>28</td><td>29</td></tr>
   <tr><td>3</td><td>3月 (Sangatsu)</td><td>March</td><td>31</td><td>31</td></tr>
   <tr><td>4</td><td>4月 (Shigatsu)</td><td>April</td><td>30</td><td>30</td></tr>
   <tr><td>5</td><td>5月 (Gogatsu)</td><td>May</td><td>31</td><td>31</td></tr>
   <tr><td>6</td><td>6月 (Rokugatsu)</td><td>June</td><td>30</td><td>30</td></tr>
   <tr><td>7</td><td>7月 (Shichigatsu)</td><td>July</td><td>31</td><td>31</td></tr>
   <tr><td>8</td><td>8月 (Hachigatsu)</td><td>August</td><td>31</td><td>31</td></tr>
   <tr><td>9</td><td>9月 (Kugatsu)</td><td>September</td><td>30</td><td>30</td></tr>
   <tr><td>10</td><td>10月 (Juugatsu)</td><td>October</td><td>31</td><td>31</td></tr>
   <tr><td>11</td><td>11月 (Juuichigatsu)</td><td>November</td><td>30</td><td>30</td></tr>
   <tr><td>12</td><td>12月 (Juunigatsu)</td><td>December</td><td>31</td><td>31</td></tr>
</table>

Nigatsu, which is equivalent to the Gregorian calendar month of February, has 29 days during leap years and 28 during common years.

The date January 1, 2012 A.D. in the Gregorian calendar is equivalent to the first day of Ichigatsu in the year Heisei 24 in the Japanese calendar.

Japanese calendar strings for era, day of the week names and month names are not localized and hence will appear in Japanese regardless of the current value of the [ResolvedLanguage](calendar_resolvedlanguage.md) property of the calendar object.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)