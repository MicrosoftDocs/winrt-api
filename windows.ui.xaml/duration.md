---
-api-id: T:Windows.UI.Xaml.Duration
-api-type: winrt struct
---

<!-- Structure syntax.
public struct Duration
-->

# Duration

## -description

Represents the duration of time that a [Timeline](../windows.ui.xaml.media.animation/timeline.md) is active, or more generally represents a duration of time that also supports two special values **Automatic** and **Forever**.



## -xaml-syntax

```xaml
<object property="[days.]hours:minutes:seconds[.fractionalSeconds]"/>
-or-
<object property="Automatic" .../>
-or-
<object property="Forever" .../>
```

## -xaml-values

<dl><dt>days</dt><dd>daysAn integer value greater than or equal to 0 that specifies the number of days.</dd>
<dt>hours</dt><dd>hoursAn integer value between 0 and 23 that specifies the number of hours. If you specify a Duration as a XAML attribute, an hours component is required, even if it is 0.</dd>
<dt>minutes</dt><dd>minutesAn integer value between 0 and 59 that specifies the number of minutes. Set hours:minutes components as 0:0 if you are setting only a seconds component.</dd>
<dt>seconds</dt><dd>secondsAn integer value between 0 and 59 that specifies the number of seconds. Set hours:minutes components as 0:0 if you are setting only a seconds component.</dd>
<dt>fractionalSeconds</dt><dd>fractionalSecondsOptional. A decimal value consisting of 1 to 7 positions past the decimal point, which specifies fractional seconds.</dd>
<dt>Automatic</dt><dd>AutomaticThe literal string Automatic.</dd>
<dt>Forever</dt><dd>ForeverThe literal string Forever.</dd>
</dl>

## -struct-fields

### -field TimeSpan

The **TimeSpan** value component.
<!--DON'T link this keyword, the type is projected so you actually need two different links-->

### -field Type

The type as a member of the enumeration.

## -remarks

A Duration value is used for these properties:

+ [Timeline.Duration](../windows.ui.xaml.media.animation/timeline_duration.md) (can be set on either a [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) or an animation)
+ [VisualTransition.GeneratedDuration](visualtransition_generatedduration.md)
+ [RepeatBehavior.Duration](/uwp/api/windows.ui.xaml.media.animation.repeatbehavior.duration)
+ [MediaElement.NaturalDuration](../windows.ui.xaml.controls/mediaelement_naturalduration.md) (this usage isn't part of the storyboarded animation scenario; all the others are)

For more info on how to use a Duration as part of a [Timeline](../windows.ui.xaml.media.animation/timeline.md), including code examples, see [Storyboarded animations](/windows/uwp/design/motion/storyboarded-animations) or [Timeline.Duration](../windows.ui.xaml.media.animation/timeline_duration.md).

### XAML usage

The most common way to use a Duration value in the Windows Runtime is to set it using a XAML attribute. When you set a value in XAML, you're supplying a string, and the string is parsed using the _hours_:_minutes_:_seconds_ string format and its variants as described here.

```xaml
<object property="[days.]hours:minutes:seconds[.fractionalSeconds]"/>
```

+ _days_: An integer value greater than or equal to 0 that specifies the number of days.
+ _hours_: An integer value between 0 and 23 that specifies the number of hours. If you specify a Duration as a XAML attribute, an hours component is required, even if it is 0.
+ _minutes_: An integer value between 0 and 59 that specifies the number of minutes. If you specify a Duration as a XAML attribute, an minutes component is required, even if it is 0.
+ _seconds_: An integer value between 0 and 59 that specifies the number of seconds. Set hours:minutes components as 0:0 if you are setting only a seconds component.
+ _fractionalSeconds_: Optional. A decimal value consisting of 1 to 7 positions past the decimal point, which specifies fractional seconds.

```xaml
<object property="Automatic" .../>
```

+ _Automatic_: The literal string `Automatic`.

```xaml
<object property="Forever" .../>
```

+ _Forever_: The literal string `Forever`.

Specifying a Duration using a string that resembles an integer, without any literal characters used in the _hours_:_minutes_:_seconds_ string format such as **:** or **.** will result in a Duration of that number of days! This is seldom the intended result. Usually you specify animation durations in seconds. As such, the Duration string must include preceding 0 values for *hours* and *minutes*, with literal **:** characters as separators between *hours* and *minutes*, and between *minutes* and *seconds*. For example, to specify a Duration of five seconds, the correct string for a XAML attribute value is "0:0:5" ("0:0:05" is equivalent).

#### Notes on XAML syntax

In the grammar shown in the XAML attribute usage, [ ] (square brackets) indicates optional values, the [ ] are not literals. The **:** (colon) and **.** (period) characters are both literals, and delimit the **h:m:s** string form of a common time span, or the optional *days* and *fractionalSeconds* values.

Use the literal strings "Automatic" and "Forever" as XAML attribute values if you want a Duration that has behavior as documented by [Duration.Automatic](/dotnet/api/windows.ui.xaml.duration.automatic?view=dotnet-uwp-10.0&preserve-view=true) and [Duration.Forever](/dotnet/api/windows.ui.xaml.duration.forever?view=dotnet-uwp-10.0&preserve-view=true).

Duration does not support an object element syntax, and you cannot declare a Duration as a shareable item in a [ResourceDictionary](resourcedictionary.md).

### Code usage

If you're using a Duration in code, a Duration uses a definition of time that is also used by the **TimeSpan** structure. The **TimeSpan** structure is represented by [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) if you are programming using C# or Microsoft Visual Basic, or [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md) if you are programming using C++.

+ The C# or Microsoft Visual Basic [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) has a [Parse](/dotnet/api/system.timespan.parse?view=dotnet-uwp-10.0&preserve-view=true) method that uses the _hours_:_minutes_:_seconds_ string format. If you need to create a Duration value in code you can call the [Duration](/dotnet/api/windows.ui.xaml.duration.-ctor?view=dotnet-uwp-10.0&preserve-view=true) constructor and provide the [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) argument by calling [TimeSpan.Parse](/dotnet/api/system.timespan.parse?view=dotnet-uwp-10.0&preserve-view=true) with an _hours_:_minutes_:_seconds_ string. Always use the "en-us" culture for parsing this string, because that's how XAML interprets the string format, and you shouldn't be using culture-specific inputs for animating timings anyways.
+ The C++ [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md) doesn't support a way to create it in an _hours_:_minutes_:_seconds_ string format. You'll have to use [DurationHelper.FromTimeSpan](durationhelper_fromtimespan_845885131.md), and do the conversion yourself for how _hours_:_minutes_:_seconds_ converts to the C++ [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md) data value, which is a value in milliseconds.

### Automatic and Forever

**Automatic** and **Forever** are values that hold special meaning for a Duration property value. For Microsoft .NET, these are represented by the static properties [Automatic](/dotnet/api/windows.ui.xaml.duration.automatic?view=dotnet-uwp-10.0&preserve-view=true) and [Forever](/dotnet/api/windows.ui.xaml.duration.forever?view=dotnet-uwp-10.0&preserve-view=true).

The **Automatic** value applied in either XAML or code results in different behavior on a [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) as opposed to an animation.

+ For [Storyboard](../windows.ui.xaml.media.animation/storyboard.md), the **Automatic** value sets the effective time span to be equal to the end time of its longest-running child animation, such that no clipping occurs for any child animation.
+ For animations, the **Automatic** value results in the behavior whereby the animation runs with a time span of 1 second (0:0:1). This behavior is seldom desirable as a final result, but it enables you to see the running animation during testing, before you have established a final time span.

> [!IMPORTANT]
> Using **Forever** for an animation is a deprecated usage, and is seldom used. This results in an animation that never advances from its starting value, no matter what values were provided for **From**/**To**, key frames, and so on. If you want an animation to repeat continuously, use `RepeatBehavior="Forever"`, not `Duration="Forever"`.

### Projection and members of Duration

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), or Visual C++ component extensions (C++/CX), then Duration has non-data members available, and its data members are exposed as read-write properties, not fields. Duration exposes several operators, including comparison operators. See [Duration](/dotnet/api/windows.ui.xaml.duration?view=dotnet-uwp-10.0&preserve-view=true) in the .NET API Browser.

For Microsoft .NET, Duration exposes [TimeSpan.Parse](/dotnet/api/system.timespan.parse?view=dotnet-uwp-10.0&preserve-view=true) for its [TimeSpan](/dotnet/api/windows.ui.xaml.duration.timespan?view=dotnet-uwp-10.0&preserve-view=true) property, [Implicit](/dotnet/api/windows.ui.xaml.duration.op_implicit?view=dotnet-uwp-10.0&preserve-view=true) and [UnaryPlus](/dotnet/api/windows.ui.xaml.duration.op_unaryplus?view=dotnet-uwp-10.0&preserve-view=true) operators, and [Add](/dotnet/api/windows.ui.xaml.duration.add?view=dotnet-uwp-10.0&preserve-view=true) and [Subtract](/en-us/dotnet/api/windows.ui.xaml.duration.subtract?view=dotnet-uwp-10.0&preserve-view=true) methods. These aren't available from the structure in Visual C++ component extensions (C++/CX) but you can use equivalent [DurationHelper](durationhelper.md) methods for some of these.

If you are programming with [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) or the [Windows Runtime C++ Template Library (WRL)](/cpp/windows/windows-runtime-cpp-template-library-wrl), then only the data member fields exist as members of Duration, and you cannot use the utility methods or properties of the .NET projection. C++ code can access similar utility methods that exist on the [DurationHelper](durationhelper.md) class. For example, you can call [DurationHelper.Compare](durationhelper_compare_2000782616.md) to compare two C++ Duration values. For more info, see [DurationHelper](durationhelper.md).

This table shows the equivalent properties and methods available in .NET and C++.

| .NET ([Duration](/dotnet/api/windows.ui.xaml.duration?view=dotnet-uwp-10.0&preserve-view=true)) | C++ ([DurationHelper](durationhelper.md)) |
| ---- | --- |
| [Duration(TimeSpan)](/dotnet/api/windows.ui.xaml.duration.-ctor?view=dotnet-uwp-10.0&preserve-view=true) | [FromTimeSpan(TimeSpan)](durationhelper_fromtimespan_845885131.md) |
| [Automatic](/dotnet/api/windows.ui.xaml.duration.automatic?view=dotnet-uwp-10.0&preserve-view=true) | [Automatic](durationhelper_automatic.md) |
| [Forever](/dotnet/api/windows.ui.xaml.duration.forever?view=dotnet-uwp-10.0&preserve-view=true) | [Forever](durationhelper_forever.md) |
| [HasTimeSpan](/dotnet/api/windows.ui.xaml.duration.hastimespan?view=dotnet-uwp-10.0&preserve-view=true) | [GetHasTimeSpan(Duration)](durationhelper_gethastimespan_1442142909.md) |
| [Add(Duration)](/dotnet/api/windows.ui.xaml.duration.add?view=dotnet-uwp-10.0&preserve-view=true) | [Add(Duration, Duration)](durationhelper_add_1212811817.md) |
| [Compare(Duration, Duration)](/dotnet/api/windows.ui.xaml.duration.compare?view=dotnet-uwp-10.0&preserve-view=true) | [Compare(Duration, Duration)](durationhelper_compare_2000782616.md) |
| [Equals](/dotnet/api/windows.ui.xaml.duration.equals?view=dotnet-uwp-10.0&preserve-view=true) | [Equals(Duration, Duration)](durationhelper_equals_1572893362.md) |
| [Subtract(Duration)](/dotnet/api/windows.ui.xaml.duration.subtract?view=dotnet-uwp-10.0&preserve-view=true) | [Subtract(Duration, Duration)](durationhelper_subtract_1357848268.md) |

## -examples

## -see-also

[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Storyboard](../windows.ui.xaml.media.animation/storyboard.md), [Timeline.Duration](../windows.ui.xaml.media.animation/timeline_duration.md)
