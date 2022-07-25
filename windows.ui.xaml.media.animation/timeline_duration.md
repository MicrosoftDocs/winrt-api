---
-api-id: P:Windows.UI.Xaml.Media.Animation.Timeline.Duration
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Duration Duration { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.Timeline.Duration

## -description
Gets or sets the length of time for which this timeline plays, not counting repetitions.



## -xaml-syntax
```xaml
<timeline Duration="[days.]hours:minutes:seconds[.fractionalSeconds]"/>
-or-
<timeline Duration="Automatic" .../>
-or-
<timeline Duration="Forever" .../>
```


## -xaml-values
<dl><dt>days</dt><dd>daysAn integer value greater than or equal to 0 that specifies the number of days.</dd>
<dt>hours</dt><dd>hoursAn integer value between 0 and 23 that specifies the number of hours. If you specify a Duration as a XAML attribute, an hours component is required, even if is 0.</dd>
<dt>minutes</dt><dd>minutesAn integer value between 0 and 59 that specifies the number of minutes. Set hours:minutes components as 0:0 if you are setting only a seconds component.</dd>
<dt>seconds</dt><dd>secondsAn integer value between 0 and 59 that specifies the number of seconds. Set hours:minutes components as 0:0 if you are setting only a seconds component.</dd>
<dt>fractionalSeconds</dt><dd>fractionalSecondsOptional. A decimal value consisting of 1 to 7 positions past the decimal point, which specifies fractional seconds.</dd>
<dt>Automatic</dt><dd>AutomaticThe literal string Automatic.</dd>
<dt>Forever</dt><dd>ForeverThe literal string Forever.</dd>
</dl>
## -property-value
The timeline's simple duration: the amount of time this timeline takes to complete a single forward iteration. The default value is a [Duration](../windows.ui.xaml/duration.md) that evaluates as [Automatic](../windows.ui.xaml/durationhelper_automatic.md).

## -remarks
A [Duration](../windows.ui.xaml/duration.md) value has a **TimeSpan** component.
+ For Visual C++ component extensions (C++/CX), the data value of a [Duration](../windows.ui.xaml/duration.md) is a property named **TimeSpan**. This has a [TimeSpan](../windows.foundation/timespan.md) structure value, and that structure has a field named **Duration** that reports the duration as an **int64** that counts in 100-nanosecond units. [TimeSpan](../windows.foundation/timespan.md) doesn't have any methods for getting components of the time in *hours:minutes:seconds* format.
+ For C# or Microsoft Visual Basic, you can use utility methods of **System.TimeSpan** to get the duration components in whatever format you want. For example you can get [TimeSpan.Hours](/dotnet/api/system.timespan.hours?view=dotnet-uwp-10.0&preserve-view=true), [TimeSpan.Minutes](/dotnet/api/system.timespan.minutes?view=dotnet-uwp-10.0&preserve-view=true) and [TimeSpan.Seconds](/dotnet/api/system.timespan.seconds?view=dotnet-uwp-10.0&preserve-view=true) separately.
+ For more info, see Remarks in the [Duration](../windows.ui.xaml/duration.md) reference topic.


## -examples

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations)
