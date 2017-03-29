---
-api-id: M:Windows.UI.Input.Spatial.SpatialManipulationUpdatedEventArgs.TryGetCumulativeDelta(Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Input.Spatial.SpatialManipulationDelta TryGetCumulativeDelta(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
-->

# Windows.UI.Input.Spatial.SpatialManipulationUpdatedEventArgs.TryGetCumulativeDelta

## -description
Get the relative motion of the hand since the start of the Manipulation gesture.

## -parameters
### -param coordinateSystem
The coordinate system in which to express the delta.

## -returns
The delta.

## -remarks
This motion is expressed in the specified coordinate system. If you want the path followed by the manipulation to represent translation through the world as the user walks around, specify an anchored or stationary coordinate system. If you want the path to stay relative to the user and ignore the user's translation, specify a locator-attached coordinate system.

This method will return null if the specified coordinate system cannot be located at the moment.

## -examples

## -see-also
