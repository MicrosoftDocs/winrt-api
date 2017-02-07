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
This example shows the creation of an [AnimationDescription](animationdescription.md) object and its use. The *effect* and *target* parameters are assumed to have been previously assigned.


<!-- @WRITER erictill 5/21/2012 : Need to show where those effect and target variables come from. You need them. This part confuses me. These are animationEffect and animationEffectTarget values. Those are the Major Animations, and they're made up of an assortment of scale, opacity, and translation animations. -->
```javascript

var animationDescription = new Windows.UI.Core.AnimationMetrics.AnimationDescription(effect, target);

var StaggerDelay = animationDescription.staggerDelay;
var StaggerDelayFactor = animationDescription.staggerDelayFactor;
var DelayLimit = animationDescription.delayLimit;
var ZOrder = animationDescription.zorder;

var animations = animationDescription.animations;
for (var i = 0; i < animations.size; i++) {
    var animation = animations[i];

    switch (animation.type) {
        case animationMetrics.PropertyAnimationType.scale:
            // Retrieve scale animation metrics
            break;
        case animationMetrics.PropertyAnimationType.translation:
            // Retrieve translation animation metrics
            break;
        case animationMetrics.PropertyAnimationType.opacity:
            
            // Retrieve scale animation metrics
            break;
    }
}
```

The following example shows the C# version of the same code.

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

The following example shows the C++ version of the same code.

```cpp

using namespace Windows::UI::Core::AnimationMetrics;



                    
```



## -see-also
[Animation metrics sample](http://go.microsoft.com/fwlink/p/?linkid=242462), [OpacityAnimation](opacityanimation.md), [ScaleAnimation](scaleanimation.md), [TranslationAnimation](translationanimation.md)