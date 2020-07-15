---
-api-id: T:Windows.UI.Core.AnimationMetrics.IPropertyAnimation
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IPropertyAnimation : 
-->

# Windows.UI.Core.AnimationMetrics.IPropertyAnimation

## -description
Describes properties of animations that are common to all animation effects.

## -remarks
Do not implement this interface. Obtain a pointer to an instance of this interface by using the [AnimationDescription.Animations](animationdescription_animations.md) property.

The timing controls [Control1](ipropertyanimation_control1.md) and [Control2](ipropertyanimation_control2.md) specify the location of the first and second control points of a cubic Bézier curve. These two points have the same meaning as they do in the CSS **transition-timing-function** property. Control point zero is always (0,0) and control point three is always (1,1). The coordinates of [Control1](ipropertyanimation_control1.md) and [Control2](ipropertyanimation_control2.md) are always in the range 0 to 1, inclusive.

On the resulting Bézier curve, the x-coordinate represents time and the y-coordinate represents progress. The raw curve from (0,0) to (1,1) is scaled to match the actual duration and range of the animated transition, such that x=0 is the starting time of the transform, x=1 is the ending time, y=0 is the initial value of the animated property, and y=1 is the final value. Values of x and y between 0 and 1 represent corresponding intermediate values of time and the animation.

## -examples

## -see-also
[Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics)
