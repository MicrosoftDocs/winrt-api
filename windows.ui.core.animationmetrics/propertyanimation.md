---
-api-id: T:Windows.UI.Core.AnimationMetrics.PropertyAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class PropertyAnimation : Windows.UI.Core.AnimationMetrics.IPropertyAnimation
-->

# Windows.UI.Core.AnimationMetrics.PropertyAnimation

## -description
Provides methods that enable you to retrieve animation property values that are common to all [property animation types](propertyanimationtype.md).

## -remarks
Obtain instances of this object through the [AnimationDescription.animations](animationdescription_animations.md) property.

When a property animation is playing, that animation can be replaced by a different animation before the first animation is finished. The second animation can start from the same point at which the first animation leaves off. There is a slight delay between the time that the second animation is instructed to begin and when it does. In Windows 8, this can lead to a visible jump in the animation because the first animation has progressed slightly further during that delay. Starting in Windows 8.1, the starting point of the second animation is recalculated at the time it begins so no jump is seen.

The timing controls [Control1](propertyanimation_control1.md) and [Control2](propertyanimation_control2.md) specify the location of the first and second control points of a cubic Bézier curve. These two points have the same meaning as they do in the CSS **transition-timing-function** property. Control point zero is always (0,0) and control point three is always (1,1). The coordinates of [Control1](propertyanimation_control1.md) and [Control2](propertyanimation_control2.md) are always in the range 0 to 1, inclusive.

On the resulting Bézier curve, the x-coordinate represents time and the y-coordinate represents progress. The raw curve from (0,0) to (1,1) is scaled to match the actual duration and range of the animated transition, such that x=0 is the starting time of the transform, x=1 is the ending time, y=0 is the initial value of the animated property, and y=1 is the final value. Values of x and y between 0 and 1 represent corresponding intermediate values of time and the animation.

## -examples

## -see-also
[Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics)
