---
-api-id: T:Windows.UI.Xaml.Media.Animation.PowerEase
-api-type: winrt class
---

<!-- Class syntax.
public class PowerEase : Windows.UI.Xaml.Media.Animation.EasingFunctionBase, Windows.UI.Xaml.Media.Animation.IPowerEase
-->

# Windows.UI.Xaml.Media.Animation.PowerEase

## -description
Represents an easing function that creates an animation that accelerates and/or decelerates using the formula *f* (*t*) = *t**<sup>p</sup>* where *p* is equal to the [Power](powerease_power.md) property.



## -xaml-syntax
```xaml
<PowerEase .../>
```


## -remarks
A PowerEase can be used to produce the same results as some of the other easing functions, depending on how [Power](powerease_power.md) is set. For example, a [CubicEase](cubicease.md) is the same as a PowerEase with [Power](powerease_power.md) of 3.

[Power](powerease_power.md) is a **Double** value so can be used to set non-integer values. For example you could use a [Power](powerease_power.md) of 2.5 to produce an easing function has a sharper curve than [QuadraticEase](quadraticease.md) but not as sharp as [CubicEase](cubicease.md).

An easing function can be applied to the **EasingFunction** properties of **From**/**To**/**By** animations, or to the **EasingFunction** properties of key-frame types used for the **Easing** variants of key-frame animations. For more info, see [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

## -examples
This XAML example applies a PowerEase easing function with a [Power](powerease_power.md) property value of 20 to a [DoubleAnimation](doubleanimation.md) to create a decelerating animation. Because the [Power](powerease_power.md) value is so high, the deceleration is sudden compared to what it would be if you used a lower value.



[!code-xaml[PowerEase](../windows.ui.xaml.media.animation/code/PowerEase/csharp/Page.xaml#SnippetPowerEase)]

[!code-csharp[PowerEase_code](../windows.ui.xaml.media.animation/code/PowerEase/csharp/Page.xaml.cs#SnippetPowerEase_code)]

[!code-vb[PowerEase_code](../windows.ui.xaml.media.animation/code/PowerEase/vbnet/MainPage.xaml.vb#SnippetPowerEase_code)]

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [BackEase](backease.md), [BounceEase](bounceease.md), [CircleEase](circleease.md), [CubicEase](cubicease.md), [ElasticEase](elasticease.md), [ExponentialEase](exponentialease.md), [QuadraticEase](quadraticease.md), [QuarticEase](quarticease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md)
