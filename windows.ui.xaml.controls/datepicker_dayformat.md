---
-api-id: P:Windows.UI.Xaml.Controls.DatePicker.DayFormat
-api-type: winrt property
---

<!-- Property syntax
public string DayFormat { get;  set; }
-->

# Windows.UI.Xaml.Controls.DatePicker.DayFormat

## -description
Gets or sets the display format for the day value.



## -xaml-syntax
```xaml
<DatePicker DayFormat="formatString"/>
```


## -xaml-values
<dl><dt>formatString</dt><dd>formatStringThe string format to use to display the day. See Remarks.</dd>
</dl>
## -property-value
The display format for the day value.

## -remarks
Change the format of the day picker by setting the `DayFormat` property.

The string content of each [ComboBox](combobox.md) in the [DatePicker](datepicker.md) is created by a [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md). You inform the [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) how to format the day value by providing a string that is either a *format template* or a *format pattern*. Common templates and patterns for day values are listed in the following table.

<table>
   <tr><th>format pattern</th><th>format template</th></tr>
   <tr><td>`{day.integer} | {day.integer(n)}`</td><td>`day`</td></tr>
   <tr><td>`{dayofweek.full} | {dayofweek.abbreviated} | {dayofweek.abbreviated(n)}`</td><td>`dayofweek | dayofweek.full | dayofweek.abbreviated`</td></tr>
</table>

In some cases, using a format pattern gives you more precise control over the formatting. For example, you can use a format pattern to specify that the day picker always shows 2 digits, including a leading 0 when needed. You can also combine multiple format patterns. For example, you can combine the `{day}` and `{dayofweek.abbreviated}` formats to make the day picker show both the numeric date and the day of the week, like this: **14 Thu**. See the Examples section for more info.

For the complete list of format templates and format patterns, see the Remarks section of the [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) class documentation.

> [!NOTE]
> Some date formats should be avoided if the date picker might be displayed in a small area, such as adding the full string value of the day of week. These strings can be long and might be clipped if the DatePicker's width is forced to be small.

## -examples

Here's a [DatePicker](datepicker.md) formatted using format templates, and a [DatePicker](datepicker.md) formatted using format strings. Both [DatePicker](datepicker.md) controls look the same when the app is run because the formatting is equivalent.

```xaml
<!-- DatePicker formatted using format templates. -->
<DatePicker DayFormat="day" MonthFormat="month.numeric" YearFormat="year.abbreviated"/>

<!-- DatePicker formatted using format patterns. -->
<DatePicker DayFormat="{}{day.integer}" MonthFormat="{}{month.integer}" YearFormat="{}{year.abbreviated}"/>
```

![A date picker with its fields formatted.](images/date-time/date-picker-formatting.png)

Here's a [DatePicker](datepicker.md) that combines 2 format patterns to display both the numeric date and the day of the week in the day picker. There is no equivalent format template for this format.

```xaml
<DatePicker DayFormat="{}{day.integer} {dayofweek.abbreviated}"/>
```

![A date picker with the day field formatted to show an integer and abbreviation.](images/date-time/date-picker-day-format.png)

## -see-also

[DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md), [MonthFormat](datepicker_monthformat.md), [YearFormat](datepicker_yearformat.md), [DayVisible](datepicker_dayvisible.md), [Date picker](/windows/uwp/design/controls-and-patterns/date-picker), [Use templates and patterns to format dates and times](/windows/uwp/design/globalizing/use-patterns-to-format-dates-and-times)
