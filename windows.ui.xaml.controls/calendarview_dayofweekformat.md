---
-api-id: P:Windows.UI.Xaml.Controls.CalendarView.DayOfWeekFormat
-api-type: winrt property
---

<!-- Property syntax
public string DayOfWeekFormat { get;  set; }
-->

# Windows.UI.Xaml.Controls.CalendarView.DayOfWeekFormat

## -description
Gets or sets the display format for the day of the week headers.



## -xaml-syntax
```xaml
<CalendarView DayOfWeekFormat="formatString"/>
```

## -xaml-values
<dl><dt>formatString</dt><dd>formatStringThe string format to use to display the day. See Remarks.</dd>
</dl>

## -property-value

The display format for the day of the week header values.

## -remarks

Change the format of the day of the week headers by setting the DayOfWeekFormat property.

The string content of each day of the week header is created by a [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md). You inform the [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) how to format the day value by providing a *format pattern* string. Common patterns for day values are listed in the following table.

| format pattern | example |
| -------------- | --------------- |
| {dayofweek.abbreviated} | Sun Mon Tue |
| {dayofweek.abbreviated(2)} | Su Mo Tu |
| {dayofweek.abbreviated(3)} | Sun Mon Tue |
| {dayofweek.solo.abbreviated} | Sun Mon Tue |
| {dayofweek.solo.abbreviated(2)} | Su Mo Tu |
| {dayofweek.solo.abbreviated(3)} | Sun Mon Tue |

> [!CAUTION]
> When you use a _format pattern_ in XAML, you need to include a set of empty braces before the format string, like this: `DayOfWeekFormat="{}{dayofweek.abbreviated}"` Also see Examples.

For more info about format patterns, including when to use the _solo_ options, see the Remarks section of the [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) class documentation.

> [!NOTE]
> You can set this property to any valid date/time format, but formats other than those listed previously don't make sense for the day of week header.

## -examples

Here's a CalendarView with the day of week headers formatted to show the 3 letter abbreviation.

```xaml
<CalendarView DayOfWeekFormat="{}{dayofweek.abbreviated(3)}"/>
```

Here's the same formatting option set in code.

```csharp
CalendarView calendarView1 = new CalendarView();
calendarView1.DayOfWeekFormat = "{dayofweek.abbreviated(3)}";
```

## -see-also
