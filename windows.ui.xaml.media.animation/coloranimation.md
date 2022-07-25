---
-api-id: T:Windows.UI.Xaml.Media.Animation.ColorAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class ColorAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IColorAnimation
-->

# Windows.UI.Xaml.Media.Animation.ColorAnimation

## -description
Animates the value of a [Color](../windows.ui/color.md) property between two target values using linear interpolation over a specified [Duration](timeline_duration.md).



## -xaml-syntax
```xaml
<ColorAnimation .../>
```


## -remarks
Use ColorAnimation to animate the property value of any dependency property that is of type [Color](../windows.ui/color.md).

Linear interpolation for a [Color](../windows.ui/color.md) means that each of the **ARGB** values is treated as a byte and the interpolation is simply a mathematical operation. You get best results from color interpolation if at least one of the **RGB** components is the same or close to the same in both the starting value and ending value.

You usually need to use indirect property targeting in order to target a sub-property of another object that's the value of a property on the target. This is because very few properties that display color information in UI elements are actually of type [Color](../windows.ui/color.md). Most are instead of type [Brush](../windows.ui.xaml.media/brush.md). To use ColorAnimation on UI elements, you typically are targeting the [Color](../windows.ui.xaml.media/solidcolorbrush_color.md) property of a [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) that's the sub-property value. Syntax for this is shown in the XAML example in the "Examples" section. For more info on indirect property targeting and other storyboarded animation concepts, see [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations) or [Property-path syntax](/windows/uwp/xaml-platform/property-path-syntax).

A ColorAnimation typically has at least one of the [From](coloranimation_from.md), [By](coloranimation_by.md) or [To](coloranimation_to.md) properties set, but never all three.
+ **From only:** The animation progresses from the value specified by the [From](coloranimation_from.md) property to the base value of the property being animated.
+ **From and To:** The animation progresses from the value specified by the [From](coloranimation_from.md) property to the value specified by the [To](coloranimation_to.md) property.
+ **From and By:** The animation progresses from the value specified by the [From](coloranimation_from.md) property to the value specified by the sum of the [From](coloranimation_from.md) and [By](coloranimation_by.md) properties.
+ **To only:** The animation progresses from the animated property's base value or a previous animation's output value to the value specified by the [To](coloranimation_to.md) property.
+ **By only:** The animation progresses from the base value of the property being animated or a previous animation's output value to the sum of that value and the value specified by the [By](coloranimation_by.md) property.


The [From](coloranimation_from.md), [By](coloranimation_by.md) and [To](coloranimation_to.md) properties of a ColorAnimation aren't strictly a [Color](../windows.ui/color.md). Instead these are a [Nullable](/dotnet/api/system.nullable-1?view=dotnet-uwp-10.0&preserve-view=true) for [Color](../windows.ui/color.md). The default value for these is **null**, not an uninitialized structure. That **null** value is how the animation system distinguishes that you haven't specifically set a value. Visual C++ component extensions (C++/CX) doesn't have a [Nullable](/dotnet/api/system.nullable-1?view=dotnet-uwp-10.0&preserve-view=true) type, so it uses [IReference](../windows.foundation/ireference_1.md) instead.

## -examples
The following example shows how to use ColorAnimation to animate the background color of a [StackPanel](../windows.ui.xaml.controls/stackpanel.md).



[!code-xaml[Coloranimation](../windows.ui.xaml.media.animation/code/coloranimation/csharp/Page.xaml#SnippetColoranimation)]


[!code-xaml[Coloranimation](../windows.ui.xaml.media.animation/code/coloranimationusingkeyframes/csharp/Page.xaml#SnippetColoranimationUsingKeyframes)]


[!code-xaml[Coloranimation](../windows.ui.xaml.media.animation/code/coloranimation_direct_targeting/csharp/Page.xaml#SnippetColoranimation_direct_targeting)]


[!code-csharp[Coloranimation_cs](../windows.ui.xaml.media.animation/code/coloranimation/csharp/Page.xaml.cs#SnippetColoranimation_cs)]

[!code-vb[Coloranimation_cs](../windows.ui.xaml.media.animation/code/coloranimation/vbnet/Page.xaml.vb#SnippetColoranimation_cs)]

```xaml
Storyboard.TargetProperty="(Panel.Background).(SolidColorBrush.Color)"
```

Alternatively, you could explicitly create the [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md), name it, and target its [Color](../windows.ui.xaml.media/solidcolorbrush_color.md) property directly. The example below shows how to create the same animation as the previous one except it uses direct property targeting.



[!code-xaml[Coloranimation_direct_targeting](../windows.ui.xaml.media.animation/code/coloranimation_direct_targeting/csharp/Page.xaml#SnippetColoranimation_direct_targeting)]


[!code-csharp[Coloranimation_direct_targeting_cs](../windows.ui.xaml.media.animation/code/coloranimation_direct_targeting/csharp/Page.xaml.cs#SnippetColoranimation_direct_targeting_cs)]

[!code-vb[Coloranimation_direct_targeting_cs](../windows.ui.xaml.media.animation/code/coloranimation_direct_targeting/vbnet/Page.xaml.vb#SnippetColoranimation_direct_targeting_cs)]

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [XAML animation sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20animation%20library%20sample), [Timeline](timeline.md), [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md), [LinearGradientBrush](../windows.ui.xaml.media/lineargradientbrush.md), [Color](../windows.ui/color.md), [Colors](../windows.ui/colors.md), [LinearGradientBrush](../windows.ui.xaml.media/lineargradientbrush.md), [Color](../windows.ui/color.md), [Colors](../windows.ui/colors.md)
