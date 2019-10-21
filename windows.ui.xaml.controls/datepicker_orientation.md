---
-api-id: P:Windows.UI.Xaml.Controls.DatePicker.Orientation
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Orientation Orientation { get;  set; }
-->

# Windows.UI.Xaml.Controls.DatePicker.Orientation

## -description
Gets or sets a value that indicates whether the day, month, and year selectors are stacked horizontally or vertically.

## -xaml-syntax
```xaml
<DatePicker Orientation="Horizontal"/>
-or-
<DatePicker Orientation="Vertical"/>
```


## -property-value
A named constant of the enumeration that indicates whether the day, month, and year selectors are stacked horizontally or vertically. The default is [Horizontal](orientation.md).

## -remarks
By default, the [DatePicker](datepicker.md) shows the month, day, and year pickers in a horizontal row. You can change them to a vertical stack by setting the Orientation property to [Vertical](orientation.md).


<!--There is a good chance this property isn't respected when the Phone uses the DatePickerFlyout, should test.-->

## -examples

## -see-also
