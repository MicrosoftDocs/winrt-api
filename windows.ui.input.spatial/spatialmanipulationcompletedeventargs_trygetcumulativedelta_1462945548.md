---
-api-id: M:Windows.UI.Input.Spatial.SpatialManipulationCompletedEventArgs.TryGetCumulativeDelta(Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Input.Spatial.SpatialManipulationDelta TryGetCumulativeDelta(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
-->

# Windows.UI.Input.Spatial.SpatialManipulationCompletedEventArgs.TryGetCumulativeDelta

## -description
Get the relative motion of the hand since the start of the Manipulation gesture.

## -parameters
### -param coordinateSystem
The coordinate system in which to express the delta.

## -returns
The delta.

## -remarks
This method will return null if the specified coordinate system cannot be located at the moment.

## -examples

## -see-also
