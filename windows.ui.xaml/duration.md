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
A [Duration](duration.md) value is used for these properties:
+ [Timeline.Duration](../windows.ui.xaml.media.animation/timeline_duration.md) (can be set on either a [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) or an animation)
+ [VisualTransition.GeneratedDuration](visualtransition_generatedduration.md)
+ [RepeatBehavior.Duration](../windows.ui.xaml.media.animation/repeatbehavior_duration.md)
+ [MediaElement.NaturalDuration](../windows.ui.xaml.controls/mediaelement_naturalduration.md) (this usage isn't part of the storyboarded animation scenario; all the others are)
For more info on how to use a [Duration](duration.md) as part of a [Timeline](../windows.ui.xaml.media.animation/timeline.md), including code examples, see [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a) or [Timeline.Duration](../windows.ui.xaml.media.animation/timeline_duration.md).

The most common way to use a [Duration](duration.md) value in the Windows Runtime is to set it using a XAML attribute. When you set a value in XAML, you're supplying a string, and the string is parsed using the *hours***:***minutes***:***seconds* string format and its variants as is described in the XAML Syntax sections near the beginning of this reference topic.

Specifying a [Duration](duration.md) using a string that resembles an integer, without any literal characters used in the *hours***:***minutes***:***seconds* string format such as **:** or **.** will result in a [Duration](duration.md) of that number of days! This is seldom the intended result. Usually you specify animation durations in seconds. As such, the [Duration](duration.md) string must include preceding 0 values for *hours* and *minutes*, with literal **:** characters as separators between *hours* and *minutes*, and between *minutes* and *seconds*. For example, to specify a [Duration](duration.md) of five seconds, the correct string for either or a XAML attribute value is "0:0:5" ("0:0:05" is equivalent).

If you're using a [Duration](duration.md) in code, a [Duration](duration.md) uses a definition of time that is also used by the **TimeSpan** structure. The **TimeSpan** structure is represented by [System.TimeSpan](https://msdn.microsoft.com/library/system.timespan.aspx) if you are programming using C# or Microsoft Visual Basic, or [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md) if you are programming using C++. 
+ The C# or Microsoft Visual Basic  [System.TimeSpan](https://msdn.microsoft.com/library/system.timespan.aspx) has a [Parse](XREF:TODO:M:System.TimeSpan.Parse(System.String)) method that use *hours***:***minutes***:***seconds* string format. If you need to create a [Duration](duration.md) value in code you can call the [Duration](duration_duration.md) constructor and provide the [System.TimeSpan](https://msdn.microsoft.com/library/system.timespan.aspx) argument by calling [TimeSpan.Parse](XREF:TODO:M:System.TimeSpan.Parse(System.String)) with an *hours***:***minutes***:***seconds* string. Always use the "en-us" culture for parsing this string, because that's how XAML interprets the string format, and you shouldn't be using culture-specific inputs for animating timings anyways.
+ The C++ [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md) doesn't support a way to create it in an *hours***:***minutes***:***seconds* string format. You'll have to use [DurationHelper.FromTimeSpan](durationhelper_fromtimespan.md), and do the conversion yourself for how *hours***:***minutes***:***seconds* converts to the C++ [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md) data value, which is a value in milliseconds.


### Notes on XAML syntax

In the grammar shown in the XAML attribute usage, *[]* indicates optional values, the *[]* (square brackets) are not literals. The **:** (colon) and **.** (period) characters are both literals, and delimit the **h:m:s** string form of a common time span, or the optional *days* and *fractionalSeconds* values.

Use the literal strings "Automatic" and "Forever" as XAML attribute values if you want a [Duration](duration.md) that has behavior as documented by [Duration.Automatic](duration_automatic.md) and [Duration.Forever](duration_forever.md).

[Duration](duration.md) does not support an object element syntax, and you cannot declare a [Duration](duration.md) as a shareable item in a [ResourceDictionary](resourcedictionary.md).

### Projection and members of Duration

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), or in Visual C++ component extensions (C++/CX), then [Duration](duration.md) has non-data members available, and its data members are exposed as read-write properties, not fields. [Duration](duration.md) exposes several operators, including comparison operators.

For Microsoft .NET, [Duration](duration.md) exposes [TimeSpan.Parse](XREF:TODO:M:System.TimeSpan.Parse(System.String)) for its [TimeSpan](duration_timespan.md), [Implicit](duration_op_implicit.md) and [UnaryPlus](duration_op_unaryplus.md) operators, and [Add](duration_add.md) and [Subtract](duration_subtract.md) methods. These aren't available from the structure in Visual C++ component extensions (C++/CX) but you can use equivalent [DurationHelper](durationhelper.md) methods for some of these.

If you are programming with C++ using the Windows Runtime Template Library (WRL), then only the data member fields exist as members of [Duration](duration.md), and you cannot use the utility methods or properties listed in the members table. WRL code can access similar utility methods that exist on the [DurationHelper](durationhelper.md) class. For example, you can call [DurationHelper.Compare](durationhelper_compare.md) to compare two C++ [Duration](duration.md) values. For more info, see [DurationHelper](durationhelper.md).

### Automatic and Forever

**Automatic** and **Forever** are values that hold special meaning for a [Duration](duration.md) property value. For Microsoft .NET, these are represented by the static properties [Automatic](duration_automatic.md) and [Forever](duration_forever.md).

The **Automatic** value applied in either XAML or code results in different behavior on a [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) as opposed to an animation. For [Storyboard](../windows.ui.xaml.media.animation/storyboard.md), the **Automatic** value sets the effective time span to be equal to the end time of its longest-running child animation, such that no clipping occurs for any child animation. For animations, the **Automatic** value results in the behavior whereby the animation runs with a time span of 1 second (0:0:1). This behavior is seldom desirable as a final result, but it enables you to see the running animation during testing, before you have established a final time span.

Using **Forever** for an animation is a deprecated usage, and is seldom used. This results in an animation that never advances from its starting value, no matter what values were provided for **From**/**To**, key frames, and so on. If you want an animation to repeat continuously, use `RepeatBehavior="Forever"`, not `Duration="Forever"`.

## -examples

## -see-also
[Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Storyboard](../windows.ui.xaml.media.animation/storyboard.md), [Timeline.Duration](../windows.ui.xaml.media.animation/timeline_duration.md)