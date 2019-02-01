---
-api-id: P:Windows.UI.Xaml.Controls.DatePicker.CalendarIdentifier
-api-type: winrt property
---

<!-- Property syntax
public string CalendarIdentifier { get;  set; }
-->

# Windows.UI.Xaml.Controls.DatePicker.CalendarIdentifier

## -description
Gets or sets the calendar system to use.

## -xaml-syntax
```xaml
<DatePicker CalendarIdentifier="calendarSystem"/>
```


## -xaml-values
<dl><dt>calendarSystem</dt><dd>calendarSystemThe name of the calendar system to use. See Remarks.</dd>
</dl>
## -property-value
The calendar system to use.

## -remarks
Set the [CalendarIdentifier](datepicker_calendaridentifier.md) property to specify the calendar system used by the [DatePicker](datepicker.md). The [DatePicker](datepicker.md) supports all calendar systems in the [CalendarIdentifiers](../windows.globalization/calendaridentifiers.md) class. To set the [CalendarIdentifier](datepicker_calendaridentifier.md) in XAML, use the identifier string. To set it in code, use the corresponding [CalendarIdentifiers](../windows.globalization/calendaridentifiers.md) property. See the Examples section.

This table lists the supported calendar systems. See the [CalendarIdentifiers](../windows.globalization/calendaridentifiers.md) documentation for more information about each calendar system.

<table>
   <tr><th>Calendar system</th><th>Identifier string</th><th>Localized?</th></tr>
   <tr><td>[Gregorian](../windows.globalization/calendaridentifiers_gregorian.md)</td><td>"GregorianCalendar"</td><td>Yes.</td></tr>
   <tr><td>[Hebrew](../windows.globalization/calendaridentifiers_hebrew.md)</td><td>"HebrewCalendar"</td><td>No. Strings always in Hebrew.</td></tr>
   <tr><td>[Hijri](../windows.globalization/calendaridentifiers_hijri.md)</td><td>"HijriCalendar"</td><td>No. Strings always in Arabic.</td></tr>
   <tr><td>[Japanese](../windows.globalization/calendaridentifiers_japanese.md)</td><td>"JapaneseCalendar"</td><td>No. Strings always in Japanese.</td></tr>
   <tr><td>[Julian](../windows.globalization/calendaridentifiers_julian.md)</td><td>"JulianCalendar"</td><td>Yes.</td></tr>
   <tr><td>[Korean](../windows.globalization/calendaridentifiers_korean.md)</td><td>"KoreanCalendar"</td><td>Yes.</td></tr>
   <tr><td>[Taiwan](../windows.globalization/calendaridentifiers_taiwan.md)</td><td>"TaiwanCalendar"</td><td>Yes.</td></tr>
   <tr><td>[Thai](../windows.globalization/calendaridentifiers_thai.md)</td><td>"ThaiCalendar"</td><td>Yes.</td></tr>
   <tr><td>[UmAlQura](../windows.globalization/calendaridentifiers_umalqura.md)</td><td>"UmAlQuraCalendar"</td><td>No. Strings always in Arabic.</td></tr>
</table>

The string content of each [ComboBox](combobox.md) in the [DatePicker](datepicker.md) is created by a [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md). The [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) uses the [CalendarIdentifier](datepicker_calendaridentifier.md) set on the [DatePicker](datepicker.md) to determine which calendar to use to format the content. If the [CalendarIdentifier](datepicker_calendaridentifier.md) is not set, the [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) uses the default calendar for the app’s preferred language (see [ApplicationLanguages](../windows.globalization/applicationlanguages.md)).

If the specified calendar system is localized, it will display in the app’s preferred language. For example, if you specify a Korean calendar and the app language is "en-us", the [DatePicker](datepicker.md) will display in English because there are translations for the Korean calendar. However, if you specify a Japanese calendar and the app preferred language is "en-us", the [DatePicker](datepicker.md) will still display in Japanese because there are no translations for the Japanese calendar.

## -examples
To set the [CalendarIdentifier](datepicker_calendaridentifier.md) in XAML, use the identifier string, as shown here.

```xaml
<DatePicker x:Name="julianDatePicker" CalendarIdentifier="JulianCalendar"/>
```

To set the [CalendarIdentifier](datepicker_calendaridentifier.md) on code, use the value returned by the corresponding [CalendarIdentifiers](../windows.globalization/calendaridentifiers.md) property, as shown here.

```csharp

DatePicker julianDatePicker = new DatePicker();
julianDatePicker.CalendarIdentifier = Windows.Globalization.CalendarIdentifiers.Julian;
```



## -see-also
[CalendarIdentifiers](../windows.globalization/calendaridentifiers.md), [DateTimeFormatter.Calendar](../windows.globalization.datetimeformatting/datetimeformatter_calendar.md), [Quickstart: Adding a DatePicker](https://msdn.microsoft.com/library/feae870d-e423-457b-9d0a-3929247952a9)
