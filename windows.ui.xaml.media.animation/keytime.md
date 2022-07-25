---
-api-id: T:Windows.UI.Xaml.Media.Animation.KeyTime
-api-type: winrt struct
---

<!-- Structure syntax.
public struct KeyTime 
-->

# KeyTime

## -description
Specifies when a particular key frame should take place during an animation.


## -xaml-syntax
```xaml
<object property="[days.]hours:minutes:seconds[.fractionalSeconds]"/>
```


## -xaml-values
<dl><dt>days</dt><dd>daysOptional. An integer value greater than or equal to 0 that specifies the number of days.</dd>
<dt>hours</dt><dd>hoursRequired, even if 0. An integer value between 0 and 23 that specifies the number of hours.</dd>
<dt>minutes</dt><dd>minutesOptional if only hours are desired, but must be set at least to 0 if you intend to set a seconds value. An integer value between 0 and 59 that specifies the number of minutes.</dd>
<dt>seconds</dt><dd>secondsOptional if only hours/minutes are desired. An integer value between 0 and 59 that specifies the number of seconds.</dd>
<dt>fractionalSeconds</dt><dd>fractionalSecondsOptional. A value consisting of 1 to 7 digits of decimal precision that specifies fractional seconds.</dd>
</dl>

## -struct-fields

### -field TimeSpan
The time component of this KeyTime.
    

## -remarks
Each key frame's **KeyTime** property specifies when that key frame ends. It does not specify how long the key frame plays. The amount of time a key frame plays is determined by when the key frame ends, when the previous key frame ended, and the animation's duration.

Specifying a KeyTime by only an integer without any time span literal characters such as **:** or **.** will result in a KeyTime of that number of days! This is seldom the intended result. Usually you specify time spans in seconds. Thus the KeyTime string typically includes preceding zero values for hours and minutes, along with the literal **:** as separator between hours, minutes, and seconds. For example, to specify a KeyTime of five seconds, the correct string is "0:0:5" ("0:0:05" is equivalent).

### Notes on XAML syntax

You cannot declare a KeyTime as a shareable object in a [ResourceDictionary](../windows.ui.xaml/resourcedictionary.md).

### Projection and members of KeyTime

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), or Visual C++ component extensions (C++/CX), then KeyTime has some utility methods, and its data member [TimeSpan](/dotnet/api/system.windows.media.animation.keytime.timespan) is exposed as a read-only property, not a field.

For Microsoft .NET, [Duration](../windows.ui.xaml/duration.md) exposes [TimeSpan.Parse](/dotnet/api/system.timespan.parse?view=dotnet-uwp-10.0&preserve-view=true) for its [TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true), a **FromTimeSpan** method, and an **Implicit** operator. These aren't available from the structure in Visual C++ component extensions (C++/CX) but you can use [KeyTimeHelper.FromTimeSpan](keytimehelper_fromtimespan_845885131.md).

If you are programming with C++ using the Windows Runtime Template Library (WRL), then only the data member field **TimeSpan** exists as a member of KeyTime. WRL code can access [FromTimeSpan](keytimehelper_fromtimespan_845885131.md) as it exists on the [KeyTimeHelper](keytimehelper.md) class.

## -examples
This example uses XAML attribute syntax to set [KeyTime](doublekeyframe_keytime.md) values on several types of [DoubleAnimationUsingKeyFrames](doubleanimationusingkeyframes.md) classes.



[!code-xaml[Doubleanimationusingkeyframes](../windows.ui.xaml.media.animation/code/doubleanimationusingkeyframes/csharp/Page.xaml#SnippetDoubleanimationusingkeyframes)]

[!code-csharp[Doubleanimationusingkeyframes](../windows.ui.xaml.media.animation/code/doubleanimationusingkeyframes2/csharp/Page.xaml.cs#SnippetDoubleanimationusingkeyframes2)]

[!code-vb[Doubleanimationusingkeyframes](../windows.ui.xaml.media.animation/code/doubleanimationusingkeyframes2/vbnet/Page.xaml.vb#SnippetDoubleanimationusingkeyframes2)]

## -see-also
