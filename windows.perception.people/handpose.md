---
-api-id: T:Windows.Perception.People.HandPose
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class HandPose 
-->

# Windows.Perception.People.HandPose

## -description
Represents the poses of the user's hand joints in relation to their surroundings.

## -remarks
The coordinate system is right-handed, with +y up, +x to the right, and -z forward.

All joints except for tip joints are interior to the hand.  Finger joint poses represent the base of the named bone.  Joints are oriented with forward (-z) pointing towards the tip of each finger, up (+y) pointing out of the back of the hand or finger, and right (+x) pointing perpendicular to forward and up.

## -see-also
To render a hand visualization each frame that tracks the detected shape of the hand, see [HandMeshObserver](handmeshobserver.md).

## -examples

