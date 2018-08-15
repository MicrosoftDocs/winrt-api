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

The Taiwan calendar has 12 months with 28 to 31 days each:<table>
   <tr><th>[MonthAsNumericString](calendar_monthasnumericstring_952914344.md)</th><th>Month</th><th>Days in common years</th><th>Days in leap years</th></tr>
   <tr><td>1</td><td>1月 (January)</td><td>31</td><td>31</td></tr>
   <tr><td>2</td><td>2月 (February)</td><td>28</td><td>29</td></tr>
   <tr><td>3</td><td>3月 (March)</td><td>31</td><td>31</td></tr>
   <tr><td>4</td><td>4月 (April)</td><td>30</td><td>30</td></tr>
   <tr><td>5</td><td>5月 (May)</td><td>31</td><td>31</td></tr>
   <tr><td>6</td><td>6月 (June)</td><td>30</td><td>30</td></tr>
   <tr><td>7</td><td>7月 (July)</td><td>31</td><td>31</td></tr>
   <tr><td>8</td><td>8月 (August)</td><td>31</td><td>31</td></tr>
   <tr><td>9</td><td>9月 (September)</td><td>30</td><td>30</td></tr>
   <tr><td>10</td><td>10月 (October)</td><td>31</td><td>31</td></tr>
   <tr><td>11</td><td>11月 (November)</td><td>30</td><td>30</td></tr>
   <tr><td>12</td><td>12月 (December)</td><td>31</td><td>31</td></tr>
</table>

February has 29 days during leap years and 28 during common years.

The date January 1, 2012 C.E. in the Gregorian calendar is equivalent to the first day of January in the year 101 of the current era in the Taiwan calendar.

Because the Taiwan calendar corresponds to the Gregorian calendar, Taiwan calendar strings for day of the week names and month names are localized for all supported locales and hence will appear in the language corresponding to the [ResolvedLanguage](calendar_resolvedlanguage.md) property of the calendar object.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)