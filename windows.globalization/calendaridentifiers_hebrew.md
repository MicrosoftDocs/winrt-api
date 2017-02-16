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
<!--{annotation author="raymonsh" time="9/6/2012 3:01:23 PM"}The following remarks are adapted from http://msdn.microsoft.com/en-us/library/system.globalization.hebrewcalendar-->
The Hebrew calendar recognizes two eras: B.C.E. (before the common era) and C.E. (current era). This implementation of the Hebrew calendar system recognizes only the current era (C.E.) and the Hebrew years 5343 to 5999 (1583 to 2239 in the [Gregorian](calendaridentifiers_gregorian.md) calendar).

In every 19-year cycle that ends with a year that is evenly divisible by 19, the 3rd, 6th, 8th, 11th, 14th, 17th, and 19th years are leap years. A common year can have from 353 to 355 days, depending on the placement of Jewish holidays. A leap year can have from 383 to 385 days.

The Hebrew calendar has 12 months during common years and 13 months during leap years:<table>
   <tr><th>[MonthAsNumericString](calendar_monthasnumericstring.md) (common year)</th><th>[MonthAsNumericString](calendar_monthasnumericstring.md) (leap year)</th><th>Month</th><th>Days in common years</th><th>Days in leap years</th></tr>
   <tr><td>1</td><td>1</td><td>תשרי (Tishrei)</td><td>30</td><td>30</td></tr>
   <tr><td>2</td><td>2</td><td>חשון (Cheshvan)</td><td>29/30</td><td>29/30</td></tr>
   <tr><td>3</td><td>3</td><td>כסלו (Kislev)</td><td>29/30</td><td>29/30</td></tr>
   <tr><td>4</td><td>4</td><td>טבת (Tevet)</td><td>29</td><td>29</td></tr>
   <tr><td>5</td><td>5</td><td>שבט (Shevat)</td><td>30</td><td>30</td></tr>
   <tr><td>6</td><td>-</td><td>אדר (Adar)</td><td>29</td><td>-</td></tr>
   <tr><td>-</td><td>6</td><td>אדר א (Adar Alef)</td><td>-</td><td>30</td></tr>
   <tr><td>-</td><td>7</td><td>אדר ב (Adar Beit)</td><td>-</td><td>29</td></tr>
   <tr><td>7</td><td>8</td><td>ניסן (Nissan)</td><td>30</td><td>30</td></tr>
   <tr><td>8</td><td>9</td><td>אייר (Iyar)</td><td>29</td><td>29</td></tr>
   <tr><td>9</td><td>10</td><td>סיון (Sivan)</td><td>30</td><td>30</td></tr>
   <tr><td>10</td><td>11</td><td>תמוז (Tamuz)</td><td>29</td><td>29</td></tr>
   <tr><td>11</td><td>12</td><td>אב (Av)</td><td>30</td><td>30</td></tr>
   <tr><td>12</td><td>13</td><td>אלול (Elul)</td><td>29</td><td>29</td></tr>
</table>

The days in Cheshvan and Kislev vary depending on the placement of Jewish holidays. During leap years, Adar is replaced by Adar Alef with 30 days and Adar Beit with 29 days. Adar Beit is considered the leap month. The last day of Adar Alef and all the days in Adar Beit are considered leap days.

The date January 1, 2012 A.D. in the Gregorian calendar is equivalent to the sixth day of Tevet in the year 5772 C.E. in the Hebrew calendar.

Hebrew calendar strings for day of the week names and month names are not localized and hence will appear in Hebrew regardless of the current value of the [ResolvedLanguage](calendar_resolvedlanguage.md) property of the calendar object.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)