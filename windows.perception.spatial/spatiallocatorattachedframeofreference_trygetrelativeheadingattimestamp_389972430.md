---
-api-id: M:Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference.TryGetRelativeHeadingAtTimestamp(Windows.Perception.PerceptionTimestamp)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IReference<double> TryGetRelativeHeadingAtTimestamp(Windows.Perception.PerceptionTimestamp timestamp)
-->

# Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference.TryGetRelativeHeadingAtTimestamp

## -description
Computes the device's heading in radians for the specified timestamp, relative to this frame's fixed heading.

## -parameters
### -param timestamp
The timestamp to compute the relative heading for.

## -returns
The relative heading in radians that corresponds with the timestamp, or null if it is not available for the specified time.

## -remarks
This method will return null if the timestamp is too far in the past or future.

## -examples

## -see-also
