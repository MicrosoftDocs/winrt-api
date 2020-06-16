---
-api-id: P:Windows.UI.Core.AnimationMetrics.OpacityAnimation.InitialOpacity
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<float> InitialOpacity { get; }
-->

# Windows.UI.Core.AnimationMetrics.OpacityAnimation.InitialOpacity

## -description
Gets the object's initial opacity.

## -property-value
The initial opacity, if any. A value of 0.0 represents full transparency and a value of 1.0 represents full opacity.

## -remarks
This property's value might not be set when this method is called. In that case, the object's current opacity should be used as the starting point for the animation. If the value is not set and the object is hidden at the beginning of the animation, then the initial opacity is 0.0. If the value is not set and the object is visible at the beginning of the animation, then the object's current opacity should be used as the initial opacity.

## -examples

## -see-also
[FinalOpacity](opacityanimation_finalopacity.md), [Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics)
