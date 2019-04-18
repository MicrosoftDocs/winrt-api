---
-api-id: T:Windows.Perception.People.JointPose
-api-type: winrt struct
ms.custom: 19H1
---

<!-- Structure syntax.
public struct JointPose  {
	public JointPoseAccuracy Accuracy 
	public Quaternion Orientation 
	public Vector3 Position 
	public float Radius 
}
-->

# Windows.Perception.People.JointPose

## -description
The pose of a hand joint.

## -struct-fields

### -field Orientation
The joint's orientation, with forward (-z) pointing towards the tip of each finger, up (+y) pointing out of the back of the hand or finger, and right (+x) pointing perpendicular to forward and up.

### -field Position
The joint's position.  All joints except for tip joints are interior to the hand.  Finger joint poses represent the base of the named bone.

### -field Radius
The distance from the joint position to the surface of the hand.

### -field Accuracy
The accuracy of this joint pose.

## -remarks
The coordinate system is right-handed, with +y up, +x to the right, and -z forward.

## -see-also

## -examples

