---
-api-id: P:Windows.UI.Xaml.Controls.DatePickerFlyout.MonthFormat
-api-type: winrt property
---

<!-- Property syntax
public string MonthFormat { get;  set; }
-->

# Windows.UI.Xaml.Controls.DatePickerFlyout.MonthFormat

## -description
Gets or sets the display format for the month value.



## -xaml-syntax
```xaml
<DatePickerFlyout MonthFormat="formatString"/>
```


## -xaml-values
<dl><dt>formatString</dt><dd>formatStringThe string format to use to display the day. See Remarks.</dd>
</dl>
## -property-value
The display format for the month value.

## -remarks
Change the format of the month value by setting the MonthFormat property.

The string content of the month value is created by a [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md). You inform the [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) how to format the day value by providing a string that is either a *format template* or a *format pattern*. Common templates and patterns for day values are listed in the following table.

<table>
   <tr><th>format pattern</th><th>format template</th></tr>
   <tr><td>`{month.integer} | {month.integer(n)} `</td><td>`month.numeric`</td></tr>
   <tr><td>`{month.full} | {month.abbreviated} | {month.abbreviated(n)}`</td><td>`month | month.full | month.abbreviated`</td></tr>
</table>

In some cases, using a format pattern gives you more precise control over the formatting. For example, you can use a format pattern to specify that the month picker always shows 2 digits, including a leading 0 when needed. You can also combine multiple format patterns. For example, you can combine the `{month.integer}` and `{month.abbreviated}` formats to make the month picker show the month number and name, like this: **12 Dec**. See the Examples section for more info.

For the complete list of format templates and format patterns, see the Remarks section of the [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) class documentation.

> [!NOTE]
> Some date formats should be avoided if the date picker might be displayed in a small area, such as adding the full string value of the day of week. These strings can be long and might be clipped if the DatePicker's width is forced to be small.

## -examples

## -see-also
[DayFormat](datepickerflyout_dayformat.md), [YearFormat](datepickerflyout_yearformat.md), [DatePicker](datepicker.md), [DatePicker.DayFormat](datepicker_dayformat.md), [DatePicker.MonthFormat](datepicker_monthformat.md), [DatePicker.YearFormat](datepicker_yearformat.md), [DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md), [How to use patterns to format dates and times](/previous-versions/windows/apps/jj673581(v=win.10))
