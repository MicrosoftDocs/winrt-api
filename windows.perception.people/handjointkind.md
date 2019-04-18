---
-api-id: T:Windows.Perception.People.HandJointKind
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum HandJointKind : int 
-->

# Windows.Perception.People.HandJointKind

## -description
Specifies a joint within the user's hand.

## -enum-fields
### -field Palm:0
The center of the palm.

Coincides with the grip position represented by this hand's [SpatialInteractionSourceLocation](../windows.ui.input.spatial/spatialinteractionsourcelocation.md), reoriented to align with the forward direction of the other joints.

### -field Wrist:1
The center of the wrist.

### -field ThumbMetacarpal:2
The joint in the base of the hand that poses the thumb's metacarpal bone.

### -field ThumbProximal:3
The first knuckle that poses the thumb's proximal phalanx.

### -field ThumbDistal:4
The second knuckle that poses the thumb's distal phalanx.

### -field ThumbTip:5
The point on the surface of the thumb at the tip.

### -field IndexMetacarpal:6
The joint in the base of the hand that poses the index finger's metacarpal bone.

### -field IndexProximal:7
The first knuckle that poses the index finger's proximal phalanx.

### -field IndexIntermediate:8
The second knuckle that poses the index finger's intermediate phalanx.

### -field IndexDistal:9
The third knuckle that poses the index finger's distal phalanx.

### -field IndexTip:10
The point on the surface of the index finger at the tip.

### -field MiddleMetacarpal:11
The joint in the base of the hand that poses the middle finger's metacarpal bone.

### -field MiddleProximal:12
The first knuckle that poses the middle finger's proximal phalanx.

### -field MiddleIntermediate:13
The second knuckle that poses the middle finger's intermediate phalanx.

### -field MiddleDistal:14
The third knuckle that poses the middle finger's distal phalanx.

### -field MiddleTip:15
The point on the surface of the middle finger at the tip.

### -field RingMetacarpal:16
The joint in the base of hand that poses the ring finger's metacarpal bone.

### -field RingProximal:17
The first knuckle that poses the ring finger's proximal phalanx.

### -field RingIntermediate:18
The second knuckle that poses the ring finger's intermediate phalanx.

### -field RingDistal:19
The third knuckle that poses the ring finger's distal phalanx.

### -field RingTip:20
The point on the surface of the ring finger at the tip.

### -field LittleMetacarpal:21
The joint in the base of hand that poses the little finger's (pinky's) metacarpal bone.

### -field LittleProximal:22
The first knuckle that poses the little finger's (pinky's) proximal phalanx.

### -field LittleIntermediate:23
The second knuckle that poses the little finger's (pinky's) intermediate phalanx.

### -field LittleDistal:24
The third knuckle that poses the little finger's (pinky's) distal phalanx.

### -field LittleTip:25
The point on the surface of the little finger's (pinky's) at the tip.

## -remarks
All joints except for tip joints are interior to the hand.  Finger joint poses represent the base of the named bone.  Joints are oriented with forward (-z) pointing towards the tip of each finger, up (+y) pointing out of the back of the hand or finger, and right (+x) pointing perpendicular to forward and up.

## -see-also

## -examples

