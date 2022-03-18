---
-api-id: P:Windows.UI.Core.AnimationMetrics.AnimationDescription.StaggerDelay
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan StaggerDelay { get; }
-->

# Windows.UI.Core.AnimationMetrics.AnimationDescription.StaggerDelay

## -description
Gets the amount of time between the application of the animation effect to each object in a target that contains multiple objects. The StaggerDelay, together with the StaggerDelayFactor and DelayLimit, is one of the three elements used to control the relative timing of the animation effects.

## -property-value
The stagger delay time, expressed in 100-nanosecond units.

## -remarks
Consider a target that consists of four objects— labeled A, B, C, and D— with a StaggerDelay of 100 ms. Object A animates at time t=0, object B at time t=100 ms, object C at time t=200 ms, and object D at time t=300 ms.

However, the StaggerDelay time between each object's animation can be changed by the values of the StaggerDelayFactor and DelayLimit. See those topics for a discussion of their effect on the relative animation timing.

Note that an animation can have its own inherent [delay](propertyanimation_delay.md) in addition to its StaggerDelay.

## -examples

## -see-also
[StaggerDelayFactor](animationdescription_staggerdelayfactor.md), [DelayLimit](animationdescription_delaylimit.md), [Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics)
