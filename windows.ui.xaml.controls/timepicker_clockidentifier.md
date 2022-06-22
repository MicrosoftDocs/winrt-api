---
-api-id: P:Windows.UI.Xaml.Controls.TimePicker.ClockIdentifier
-api-type: winrt property
---

<!-- Property syntax
public string ClockIdentifier { get;  set; }
-->

# Windows.UI.Xaml.Controls.TimePicker.ClockIdentifier

## -description
Gets or sets the clock system to use.



## -xaml-syntax
```xaml
<TimePicker ClockIdentifier="12HourClock"/>
-or-
<TimePicker ClockIdentifier="24HourClock"/>
```

## -property-value
The name of the clock system to use. See Remarks.
## -remarks
The type of the property is **String**, but you must use values that correspond to the static string properties of [Windows.Globalization.ClockIdentifiers](../windows.globalization/clockidentifiers.md). These are: [TwelveHour](../windows.globalization/clockidentifiers_twelvehour.md) (the string "12HourClock")and [TwentyFourHour](../windows.globalization/clockidentifiers_twentyfourhour.md) (the string "24HourClock"). "12HourClock" is the default value.

## -examples

This example shows time pickers using both 12-hour and 24-hour clocks.

```xaml
<TimePicker Header="12HourClock" SelectedTime="14:30"/>
<TimePicker Header="24HourClock" SelectedTime="14:30" ClockIdentifier="24HourClock"/>
```

![A time picker showing a 12 hour clock, and a picker showing a 24 hour clock.](images/date-time/time-picker-clocks.png)

## -see-also

[Windows.Globalization.ClockIdentifiers](../windows.globalization/clockidentifiers.md)
