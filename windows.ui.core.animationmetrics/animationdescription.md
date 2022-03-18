---
-api-id: T:Windows.UI.Core.AnimationMetrics.AnimationDescription
-api-type: winrt class
---

<!-- Class syntax.
public class AnimationDescription : Windows.UI.Core.AnimationMetrics.IAnimationDescription
-->

# Windows.UI.Core.AnimationMetrics.AnimationDescription

## -description
Exposes a collection of individual animation effects that are performed on a specific target to make up a complete Windows opacity, scaling, or translation animation.

## -remarks

## -examples
This example shows the creation of an AnimationDescription object and its use. The *effect* and *target* parameters are assumed to have been previously assigned.

```csharp
using Windows.UI.Core.AnimationMetrics;

AnimationDescription animationDescription = new AnimationDescription(effect, target);

TimeSpan sd = animationDescription.StaggerDelay;
float tsf = animationDescription.StaggerDelayFactor;
TimeSpan dl = animationDescription.DelayLimit;
int zo = animationDescription.ZOrder;

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
    
    TimeSpan delay = animation.Delay;
    TimeSpan duration = animation.Duration;
    Point c1 = animation.Control1;
    Point c2 = animation.Control2;
}
```

## -see-also
[Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics), [OpacityAnimation](opacityanimation.md), [ScaleAnimation](scaleanimation.md), [TranslationAnimation](translationanimation.md)
