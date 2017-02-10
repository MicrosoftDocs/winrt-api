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

<!--Valid strings are those returned by Windows.Globalization.ClockIdentifiers properties. In  code, best to use W.G.CI properties.-->

<!--List values-->

## -examples

## -see-also
[Windows.Globalization.ClockIdentifiers](../windows.globalization/clockidentifiers.md)