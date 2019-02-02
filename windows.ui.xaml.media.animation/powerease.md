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
A [PowerEase](powerease.md) can be used to produce the same results as some of the other easing functions, depending on how [Power](powerease_power.md) is set. For example, a [CubicEase](cubicease.md) is the same as a [PowerEase](powerease.md) with [Power](powerease_power.md) of 3.

[Power](powerease_power.md) is a **Double** value so can be used to set non-integer values. For example you could use a [Power](powerease_power.md) of 2.5 to produce an easing function has a sharper curve than [QuadraticEase](quadraticease.md) but not as sharp as [CubicEase](cubicease.md).

An easing function can be applied to the **EasingFunction** properties of **From**/**To**/**By** animations, or to the **EasingFunction** properties of key-frame types used for the **Easing** variants of key-frame animations. For more info, see [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677).

## -examples
This XAML example applies a [PowerEase](powerease.md) easing function with a [Power](powerease_power.md) property value of 20 to a [DoubleAnimation](doubleanimation.md) to create a decelerating animation. Because the [Power](powerease_power.md) value is so high, the deceleration is sudden compared to what it would be if you used a lower value.



[!code-xml[PowerEase](../windows.ui.xaml.media.animation/code/PowerEase/csharp/Page.xaml#SnippetPowerEase)]

[!code-csharp[PowerEase_code](../windows.ui.xaml.media.animation/code/PowerEase/csharp/Page.xaml.cs#SnippetPowerEase_code)]

[!code-vb[PowerEase_code](../windows.ui.xaml.media.animation/code/PowerEase/vbnet/MainPage.xaml.vb#SnippetPowerEase_code)]

## -see-also
[Storyboarded animations](https://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677), [BackEase](backease.md), [BounceEase](bounceease.md), [CircleEase](circleease.md), [CubicEase](cubicease.md), [ElasticEase](elasticease.md), [ExponentialEase](exponentialease.md), [QuadraticEase](quadraticease.md), [QuarticEase](quarticease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md)
rticease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md)
