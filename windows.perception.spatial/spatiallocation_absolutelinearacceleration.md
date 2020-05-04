---
-api-id: P:Windows.Perception.Spatial.SpatialLocation.AbsoluteLinearAcceleration
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 AbsoluteLinearAcceleration { get; }
-->

# Windows.Perception.Spatial.SpatialLocation.AbsoluteLinearAcceleration

## -description
Gets the absolute acceleration vector of the device in units of meters per second squared. This acceleration is expressed in the supplied coordinate system, although the motion is measured relative to the user's surroundings.

## -property-value
The acceleration.

## -remarks
<div class="alert"><b>Important</b>
  <p class="note">The acceleration values reported by this API are inverted; to get the actual acceleration, negate all three components. Velocity values are reported correctly and do not need to be negated.
</div>

## -examples

## -see-also
