---
-api-id: P:Windows.UI.Xaml.Controls.TimePicker.Time
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan Time { get;  set; }
-->

# Windows.UI.Xaml.Controls.TimePicker.Time

## -description
Gets or sets the time currently set in the time picker.

## -xaml-syntax
```xaml
<TimePicker Time="timeSpanString" />
```


## -xaml-values
<dl><dt>timeSpanString</dt><dd>timeSpanStringA string that can be parsed to construct a valid TimeSpan value. Typically this is provided in the form Hh:Mm, see Remarks.</dd>
</dl>
## -property-value
The time currently set in the time picker.

## -remarks
The default value for Time is the time that the [TimePicker](timepicker.md) object is instantiated when the app runs or loads that specific object, as a one-time operation. The time won't increment in real-time (like a clock would) unless you provide a code binding to some value that does track the current time while the app is running.

You can set the Time value as an attribute in XAML. This is probably easiest if you're already declaring the [TimePicker](timepicker.md) object in XAML and aren't using bindings for the [Time](timepicker.md) value. Use a string in the form *Hh*:*Mm* where *Hh* is hours and can be between 0 and 23 and *Mm* is minutes and can be between 0 and 59. A "0" can be the initial character in either *Hh* or *Mm* and is typically included for clarity of any values 0 thru 9. For example, "9:5" and "09:05" are both valid and represent the same time, but "09:05" is easier to read in markup.

To set Time in code, you have different techniques available depending on your programming language. The value is represented as [System.TimeSpan](https://docs.microsoft.com/dotnet/api/system.timespan?redirectedfrom=MSDN) for C# and Visual Basic, or [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md) for Visual C++ component extensions (C++/CX). Probably the easiest way to produce a [System.TimeSpan](https://docs.microsoft.com/dotnet/api/system.timespan?redirectedfrom=MSDN) value that's appropriate for Time is to use the [TimeSpan.Parse](https://docs.microsoft.com/dotnet/api/system.timespan.parse#System_TimeSpan_Parse_System_String_)static method. Use a string in the form *Hh*:*Mm* (hours:minutes).

Whether set in code or XAML, the [TimePicker](timepicker.md) class has coercion logic for the value it preserves when you attempt to set it. Any days values are ignored. Seconds values are ignored (for example seconds over 30 are not rounded up to the next minute). Fractional seconds are ignored. Values do not wrap around (for example a value of "24:00" is invalid.) The minimum value within the **TimeSpan** is a time of 0 (00:00, midnight) and the maximum value is 23:59. Values outside the range throw exceptions, but depending on the specifics the exceptions might originate in the **TimeSpan** construction rather than from validation and coercion of [Time](timepicker.md).

To set the [Time](timepicker.md) value in Visual C++ component extensions (C++/CX), you set the **Duration** field of the [TimeSpan](../windows.foundation/timespan.md) structure. **Duration** specifies a time in 100 nanosecond units, write your own logic for converting to and from hours:minutes representations.

Any value set for [Time](timepicker.md) is specifying the starting value, but in the app at runtime that value is typically set by the user either directly in the [TimePicker](timepicker.md) control, or within a form-factor-specific flyout that enables the user to set hours and minutes. A flyout's UI can be influenced by other properties of [TimePicker](timepicker.md) (like [ClockIdentifier](timepicker_clockidentifier.md) and [MinuteIncrement](timepicker_minuteincrement.md)) and will display the initial [Time](timepicker.md) value. A flyout typically sets the [Time](timepicker.md) value when the user makes a change and dismisses the flyout.

## -examples

## -see-also
