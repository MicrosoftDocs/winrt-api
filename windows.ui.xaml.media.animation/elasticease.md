---
-api-id: T:Windows.UI.Xaml.Media.Animation.ElasticEase
-api-type: winrt class
---

<!-- Class syntax.
public class ElasticEase : Windows.UI.Xaml.Media.Animation.EasingFunctionBase, Windows.UI.Xaml.Media.Animation.IElasticEase
-->

# Windows.UI.Xaml.Media.Animation.ElasticEase

## -description
Represents an easing function that creates an animation that resembles a spring oscillating back and forth until it comes to rest.



## -xaml-syntax
```xaml
<ElasticEase .../>
```


## -remarks
ElasticEase is one of the two easing functions that can produce a value outside of the normal **From**/**To** range. (The other is [BackEase](backease.md).) As the easing function begins, the value oscillates positive and negative around the **From** value until it reaches an eventual positive amplitude that is the **To** value. The [Springiness](elasticease_springiness.md) property modifies the sinusoidal character of this oscillation. With [Springiness](elasticease_springiness.md) of 0, the oscillation is basically sinusoidal and resembles a typical diagram of a spring's motion. With larger [Springiness](elasticease_springiness.md) values, it's like dampening the spring's motion.

The [Oscillations](elasticease_oscillations.md) property declares how many times the function oscillates and crosses into values that are actually below the starting **From** value.

You might get best results by just experimenting with the [Springiness](elasticease_springiness.md), [Oscillations](elasticease_oscillations.md) and [EasingMode](easingfunctionbase_easingmode.md) properties until the animation is visually doing what you want for your animated property value scenario.

[BounceEase](bounceease.md) is a similar easing function that works well for physics emulation in animations. The difference with ElasticEase is that a [BounceEase](bounceease.md) won't ever go outside the **From**/**To** range. Another way to conceptualize the two easing functions is that ElasticEase is what you might use to animate the plucking of a string, whereas [BounceEase](bounceease.md) is what you might use to show the bounce of a ball against a line or plane.

An easing function can be applied to the **EasingFunction** properties of **From**/**To**/**By** animations, or to the **EasingFunction** properties of key-frame types used for the **Easing** variants of key-frame animations. For more info, see [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

## -examples
This XAML example applies an ElasticEase easing function to a [DoubleAnimation](doubleanimation.md) to create an animation that resembles a spring oscillating back and forth until it comes to rest.



[!code-xaml[ElasticEase](../windows.ui.xaml.media.animation/code/ElasticEase/csharp/Page.xaml#SnippetElasticEase)]

[!code-csharp[ElasticEase_code](../windows.ui.xaml.media.animation/code/ElasticEase/csharp/Page.xaml.cs#SnippetElasticEase_code)]

[!code-vb[ElasticEase_code](../windows.ui.xaml.media.animation/code/ElasticEase/vbnet/MainPage.xaml.vb#SnippetElasticEase_code)]

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [PowerEase](powerease.md), [BackEase](backease.md), [BounceEase](bounceease.md), [CircleEase](circleease.md), [CubicEase](cubicease.md), [ExponentialEase](exponentialease.md), [QuadraticEase](quadraticease.md), [QuarticEase](quarticease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md)
