---
-api-id: P:Windows.UI.Xaml.Controls.TimePicker.SelectedTime
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IReference<TimeSpan> SelectedTime { get;  set; }
-->

# Windows.UI.Xaml.Controls.TimePicker.SelectedTime

## -description

Gets or sets the time currently selected in the time picker.




## -property-value

The time currently selected in the time picker.

## -remarks

The time picker control has both [Time](timepicker_time.md)/[TimeChanged](timepicker_timechanged.md) and `SelectedTime`/[SelectedTimeChanged](timepicker_selectedtimechanged.md) APIs. The difference between these is that `Time` is not nullable, while `SelectedTime` is nullable.

The value of `SelectedTime` is used to populate the time picker and is `null` by default. If `SelectedTime` is `null`, the `Time` property is set to a [TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) of 0; otherwise, the `Time` value is synchronized with the `SelectedTime` value. When `SelectedTime` is `null`, the picker is 'unset' and shows the field names instead of a time.

The time won't increment in real-time (like a clock would) unless you provide a code binding to some value that does track the current time while the app is running.

You can set the time value as an attribute in XAML. This is probably easiest if you're already declaring the [TimePicker](timepicker.md) object in XAML and aren't using bindings for the time value. Use a string in the form *Hh*:*Mm* where *Hh* is hours and can be between 0 and 23 and *Mm* is minutes and can be between 0 and 59. A "0" can be the initial character in either *Hh* or *Mm* and is typically included for clarity of any values 0 thru 9. For example, "9:5" and "09:05" are both valid and represent the same time, but "09:05" is easier to read in markup.

To set the time in code, you have different techniques available depending on your programming language. The value is represented as [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) for C# and Visual Basic, or [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md) for Visual C++ component extensions (C++/CX). Probably the easiest way to produce a [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) value that's appropriate for `SelectedTime` is to use the [TimeSpan.Parse](/dotnet/api/system.timespan.parse?view=dotnet-uwp-10.0&preserve-view=true)static method. Use a string in the form *Hh*:*Mm* (hours:minutes).

Whether set in code or XAML, the [TimePicker](timepicker.md) class has coercion logic for the value it preserves when you attempt to set it. Any days values are ignored. Seconds values are ignored (for example seconds over 30 are not rounded up to the next minute). Fractional seconds are ignored. Values do not wrap around (for example a value of "24:00" is invalid.) The minimum value within the `TimeSpan` is a time of 0 (00:00, midnight) and the maximum value is 23:59. Values outside the range throw exceptions, but depending on the specifics the exceptions might originate in the `TimeSpan` construction rather than from validation and coercion of `SelectedTime`.

To set the `SelectedTime` value in Visual C++ component extensions (C++/CX), you set the `Duration` field of the [TimeSpan](../windows.foundation/timespan.md) structure. `Duration` specifies a time in 100 nanosecond units; write your own logic for converting to and from hours:minutes representations.

Any value you set for `SelectedTime` in code or XAML is specifying the initial value shown in the control. In the app at runtime that value is typically set by the user in the time picker's flyout. The time selected by the user is set and the [SelectedTimeChanged](timepicker_selectedtimechanged.md) event occurs when the user makes a change and presses the check mark button in the time picker flyout to commit their selection.

## -see-also

## -examples

Here, the `SelectedTime` property is used to compare the selected time to the current time.

Notice that because the `SelectedTime` property is nullable, you have to explicitly cast it to `DateTime`, like this: `DateTime myTime = (DateTime)(DateTime.Today + checkTimePicker.SelectedTime);`.

![A time picker, button, and text label.](images/date-time/time-picker-check.png)

```xaml
<StackPanel>
    <TimePicker x:Name="checkTimePicker"/>
    <Button Content="Check time" Click="{x:Bind CheckTime}"/>
    <TextBlock x:Name="resultText"/>
</StackPanel>
```

```csharp
private void CheckTime()
{
    // Using the SelectedTime property (nullable requires cast to DateTime).
    DateTime myTime = (DateTime)(DateTime.Today + checkTimePicker.SelectedTime);
    if (DateTime.Now >= myTime)
    {
        resultText.Text = "Your selected time has already past.";
    }
    else
    {
        string hrs = (myTime - DateTime.Now).Hours.ToString();
        string mins = (myTime - DateTime.Now).Minutes.ToString();
        resultText.Text = string.Format("Your selected time is {0} hours, {1} minutes from now.", hrs, mins);
    }
}
```
