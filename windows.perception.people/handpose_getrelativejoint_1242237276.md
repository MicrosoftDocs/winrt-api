---
-api-id: M:Windows.Perception.People.HandPose.GetRelativeJoint(Windows.Perception.People.HandJointKind,Windows.Perception.People.HandJointKind)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public JointPose HandPose.GetRelativeJoint(HandJointKind joint, HandJointKind referenceJoint)
-->

# Windows.Perception.People.HandPose.GetRelativeJoint

## -description
Gets the pose of a hand joint, expressed relative to a reference joint.

## -parameters
### -param joint
The hand joint kind to locate.

### -param referenceJoint
The reference hand joint kind, relative to which the joint will be located.

## -returns
The relative pose of the joint.

## -remarks
The coordinate system is right-handed, with +y up, +x to the right, and -z forward.

All joints except for Tip joints are interior to the hand.  Finger joint poses represent the base of the named bone.  Joints are oriented with forward (-z) pointing towards the tip of each finger, up (+y) pointing out of the back of the hand or finger, and right (+x) pointing perpendicular to forward and up.

## -see-also

## -examples

