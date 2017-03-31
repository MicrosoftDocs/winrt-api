---
-api-id: T:Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SpatialLocatorAttachedFrameOfReference : Windows.Perception.Spatial.ISpatialLocatorAttachedFrameOfReference
-->

# Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference

## -description
Represents a frame of reference that is positionally attached to the device.

## -remarks
The SpatialLocatorAttachedFrameOfReference class represents a device-relative frame of reference that tracks changes in the position reported by the device's [SpatialLocator](spatiallocator.md). This frame has a fixed heading relative to the user's surroundings that points in the direction the user was facing when the frame was created. From then on, all orientations in this frame of reference are relative to that fixed heading, even as the user rotates the device.

For a headset such as HoloLens, the origin of this frame's coordinate system is located at the center of rotation of the user's head, so that its position is not affected by head rotation.

To get a SpatialLocatorAttachedFrameOfReference, use the [SpatialLocator](spatiallocator.md) class and call [CreateAttachedFrameOfReferenceAtCurrentHeading](spatiallocator_createattachedframeofreferenceatcurrentheading_609311736.md).

## -examples

## -see-also
