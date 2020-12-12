---
-api-id: T:Windows.UI.Core.AnimationMetrics.OpacityAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class OpacityAnimation : Windows.UI.Core.AnimationMetrics.IOpacityAnimation, Windows.UI.Core.AnimationMetrics.IPropertyAnimation
-->

# Windows.UI.Core.AnimationMetrics.OpacityAnimation

## -description
Provides methods that enable you to retrieve the parameters of an opacity (fade in or fade out) animation.

## -remarks
The timing controls [Control1](opacityanimation_control1.md) and [Control2](opacityanimation_control2.md) specify the location of the first and second control points of a cubic Bézier curve. These two points have the same meaning as they do in the CSS **transition-timing-function** property. Control point zero is always (0,0) and control point three is always (1,1). The coordinates of [Control1](opacityanimation_control1.md) and [Control2](opacityanimation_control2.md) are always in the range 0 to 1, inclusive.

On the resulting Bézier curve, the x-coordinate represents time and the y-coordinate represents progress. The raw curve from (0,0) to (1,1) is scaled to match the actual duration and range of the animated transition, such that x=0 is the starting time of the transform, x=1 is the ending time, y=0 is the initial value of the animated property, and y=1 is the final value. Values of x and y between 0 and 1 represent corresponding intermediate values of time and the animation.

## -examples
To obtain an instance of the OpacityAnimation class, you first obtain the collection of [animations](animationdescription_animations.md) in the [animation description](animationdescription.md), and then walk that array of animations to find any that are of type [opacity](propertyanimationtype.md). The following example shows this process. The *effect* and *target* parameters are assumed to have been previously assigned. 

```csharp
using Windows.UI.Core.AnimationMetrics;

AnimationDescription animationDescription = new AnimationDescription(effect, target);
foreach (var animation in animationDescription.Animations)
{
    switch (animation.Type)
    {
        case PropertyAnimationType.Scale:
            {
                ScaleAnimation scale = animation as ScaleAnimation;
                // Retrieve scale animation metrics.
            }
            break;
        case PropertyAnimationType.Translation:
            {
                TranslationAnimation scale = animation as TranslationAnimation;
                // Retrieve translation animation metrics.
            }
            break;
        case PropertyAnimationType.Opacity:
            {
                OpacityAnimation opacity = animation as OpacityAnimation;
                // Retrieve opacity animation metrics.
            }
            break;
    }
}
```

## -see-also
[Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics), [AnimationDescription](animationdescription.md)
