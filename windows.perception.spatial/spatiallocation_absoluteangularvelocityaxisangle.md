---
-api-id: P:Windows.Perception.Spatial.SpatialLocation.AbsoluteAngularVelocityAxisAngle
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public Vector3 AbsoluteAngularVelocityAxisAngle { get; }
-->

# Windows.Perception.Spatial.SpatialLocation.AbsoluteAngularVelocityAxisAngle

## -description
Gets the absolute angular velocity of the device in an axis-angle representation in units of radians per second. This velocity is expressed in the supplied coordinate system, although the motion is measured relative to the user's surroundings.

## -property-value
The angular velocity as an axis-angle.

## -remarks
The value of the property is a vector which indicates the axis of rotation. The magnitude of the vector indicates the rate of rotation clockwise about the axis, looking back along the vector towards the origin - that is, according to the left-hand rule. For example, in a coordinate system where +Y points upward, turning to the right will produce an axis-angle with a direction close to (0, 1, 0) and a magnitude proportional to the rate of rotation. Note that this is the opposite convention from the angular acceleration axis angle, which uses the right-hand rule. You can change the convention of either vector to make the values consistent by negating all three components.

## -see-also

## -examples

