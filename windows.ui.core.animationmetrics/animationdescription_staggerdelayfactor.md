---
-api-id: P:Windows.UI.Core.AnimationMetrics.AnimationDescription.StaggerDelayFactor
-api-type: winrt property
---

<!-- Property syntax
public float StaggerDelayFactor { get; }
-->

# Windows.UI.Core.AnimationMetrics.AnimationDescription.StaggerDelayFactor

## -description
Gets a multiplier that is applied to each occurrence of the stagger delay, increasing or decreasing the previous delay instance by that amount.

## -property-value
The factor to apply to the stagger delay.

## -remarks
The StaggerDelayFactor is a multiplier applied to the last value of the StaggerDelay. Consider a target that consists of four objects— labeled A, B, C, and D— with an initial StaggerDelay of 100 ms and a StaggerDelayFactor of 0.75. This means that the delay between subsequent objects is reduced to 75% of the previous delay. Under these conditions, object A animates at time t=0 and object B at time t=100 ms. The StaggerDelayFactor then reduces the delay for object C to 100 ms * 0.75 = 75 ms, so object C animates at time t=175 ms. The StaggerDelayFactor then reduces the delay for object D to 75 ms * 0.75 = 56 ms, so object D animates at time t=231 ms.

However, there is one more element that can affect these values— the [DelayLimit](animationdescription_delaylimit.md). See that topic for a discussion of its effect on the relative animation timing.

## -examples

## -see-also
[Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics)
