---
-api-id: P:Windows.UI.Xaml.Controls.DatePicker.YearVisible
-api-type: winrt property
---

<!-- Property syntax
public bool YearVisible { get;  set; }
-->

# Windows.UI.Xaml.Controls.DatePicker.YearVisible

## -description

Gets or sets a value that indicates whether the year selector is shown.



## -xaml-syntax

```xaml
<DatePicker YearVisible="bool"/>
```

## -property-value

**true** if the year selector is shown; otherwise, **false**. The default is **true**.

## -remarks

By default, the [DatePicker](datepicker.md) shows [ComboBox](combobox.md) elements to select the month, day, and year. Set `YearVisible` to **false** to hide the [ComboBox](combobox.md) that displays or changes the year component of a date.

Here's the picker with the year field hidden.

![A date picker with the year field hidden.](images/date-time/date-picker-year-hidden.png)

## -examples

## -see-also

[DayVisible](datepicker_dayvisible.md), [MonthVisible](datepicker_monthvisible.md), [YearFormat](datepicker_yearformat.md), [Date picker](/windows/uwp/design/controls-and-patterns/date-picker)
