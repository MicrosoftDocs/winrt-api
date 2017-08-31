---
-api-id: T:Windows.UI.Xaml.Media.Animation.DoubleAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class DoubleAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IDoubleAnimation
-->

# Windows.UI.Xaml.Media.Animation.DoubleAnimation

## -description
Animates the value of a [Double](https://msdn.microsoft.com/library/system.double.aspx) property between two target values using linear interpolation over a specified [Duration](timeline_duration.md).

## -xaml-syntax
```xaml
<DoubleAnimation />
```


## -remarks
Use [DoubleAnimation](doubleanimation.md) to animate the property value of any dependency property that is of type [Double](https://msdn.microsoft.com/library/system.double.aspx).

Sometimes you'll need to use indirect property targeting in order to target a sub-property of another object that's the value of a property on the target. For example, in order to animate the X component of a [RenderTransform](../windows.ui.xaml/uielement_rendertransform.md) of a [UIElement](../windows.ui.xaml/uielement.md), you need to reference some of the intermediate object-property values, until the last step in the indirect property path is truly a [Double](https://msdn.microsoft.com/library/system.double.aspx) value, as is the case with [TranslateTransform.X](../windows.ui.xaml.media/translatetransform_x.md). The correct string to use for [Storyboard.TargetProperty](storyboard_targetproperty.md) in this example is "(UIElement.RenderTransform).(TranslateTransform.X)". For more info on indirect property targeting and other storyboarded animation concepts, see [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a).

A [DoubleAnimation](doubleanimation.md) typically has at least one of the [From](doubleanimation_from.md), [By](doubleanimation_by.md) or [To](doubleanimation_to.md) properties set, but never all three.
+ **From only:** The animation progresses from the value specified by the **From** property to the base value of the property being animated.
+ **From and To:** The animation progresses from the value specified by the **From** property to the value specified by the **To** property.
+ **From and By:** The animation progresses from the value specified by the **From** property to the value specified by the sum of the **From** and **By** properties.
+ **To only:** The animation progresses from the animated property's base value or a previous animation's output value to the value specified by the **To** property.
+ **By only:** The animation progresses from the base value of the property being animated or a previous animation's output value to the sum of that value and the value specified by the **By** property.


You can't animate the **X** and **Y** values of a [Point](../windows.foundation/point.md) using a [DoubleAnimation](doubleanimation.md), because these properties aren't dependency properties ([Point](../windows.foundation/point.md) is a structure and can't have dependency properties.) Instead, use [PointAnimation](pointanimation.md) to animate dependency properties that have a [Point](../windows.foundation/point.md) value.

You also can't use [DoubleAnimation](doubleanimation.md) to animate **int** values or **byte** values. Instead, you'll have to use [ObjectAnimationUsingKeyFrames](objectanimationusingkeyframes.md), which won't give you an interpolation behavior, so you might need to define multiple keyframes to get a reasonably smooth animation. There aren't many UI-related dependency properties that use **int** values or **byte** values, so this shouldn't be a common scenario other than for custom properties.

The [From](doubleanimation_from.md), [By](doubleanimation_by.md) or [To](doubleanimation_to.md) properties of a [DoubleAnimation](doubleanimation.md) aren't strictly a [Double](https://msdn.microsoft.com/library/system.double.aspx). Instead these are a [Nullable](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) for [Double](https://msdn.microsoft.com/library/system.double.aspx). The default value for these is **null**, not 0. That **null** value is how the animation system distinguishes that you haven't specifically set a value. Visual C++ component extensions (C++/CX) doesn't have a [Nullable](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1) type, so it uses [IReference](../windows.foundation/ireference_1.md) instead.

## -examples
The following example shows how to use **DoubleAnimation** to create a rectangle that fades in and out of view after it is loaded.



[!code-xml[Doubleanimation](../windows.ui.xaml.media.animation/code/doubleanimation/csharp/Page.xaml#SnippetDoubleanimation)]

[!code-csharp[Doubleanimation_cs](../windows.ui.xaml.media.animation/code/doubleanimation/csharp/Page.xaml.cs#SnippetDoubleanimation_cs)]

[!code-vb[Doubleanimation_cs](../windows.ui.xaml.media.animation/code/doubleanimation/vbnet/Page.xaml.vb#SnippetDoubleanimation_cs)]

[!code-xml[Doubleanimation](../windows.ui.xaml.media.animation/code/doubleanimationusingkeyframes/csharp/Page.xaml#SnippetDoubleanimationUsingKeyFrames)]


[!code-csharp[Doubleanimation](../windows.ui.xaml.media.animation/code/doubleanimationusingkeyframes2/csharp/Page.xaml.cs#SnippetDoubleanimationUsingKeyframes2)]

[!code-vb[Doubleanimation](../windows.ui.xaml.media.animation/code/doubleanimationusingkeyframes2/vbnet/Page.xaml.vb#SnippetDoubleanimationUsingKeyframes2)]



## -see-also
[Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [XAML animation sample](http://go.microsoft.com/fwlink/p/?linkid=238571), [Timeline](timeline.md), [DoubleAnimationUsingKeyFrames](doubleanimationusingkeyframes.md), [Double](https://msdn.microsoft.com/library/system.double.aspx)
md), [Double](https://msdn.microsoft.com/library/system.double.aspx)
