---
-api-id: T:Windows.UI.Xaml.Media.Animation.QuinticEase
-api-type: winrt class
---

<!-- Class syntax.
public class QuinticEase : Windows.UI.Xaml.Media.Animation.EasingFunctionBase, Windows.UI.Xaml.Media.Animation.IQuinticEase
-->

# Windows.UI.Xaml.Media.Animation.QuinticEase

## -description
Represents an easing function that creates an animation that accelerates and/or decelerates using the formula *f* (*t*) = *t*<sup>5</sup>.

## -xaml-syntax
```xaml
<QuinticEase .../>
```


## -remarks
[QuinticEase](quinticease.md) has the same behavior as does a [PowerEase](powerease.md) with [Power](powerease_power.md) value of 5. When [EasingMode](easingfunctionbase_easingmode.md) is **EaseIn** (the default), this easing function starts slow, remains slow for most of the duration, and accelerates very rapidly very near the end of the duration time.

An easing function can be applied to the **EasingFunction** properties of **From**/**To**/**By** animations, or to the **EasingFunction** properties of key-frame types used for the **Easing** variants of key-frame animations. For more info, see [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677).

## -examples
This XAML example applies a [QuinticEase](quinticease.md) easing function to a [DoubleAnimation](doubleanimation.md) to create a decelerating animation.



[!code-xml[QuinticEase](../windows.ui.xaml.media.animation/code/QuinticEase/csharp/Page.xaml#SnippetQuinticEase)]

[!code-csharp[QuinticEase_code](../windows.ui.xaml.media.animation/code/QuinticEase/csharp/Page.xaml.cs#SnippetQuinticEase_code)]

[!code-vb[QuinticEase_code](../windows.ui.xaml.media.animation/code/QuinticEase/vbnet/MainPage.xaml.vb#SnippetQuinticEase_code)]

## -see-also
[Storyboarded animations](https://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677), [PowerEase](powerease.md), [BackEase](backease.md), [BounceEase](bounceease.md), [CircleEase](circleease.md), [CubicEase](cubicease.md), [ElasticEase](elasticease.md), [ExponentialEase](exponentialease.md), [QuadraticEase](quadraticease.md), [QuarticEase](quarticease.md), [SineEase](sineease.md)
aticease.md), [QuarticEase](quarticease.md), [SineEase](sineease.md)
