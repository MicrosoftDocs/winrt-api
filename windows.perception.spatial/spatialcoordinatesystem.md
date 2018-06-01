---
-api-id: T:Windows.Perception.Spatial.SpatialCoordinateSystem
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SpatialCoordinateSystem : Windows.Perception.Spatial.ISpatialCoordinateSystem
-->

# Windows.Perception.Spatial.SpatialCoordinateSystem

## -description

Represents a coordinate system used to reason about the user's surroundings.

## -remarks

Methods that return spatial information, represented as points, rays, or volumes in the user's surroundings, will accept a SpatialCoordinateSystem parameter to let you decide the coordinate system in which it's most useful for those coordinates to be returned. The units for these coordinates will always be in meters.

Each SpatialCoordinateSystem has a dynamic relationship with other coordinate systems, including those that represent the user's position. At any point in time, the device may be able to locate some coordinate systems and not others. For most coordinate systems, your app must be ready to handle periods of time during which they cannot be located.

To get a SpatialCoordinateSystem based on the position of the device, use the SpatialLocator class to create either a locator-attached or stationary frame of reference.

## -examples

## -see-also

[Camera stream coordinate mapper sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/CameraStreamCoordinateMapper), [Tag-along hologram sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HolographicTagAlong)