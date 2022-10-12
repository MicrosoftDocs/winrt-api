---
-api-id: T:Windows.UI.Xaml.Media.Animation.RepeatBehavior
-api-type: winrt struct
---

<!-- Structure syntax.
public struct RepeatBehavior 
-->

# RepeatBehavior

## -description
Describes how a [Timeline](timeline.md) repeats its simple duration.

## -xaml-syntax
```xaml
<object property="iterationsx"/>
- or -
<object property="[days.]hours:minutes:seconds[.fractionalSeconds]"/>
- or -
<object property="Forever"/>
```


## -xaml-values
<dl><dt>iterationsx</dt><dd>iterationsxThe iterations placeholder in the iterations form is an integer, specifying the number of times that an animation should repeat. The x is a literal, lower-case character x. (A way to remember this convention is to think of x as a multiplication character, that is, 3x means 3 times.) Iterations set the Count data; a TimeSpan value does not set the Count data.</dd>
<dt>days</dt><dd>daysOptional. An integer value greater than or equal to 0 that specifies the number of days.</dd>
<dt>hours</dt><dd>hoursRequired, even if 0. An integer value between 0 and 23 that specifies the number of hours.</dd>
<dt>minutes</dt><dd>minutesOptional if only hours are desired, but must be set to at least 0 if you intend to set a seconds value. An integer value between 0 and 59 that specifies the number of minutes.</dd>
<dt>seconds</dt><dd>secondsOptional if only hours/minutes are desired. An integer value between 0 and 59 that specifies the number of seconds.</dd>
<dt>fractionalSeconds</dt><dd>fractionalSecondsOptional. A value consisting of 1 to 7 digits of decimal precision that specifies fractional seconds.</dd>
<dt>Forever</dt><dd>ForeverThe literal Forever; see Remarks.</dd>
</dl>

## -struct-fields

### -field Count
The number of times a [Timeline](timeline.md) should repeat.
    

### -field Duration
The time span for which a [Timeline](timeline.md) should repeat.
    

### -field Type
The mode or type of repeat behavior that this instance represents, as a value of the enumeration.
    

## -remarks
There are three types of RepeatBehavior behaviors:
+ Time span: specifies the active duration of a [Timeline](timeline.md), possibly repeating the animation if the [Timeline.Duration](timeline_duration.md) is shorter. For example, a [Timeline](timeline.md) with a simple [Timeline.Duration](timeline_duration.md) value of 1 second and a [RepeatBehavior.Duration](/uwp/api/windows.ui.xaml.media.animation.repeatbehavior.duration) value of 2.5 seconds will run for 2.5 iterations, and 2.5 seconds.
+ Iteration count: specifies the number of times the simple duration of a [Timeline](timeline.md) plays. The default iteration count is 1.0, and this means the [Timeline](timeline.md) is active for exactly one of its simple durations. A count of 0.5 specifies that the timeline is active for half of its simple duration, while a count of 2 specifies that the timeline repeats its simple duration twice. For more information, see [Count](/uwp/api/windows.ui.xaml.media.animation.repeatbehavior.count).
+ Forever: the [Timeline](timeline.md) repeats indefinitely.


A RepeatBehavior should only contain non-zero values for one of its two possible data properties **Count** or **Duration**. If the **RepeatBehaviorType** is **Count**, then the **Count** member of a RepeatBehavior is the relevant value. If the **RepeatBehaviorType** is **Duration**, then the **Duration** member of a RepeatBehavior is the relevant value. If the **RepeatBehaviorType** is **Forever**, then neither **Count** nor **Duration** are relevant; the repeat behavior is such that the targeted animation will repeat continuously without a limit.

### Notes on XAML syntax

You cannot declare a RepeatBehavior as a shareable object in a [ResourceDictionary](../windows.ui.xaml/resourcedictionary.md).

### Projection and members of RepeatBehavior

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), then RepeatBehavior has non-data members available, and its data members [Count](/uwp/api/windows.ui.xaml.media.animation.repeatbehavior.count), [Duration](/uwp/api/windows.ui.xaml.media.animation.repeatbehavior.duration) and [Type](/dotnet/api/windows.ui.xaml.media.animation.repeatbehavior.type#windows-ui-xaml-media-animation-repeatbehavior-type) are exposed as read-write properties, not fields.

If you are using Visual C++ component extensions (C++/CX), then RepeatBehavior has non-data members available, and its data members [Count](/uwp/api/windows.ui.xaml.media.animation.repeatbehavior.count), [Duration](/uwp/api/windows.ui.xaml.media.animation.repeatbehavior.duration) and [Type](/dotnet/api/windows.ui.xaml.media.animation.repeatbehavior.type#windows-ui-xaml-media-animation-repeatbehavior-type) are exposed as read-only properties, not fields.

If you are programming with C++ using the Windows Runtime Template Library (WRL), then only the data member fields **Count**, **Duration**, and **Type** exist as members of RepeatBehavior, and you cannot use the utility methods or properties listed in the members table. WRL code can access similar utility methods that exist on the [RepeatBehaviorHelper](repeatbehaviorhelper.md) class.

## -examples
This example shows several different ways to set the [RepeatBehavior](timeline_repeatbehavior.md) of an animation and how these settings can affect your animation.



[!code-xaml[RepeatBehavior](../windows.ui.xaml.media.animation/code/RepeatBehavior/csharp/MainPage.xaml#SnippetRepeatBehavior)]

[!code-csharp[RepeatBehavior_code](../windows.ui.xaml.media.animation/code/RepeatBehavior/csharp/MainPage.xaml.cs#SnippetRepeatBehavior_code)]

This example shows how you can set the [RepeatBehavior](timeline_repeatbehavior.md) in code. The animations are the same as in the previous example, but have the **x:Name** attribute set, and the RepeatBehavior is set in the `Start_Animation` method rather than in XAML.

```xaml
<Storyboard x:Name="myStoryboard">

    <!-- Create an animation that repeats indefinitely. -->
    <DoubleAnimation x:Name="ForeverRepeatingAnimation"
                     Storyboard.TargetName="ForeverRepeatingTransform" 
                     Storyboard.TargetProperty="ScaleX" 
                     From="1" To="5" Duration="0:0:2"  />

    <!-- Create an animation that repeats for four seconds. Because 
        the animation is 2 seconds each, you get two repeats. -->
    <DoubleAnimation x:Name="FourSecondsRepeatingAnimation"
                     Storyboard.TargetName="FourSecondsRepeatingTransform" 
                     Storyboard.TargetProperty="ScaleX"
                     From="1" To="5" Duration="0:0:2"  
                     EnableDependentAnimation="True"/>

    <!-- Create an animation that repeats twice. -->
    <DoubleAnimation x:Name="TwiceRepeatingAnimation"
                     Storyboard.TargetName="TwiceRepeatingTransform" 
                     Storyboard.TargetProperty="ScaleX" 
                     From="1" To="5" Duration="0:0:2"  
                     EnableDependentAnimation="True"/>
</Storyboard>
```

```csharp
private void Start_Animation(object sender, RoutedEventArgs e)
{
    // Set RepeatBehavior of Forever.
    var repeatBehavior = new RepeatBehavior();
    repeatBehavior.Type = RepeatBehaviorType.Forever;
    ForeverRepeatingAnimation.RepeatBehavior = repeatBehavior;

    // Set RepeatBehavior with Duration of 4 seconds.
    FourSecondsRepeatingAnimation.RepeatBehavior = new RepeatBehavior(new TimeSpan(0, 0, 4));

    // Set RepeatBehavior with Count of 2.
    TwiceRepeatingAnimation.RepeatBehavior = new RepeatBehavior(2);

    myStoryboard.Begin();
}
```

## -see-also
