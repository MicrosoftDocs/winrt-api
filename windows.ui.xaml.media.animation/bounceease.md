---
-api-id: T:Windows.UI.Xaml.Media.Animation.BounceEase
-api-type: winrt class
---

<!-- Class syntax.
public class BounceEase : Windows.UI.Xaml.Media.Animation.EasingFunctionBase, Windows.UI.Xaml.Media.Animation.IBounceEase
-->

# Windows.UI.Xaml.Media.Animation.BounceEase

## -description
Represents an easing function that creates an animated bouncing effect.



## -xaml-syntax
```xaml
<BounceEase .../>
```


## -remarks
BounceEase has two controlling properties [Bounciness](bounceease_bounciness.md) and [Bounces](bounceease_bounces.md) that affect the behavior of the function.

[ElasticEase](elasticease.md) is a similar easing function that works well for physics emulation in animations. The difference with BounceEase is that an [ElasticEase](elasticease.md) can go outside the **From**/**To** range. Another way to conceptualize the two easing functions is that [ElasticEase](elasticease.md) is what you might use to animate the plucking of a string, whereas BounceEase is what you might use to show the bounce of a ball against a line or plane.

An easing function can be applied to the **EasingFunction** properties of **From**/**To**/**By** animations, or to the **EasingFunction** properties of key-frame types used for the **Easing** variants of key-frame animations. For more info, see [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

## -examples
The following example applies a BounceEase easing function to a [DoubleAnimation](doubleanimation.md) to create a bouncing effect.



[!code-xaml[BounceEase](../windows.ui.xaml.media.animation/code/BounceEase/csharp/Page.xaml#SnippetBounceEase)]


[!code-csharp[BounceEase_code](../windows.ui.xaml.media.animation/code/BounceEase/csharp/Page.xaml.cs#SnippetBounceEase_code)]

[!code-vb[BounceEase_code](../windows.ui.xaml.media.animation/code/BounceEase/vbnet/MainPage.xaml.vb#SnippetBounceEase_code)]

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [EasingFunctionBase](easingfunctionbase.md), [PowerEase](powerease.md), [BackEase](backease.md), [CircleEase](circleease.md), [CubicEase](cubicease.md), [ElasticEase](elasticease.md), [ExponentialEase](exponentialease.md), [QuadraticEase](quadraticease.md), [QuarticEase](quarticease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md)
