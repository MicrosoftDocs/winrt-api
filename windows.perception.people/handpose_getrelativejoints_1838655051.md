---
-api-id: M:Windows.Perception.People.HandPose.GetRelativeJoints(Windows.Perception.People.HandJointKind[],Windows.Perception.People.HandJointKind[],Windows.Perception.People.JointPose[])
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void HandPose.GetRelativeJoints(HandJointKind[] joints, HandJointKind[] referenceJoints, JointPose[] jointPoses)
-->

# Windows.Perception.People.HandPose.GetRelativeJoints

## -description
Gets the pose of multiple hand joints, each expressed relative to its matching reference joint.

## -parameters
### -param joints
The array of hand joint kinds to locate.

### -param referenceJoints
The array of reference hand joint kinds, relative to which each matching joint in the *joints* array will be located.

### -param jointPoses
The array of relative poses to fill, one for each matching element in the *joints* and *referenceJoints* arrays.

## -remarks
The coordinate system is right-handed, with +y up, +x to the right, and -z forward.

All joints except for tip joints are interior to the hand.  Finger joint poses represent the base of the named bone.  Joints are oriented with forward (-z) pointing towards the tip of each finger, up (+y) pointing out of the back of the hand or finger, and right (+x) pointing perpendicular to forward and up.

## -see-also

## -examples

