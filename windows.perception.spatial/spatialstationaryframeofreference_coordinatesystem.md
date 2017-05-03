---
-api-id: P:Windows.Perception.Spatial.SpatialStationaryFrameOfReference.CoordinateSystem
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Perception.Spatial.SpatialCoordinateSystem CoordinateSystem { get; }
-->

# Windows.Perception.Spatial.SpatialStationaryFrameOfReference.CoordinateSystem

## -description
Gets a stationary coordinate system with an origin at the position and orientation of the device at the time this frame was created.

## -property-value
The coordinate system.

## -remarks
The coordinate system is right-handed, with +y up, +x to the right, and -z forward.

Note that the origin is arbitrary. Coordinates are always most stable near the device rather than near this origin.

## -examples

## -see-also
