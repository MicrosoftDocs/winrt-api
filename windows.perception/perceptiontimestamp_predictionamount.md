---
-api-id: P:Windows.Perception.PerceptionTimestamp.PredictionAmount
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan PredictionAmount { get; }
-->

# Windows.Perception.PerceptionTimestamp.PredictionAmount

## -description
For timestamps about the future, gets the span of time between when the prediction was made and TargetTime. When you get an improved prediction (for example, from a newer HolographicFramePrediction), TargetTime will stay the same and PredictionAmount will decrease.

For timestamps about the past, PredictionAmount is always 0, even if the data associated with this timestamp was interpolated between two readings.

## -property-value
The prediction duration.

## -remarks

## -examples

## -see-also
