---
-api-id: T:Windows.UI.Xaml.Media.Animation.CircleEase
-api-type: winrt class
---

<!-- Class syntax.
public class CircleEase : Windows.UI.Xaml.Media.Animation.EasingFunctionBase, Windows.UI.Xaml.Media.Animation.ICircleEase
-->

# Windows.UI.Xaml.Media.Animation.CircleEase

## -description
Represents an easing function that creates an animation that accelerates and/or decelerates using a circular function.



## -xaml-syntax
```xaml
<CircleEase .../>
```


## -remarks
CircleEase is an easing function that has a function-over-time formula that resembles a cosine curve when represented as a function-time graph. When [EasingMode](easingfunctionbase_easingmode.md) is **EaseIn** (the default), this easing function starts slow and accelerates gradually as it reaches the end. It reaches about 15% value halfway through the duration.

An easing function can be applied to the **EasingFunction** properties of **From**/**To**/**By** animations, or to the **EasingFunction** properties of key-frame types used for the **Easing** variants of key-frame animations. For more info, see [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

The formula used for this function is:

<img src="images/circleease_ft.png" alt="Formula of f(t) equals 1 minus square root of1 minus t squared" />

An easing function can be applied to the **EasingFunction** properties of **From**/**To**/**By** animations, or to the **EasingFunction** properties of key-frame types used for the **Easing** variants of key-frame animations. For more info, see [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

## -examples
This XAML example applies a CircleEase easing function to a [DoubleAnimation](doubleanimation.md) to create a decelerating animation.



[!code-xaml[CircleEase](../windows.ui.xaml.media.animation/code/CircleEase/csharp/Page.xaml#SnippetCircleEase)]

[!code-csharp[CircleEase_code](../windows.ui.xaml.media.animation/code/CircleEase/csharp/Page.xaml.cs#SnippetCircleEase_code)]

[!code-vb[CircleEase_code](../windows.ui.xaml.media.animation/code/CircleEase/vbnet/MainPage.xaml.vb#SnippetCircleEase_code)]

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [EasingFunctionBase](easingfunctionbase.md), [PowerEase](powerease.md), [BackEase](backease.md), [BounceEase](bounceease.md), [CubicEase](cubicease.md), [ElasticEase](elasticease.md), [ExponentialEase](exponentialease.md), [QuadraticEase](quadraticease.md), [QuarticEase](quarticease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md)
