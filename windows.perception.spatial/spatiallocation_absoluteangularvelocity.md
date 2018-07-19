---
-api-id: P:Windows.Perception.Spatial.SpatialLocation.AbsoluteAngularVelocity
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Numerics.Quaternion AbsoluteAngularVelocity { get; }
-->

# Windows.Perception.Spatial.SpatialLocation.AbsoluteAngularVelocity

## -description
Gets the absolute angular velocity of the device in a clamped quaternion representation of the rotation per second. This velocity is expressed in the supplied coordinate system, although the motion is measured relative to the user's surroundings.

## -property-value
The angular velocity as a clamped quaternion.

## -remarks
> [!IMPORTANT]
> The velocity is clamped to be less than 180 degrees per second in any direction.  You should generally use [AbsoluteAngularVelocityAxisAngle](spatiallocation_absoluteangularvelocityaxisangle.md) instead.

## -examples

## -see-also
