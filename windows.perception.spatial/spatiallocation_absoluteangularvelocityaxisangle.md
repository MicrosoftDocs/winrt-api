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
The value of the property is a vector which indicates the axis of rotation. The length of the vector indicates the rate of rotation counter-clockwise about the axis. For example, in a coordinate system where +Y points upward, turning to the right will produce an angular velocity axis-angle with a direction close to (0, 1, 0) and a magnitude proportional to the rate of rotation.

## -see-also

## -examples

