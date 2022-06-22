---
-api-id: P:Windows.UI.Xaml.Controls.DatePicker.MonthVisible
-api-type: winrt property
---

<!-- Property syntax
public bool MonthVisible { get;  set; }
-->

# Windows.UI.Xaml.Controls.DatePicker.MonthVisible

## -description
Gets or sets a value that indicates whether the month selector is shown.



## -xaml-syntax
```xaml
<DatePicker MonthVisible="bool"/>
```


## -property-value
**true** if the month selector is shown; otherwise, **false**. The default is **true**.

## -remarks
By default, the [DatePicker](datepicker.md) shows [ComboBox](combobox.md) elements to select the month, day, and year. Set `MonthVisible` to **false** to hide the [ComboBox](combobox.md) that displays or changes the month component of a date.

Here's the picker with the month field hidden.

![images/date-time/date-picker-month-hidden.png](A date picker with the month field hidden.)

It's typically not useful to show the day field without the month for context. A more common usage is to hide both the day and month, and show only the year, like this.

```xaml
<DatePicker x:Name="yearDatePicker" Header="In what year was Microsoft founded?" 
            MonthVisible="False" DayVisible="False"/>
```

![A date picker with the day and month fields hidden.](images/date-time/date-picker-year-only.png)

## -examples

## -see-also

[DayVisible](datepicker_dayvisible.md), [YearVisible](datepicker_yearvisible.md), [MonthFormat](datepicker_monthformat.md), [Date picker](/windows/uwp/design/controls-and-patterns/date-picker)
