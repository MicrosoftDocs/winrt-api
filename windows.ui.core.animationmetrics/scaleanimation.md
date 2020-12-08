---
-api-id: T:Windows.UI.Core.AnimationMetrics.ScaleAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class ScaleAnimation : Windows.UI.Core.AnimationMetrics.IPropertyAnimation, Windows.UI.Core.AnimationMetrics.IScaleAnimation
-->

# Windows.UI.Core.AnimationMetrics.ScaleAnimation

## -description
Provides methods that enable you to retrieve the parameters for a scaling (growing or shrinking) animation.

## -remarks
The scale is a factor that is applied to the object in either the x- or y- direction. A scale value of 1.0 represents no scaling, less than 1 represents shrinking, and greater than 1 represents magnification.

The origin point of a scale represents the center point around which the scaling should take place. This point remains fixed throughout the animation; it does not animate. The origin is stated as a fraction of the object's size. For example, a [NormalizedOrigin](scaleanimation_normalizedorigin.md).X of 0.25 represents a point 25% of the way from the left edge to the right edge of the object. If the object is 100 pixels wide, then a [NormalizedOrigin](scaleanimation_normalizedorigin.md).X represents a point 25 pixels from the left edge of the object.



> [!NOTE]
> The sense of left and right are flipped on right-to-left (RTL) systems.

As an example, consider an object whose coordinate rectangle is (100, 150, 200, 300), expressed in (left, top, right, bottom) format. Suppose that the interpolated x-scale is 0.4, the interpolated y-scale is 2.0, the x-origin is 0.25, and the y-origin is 0.80.

First, convert the normalized origin values to pixels. The width of the object is 100 pixels and the x-origin is given as 0.25, which results in an x-origin of 25 pixels from the left of the object. Since the object's left coordinate is 100, the x-coordinate of the origin is 125.

Similarly, the height of the object is 150 pixels and the y-origin is 0.80, which results in a y-origin of 120 pixels from the top of the object. Since the object's top coordinate is 150, the y-coordinate of the origin is 245.

To apply the scale transform, we first translate the object by the negative of the origin, moving it to (-25, -95, 75, 55). Next, we multiply the left and right coordinates by the x-scale and the top and bottom coordinates by the y-scale, which results in (-10, -190, 30, 110). Finally, we translate the object by the origin, which results in (115, 55, 155, 300).

The [InitialScaleX](scaleanimation_initialscalex.md) and [InitialScaleY](scaleanimation_initialscaley.md) properties are guaranteed to be either both set or both not set. If they are not set, then the current object scale should be used as the initial value of the animation.

The timing controls [Control1](scaleanimation_control1.md) and [Control2](scaleanimation_control2.md) specify the location of the first and second control points of a cubic Bézier curve. These two points have the same meaning as they do in the CSS **transition-timing-function** property. Control point zero is always (0,0) and control point three is always (1,1). The coordinates of [Control1](scaleanimation_control1.md) and [Control2](scaleanimation_control2.md) are always in the range 0 to 1, inclusive.

On the resulting Bézier curve, the x-coordinate represents time and the y-coordinate represents progress. The raw curve from (0,0) to (1,1) is scaled to match the actual duration and range of the animated transition, such that x=0 is the starting time of the transform, x=1 is the ending time, y=0 is the initial value of the animated property, and y=1 is the final value. Values of x and y between 0 and 1 represent corresponding intermediate values of time and the animation.

## -examples
To obtain an instance of the ScaleAnimation class, you first obtain the collection of [animations](animationdescription_animations.md) in the [animation description](animationdescription.md), and then walk that array of animations to find any that are of type [scale](propertyanimationtype.md). The following examples shows this process. The *effect* and *target* parameters are assumed to have been previously assigned.

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
