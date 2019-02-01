---
-api-id: T:Windows.UI.Xaml.Media.Animation.QuadraticEase
-api-type: winrt class
---

<!-- Class syntax.
public class QuadraticEase : Windows.UI.Xaml.Media.Animation.EasingFunctionBase, Windows.UI.Xaml.Media.Animation.IQuadraticEase
-->

# Windows.UI.Xaml.Media.Animation.QuadraticEase

## -description
Represents an easing function that creates an animation that accelerates and/or decelerates using the formula *f* (*t*) = *t*<sup>2</sup>

## -xaml-syntax
```xaml
<QuadraticEase .../>
```


## -remarks
[QuadraticEase](quadraticease.md) has the same behavior as does a [PowerEase](powerease.md) with [Power](powerease_power.md) value of 2. When [EasingMode](easingfunctionbase_easingmode.md) is **EaseIn** (the default), this easing function starts slow, remains fairly slow until about half way through the duration, and accelerates near the end of the duration time.

An easing function can be applied to the **EasingFunction** properties of **From**/**To**/**By** animations, or to the **EasingFunction** properties of key-frame types used for the **Easing** variants of key-frame animations. For more info, see [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677).

## -examples
The following example applies a [QuadraticEase](quadraticease.md) easing function to a [DoubleAnimation](doubleanimation.md) to create a decelerating animation.



[!code-xml[QuadraticEase](../windows.ui.xaml.media.animation/code/QuadraticEase/csharp/Page.xaml#SnippetQuadraticEase)]

[!code-csharp[QuadraticEase_code](../windows.ui.xaml.media.animation/code/QuadraticEase/csharp/Page.xaml.cs#SnippetQuadraticEase_code)]

[!code-vb[QuadraticEase_code](../windows.ui.xaml.media.animation/code/QuadraticEase/vbnet/MainPage.xaml.vb#SnippetQuadraticEase_code)]

## -see-also
[Storyboarded animations](https://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677), [PowerEase](powerease.md), [BackEase](backease.md), [BounceEase](bounceease.md), [CircleEase](circleease.md), [CubicEase](cubicease.md), [ElasticEase](elasticease.md), [ExponentialEase](exponentialease.md), [QuarticEase](quarticease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md)
rticease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md)
