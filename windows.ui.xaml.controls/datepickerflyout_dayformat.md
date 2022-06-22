---
-api-id: P:Windows.UI.Xaml.Controls.DatePickerFlyout.DayFormat
-api-type: winrt property
---

<!-- Property syntax
public string DayFormat { get;  set; }
-->

# Windows.UI.Xaml.Controls.DatePickerFlyout.DayFormat

## -description
Gets or sets the display format for the day value.



## -xaml-syntax
```xaml
<DatePickerFlyout DayFormat="formatString"/>
```


## -xaml-values
<dl><dt>formatString</dt><dd>formatStringThe string format to use to display the day. See Remarks.</dd>
</dl>
## -property-value
The display format for the day value.

## -remarks
Change the format of the day value by setting the DayFormat property.

The string content of the day value is created by a [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md). You inform the [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) how to format the day value by providing a string that is either a *format template* or a *format pattern*. Common templates and patterns for day values are listed in the following table.

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

## -see-also
[MonthFormat](datepickerflyout_monthformat.md), [YearFormat](datepickerflyout_yearformat.md), [DatePicker](datepicker.md), [DatePicker.DayFormat](datepicker_dayformat.md), [DatePicker.MonthFormat](datepicker_monthformat.md), [DatePicker.YearFormat](datepicker_yearformat.md), [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md), [How to use patterns to format dates and times](/previous-versions/windows/apps/jj673581(v=win.10))
