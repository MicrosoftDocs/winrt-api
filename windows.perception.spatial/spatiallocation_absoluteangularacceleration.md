---
-api-id: P:Windows.Perception.Spatial.SpatialLocation.AbsoluteAngularAcceleration
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Numerics.Quaternion AbsoluteAngularAcceleration { get; }
-->

# Windows.Perception.Spatial.SpatialLocation.AbsoluteAngularAcceleration

## -description
Gets the absolute angular acceleration of the device. This acceleration is expressed in the supplied coordinate system, although the motion is measured relative to the user's surroundings.

## -property-value
The angular acceleration.

## -remarks
The acceleration is clamped to be less than 180 degrees in any direction.

## -examples

## -see-also
