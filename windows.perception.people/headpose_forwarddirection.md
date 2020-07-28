---
-api-id: P:Windows.Perception.People.HeadPose.ForwardDirection
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 ForwardDirection { get; }
-->

# Windows.Perception.People.HeadPose.ForwardDirection

## -description
Gets the forward direction of the user's head gaze in the specified coordinate system, as a unit vector.

## -property-value
The forward direction unit vector.

## -remarks
>[!NOTE] On most Windows Mixed Reality devices, the forward direction vector is parallel to the ground when the user's head is in a neutral position looking forward. However, earlier versions of HoloLens 2 aligned the vector to be perpendicular to the display panels instead, which is tilted downward a few degrees relative to the ideal orientation. Newer versions of HoloLens 2 have corrected this to ensure semantic consistency across form factors.

## -examples

## -see-also
