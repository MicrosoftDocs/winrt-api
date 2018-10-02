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
Gets the absolute angular acceleration of the device in a clamped quaternion representation of the rotation per second squared. This acceleration is expressed in the supplied coordinate system, although the motion is measured relative to the user's surroundings.

## -property-value
The angular acceleration as a clamped quaternion.

## -remarks
> [!IMPORTANT]
> The acceleration is clamped to be less than 180 degrees per second squared in any direction.  You should generally use [AbsoluteAngularAccelerationAxisAngle](spatiallocation_absoluteangularaccelerationaxisangle.md) instead.

## -examples

## -see-also
