---
-api-id: P:Windows.UI.Core.AnimationMetrics.IPropertyAnimation.Delay
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan Delay { get; }
-->

# Windows.UI.Core.AnimationMetrics.IPropertyAnimation.Delay

## -description
Gets the amount of time between when the animation is instructed to begin and when that animation actually begins to draw.

## -property-value
The amount of time to delay before starting an animation.

## -remarks
This delay is in addition to any [StaggerDelay](animationdescription_staggerdelay.md) applied to the parent [AnimationDescription](animationdescription.md). For instance, if a transition is scheduled through the application of [StaggerDelay](animationdescription_staggerdelay.md) and [StaggerDelayFactor](animationdescription_staggerdelayfactor.md) to begin at time t=200 ms and this delay is set to 250 ms, then the transition will actually begin to animate at 450 ms.

## -examples

## -see-also
[Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics)
