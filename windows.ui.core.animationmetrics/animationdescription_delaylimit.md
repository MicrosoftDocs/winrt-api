---
-api-id: P:Windows.UI.Core.AnimationMetrics.AnimationDescription.DelayLimit
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan DelayLimit { get; }
-->

# Windows.UI.Core.AnimationMetrics.AnimationDescription.DelayLimit

## -description
Gets the maximum cumulative delay time for the animation to be applied to the collection of objects in a target.

## -property-value
The delay limit time, expressed in 100-nanosecond units.

## -remarks
If a staggered set of animations is being applied to a set of objects, and the relative timing of the animations results in an animation that is set to occur after the DelayLimit time, the animation occurs at the DelayLimit time instead. For instance, if an object was set to animate at time t=231 ms when the DelayLimit was set to 200 ms, that animation would occur at 200 ms.

## -examples

## -see-also
[Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics)
