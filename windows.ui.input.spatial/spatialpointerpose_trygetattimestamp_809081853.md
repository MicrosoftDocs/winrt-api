---
-api-id: M:Windows.UI.Input.Spatial.SpatialPointerPose.TryGetAtTimestamp(Windows.Perception.Spatial.SpatialCoordinateSystem,Windows.Perception.PerceptionTimestamp)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Input.Spatial.SpatialPointerPose TryGetAtTimestamp(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem, Windows.Perception.PerceptionTimestamp timestamp)
-->

# Windows.UI.Input.Spatial.SpatialPointerPose.TryGetAtTimestamp

## -description
Gets the head gaze and motion controller pointer poses for the specified timestamp.

## -parameters
### -param coordinateSystem
The coordinate system in which to express the pointer poses.

### -param timestamp
The timestamp, past or future.

## -returns
The pointer poses.

## -remarks
This will either be a timestamp from the past (when correlating with input events) or a timestamp from the future (when rendering a cursor along the user's predicted gaze for a HolographicFramePrediction).

This method will return null if the specified coordinate system cannot be located at the moment.

## -examples

## -see-also
