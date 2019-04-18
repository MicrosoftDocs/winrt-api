---
-api-id: M:Windows.Perception.People.HandPose.TryGetJoint(Windows.Perception.Spatial.SpatialCoordinateSystem,Windows.Perception.People.HandJointKind,Windows.Perception.People.JointPose@)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public bool HandPose.TryGetJoint(SpatialCoordinateSystem coordinateSystem, HandJointKind joint, JointPose jointPose)
-->

# Windows.Perception.People.HandPose.TryGetJoint

## -description
Gets the pose of a hand joint, expressed in the specified coordinate system.

## -parameters
### -param coordinateSystem
The coordinate system in which to express the joint pose.

### -param joint
The hand joint kind to locate.

### -param jointPose
The pose to fill for the specified joint.

## -returns
True if the hand can be located within the specified coordinate system; otherwise, false.

## -remarks
The coordinate system is right-handed, with +y up, +x to the right, and -z forward.

All joints except for tip joints are interior to the hand.  Finger joint poses represent the base of the named bone.  Joints are oriented with forward (-z) pointing towards the tip of each finger, up (+y) pointing out of the back of the hand or finger, and right (+x) pointing perpendicular to forward and up.

This method will return false if the specified coordinate system cannot be located at the moment.

## -see-also

## -examples

