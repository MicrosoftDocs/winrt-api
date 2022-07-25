---
-api-id: T:Windows.UI.Xaml.Media.Animation.ExponentialEase
-api-type: winrt class
---

<!-- Class syntax.
public class ExponentialEase : Windows.UI.Xaml.Media.Animation.EasingFunctionBase, Windows.UI.Xaml.Media.Animation.IExponentialEase
-->

# Windows.UI.Xaml.Media.Animation.ExponentialEase

## -description
Represents an easing function that creates an animation that accelerates and/or decelerates using an exponential formula.



## -xaml-syntax
```xaml
<ExponentialEase .../>
```


## -remarks
ExponentialEase is an easing function that has a function-over-time formula that uses an [Exponent](exponentialease_exponent.md) value to shape the function-over-time curve. The value used for [Exponent](exponentialease_exponent.md) changes the shape of the curve quite a bit. [Exponent](exponentialease_exponent.md) can be negative, if so the function acts a bit like changing the [EasingMode](easingfunctionbase_easingmode.md) to **EaseOut** with a positive value. You might want to experiment with different values for [Exponent](exponentialease_exponent.md) and [EasingMode](easingfunctionbase_easingmode.md) when using this easing function.


<!--The IMG for the Silverlight topic is wrong cannot use it here.-->
An easing function can be applied to the **EasingFunction** properties of **From**/**To**/**By** animations, or to the **EasingFunction** properties of key-frame types used for the **Easing** variants of key-frame animations. For more info, see [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

## -examples
This XAML example applies a ExponentialEase easing function to a [DoubleAnimation](doubleanimation.md) to create a decelerating animation.



[!code-xaml[ExponentialEase](../windows.ui.xaml.media.animation/code/ExponentialEase/csharp/Page.xaml#SnippetExponentialEase)]

[!code-csharp[ExponentialEase_code](../windows.ui.xaml.media.animation/code/ExponentialEase/csharp/Page.xaml.cs#SnippetExponentialEase_code)]

[!code-vb[ExponentialEase_code](../windows.ui.xaml.media.animation/code/ExponentialEase/vbnet/MainPage.xaml.vb#SnippetExponentialEase_code)]

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [EasingFunctionBase](easingfunctionbase.md), [PowerEase](powerease.md), [BackEase](backease.md), [BounceEase](bounceease.md), [CircleEase](circleease.md), [CubicEase](cubicease.md), [ElasticEase](elasticease.md), [QuadraticEase](quadraticease.md), [QuarticEase](quarticease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md)
