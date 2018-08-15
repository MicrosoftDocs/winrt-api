---
-api-id: P:Windows.Globalization.CalendarIdentifiers.Hijri
-api-type: winrt property
---

<!-- Property syntax
public string Hijri { get; }
-->

# Windows.Globalization.CalendarIdentifiers.Hijri

## -description
Gets the identifier for the Hijri calendar.

## -property-value
The string "HijriCalendar", which is the identifier for the Hijri calendar.

## -remarks

The Hijri calendar system recognizes one era: A.H. (Latin "Anno Hegirae", which means "the year of the migration", in reference to the migration of Muhammad from Mecca).

In every 30-year cycle that ends with a year that is evenly divisible by 30, the 2nd, 5th, 7th, 10th, 13th, 16th, 18th, 21st, 24th, 26th, and 29th years are leap years. A common year has 354 days and a leap year has 355 days.

The Hijri calendar has 12 months with 29 to 30 days each:<table>
   <tr><th>[MonthAsNumericString](calendar_monthasnumericstring_952914344.md)</th><th>Month</th><th>Days in common years</th><th>Days in leap years</th></tr>
   <tr><td>1</td><td>محرم (Muharram)</td><td>30</td><td>30</td></tr>
   <tr><td>2</td><td>صفر (Safar)</td><td>29</td><td>29</td></tr>
   <tr><td>3</td><td>‏ربيع الاول (Rabi I)</td><td>30</td><td>30</td></tr>
   <tr><td>4</td><td>‏ربيع الثاني (Rabi II)</td><td>29</td><td>29</td></tr>
   <tr><td>5</td><td>جمادى الاولى (Jumada I)</td><td>30</td><td>30</td></tr>
   <tr><td>6</td><td>جمادى الثانية (Jumada II)</td><td>29</td><td>29</td></tr>
   <tr><td>7</td><td>رجب (Rajab)</td><td>30</td><td>30</td></tr>
   <tr><td>8</td><td>شعبان (Shaban)</td><td>29</td><td>29</td></tr>
   <tr><td>9</td><td>رمضان (Ramadan)</td><td>30</td><td>30</td></tr>
   <tr><td>10</td><td>شوال (Shawwal)</td><td>29</td><td>29</td></tr>
   <tr><td>11</td><td>ذو القعدة (Zulkadah)</td><td>30</td><td>30</td></tr>
   <tr><td>12</td><td>ذو الحجة (Zulhijjah)</td><td>29</td><td>30</td></tr>
</table>

Ramadan, the month of fasting in the Muslim world, officially starts and ends according to a decree that is based on the observation of the new moon. Therefore, the number of days in Shaban and the number of days in Ramadan vary.

The date January 1, 2012 A.D. in the [Gregorian](calendaridentifiers_gregorian.md) calendar is roughly equivalent to the seventh day of Safar in the year 1433 A.H. in the Hijri calendar.

Hijri calendar strings for day of the week names and month names are not localized and hence will appear in Arabic regardless of the current value of the [ResolvedLanguage](calendar_resolvedlanguage.md) property of the calendar object.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)