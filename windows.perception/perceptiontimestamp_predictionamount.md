---
-api-id: P:Windows.Perception.PerceptionTimestamp.PredictionAmount
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.TimeSpan PredictionAmount { get; }
-->

# Windows.Perception.PerceptionTimestamp.PredictionAmount

## -description
For timestamps about the future, gets the span of time between when the prediction was made and [TargetTime](perceptiontimestamp_targettime.md).

## -property-value
The prediction duration.

## -remarks
When you get an improved prediction (for example, from a newer [HolographicFramePrediction](../windows.graphics.holographic/holographicframeprediction.md), TargetTime will stay the same and PredictionAmount will decrease.

For timestamps about the past, PredictionAmount is always 0, even if the data associated with this timestamp was interpolated between two readings.

## -examples

## -see-also
