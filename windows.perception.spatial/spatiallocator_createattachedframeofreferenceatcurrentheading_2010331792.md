---
-api-id: M:Windows.Perception.Spatial.SpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading(Windows.Foundation.Numerics.Vector3,Windows.Foundation.Numerics.Quaternion)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(Windows.Foundation.Numerics.Vector3 relativePosition, Windows.Foundation.Numerics.Quaternion relativeOrientation)
-->

# Windows.Perception.Spatial.SpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading

## -description
Creates a frame of reference that's positionally attached to this SpatialLocator with the current orientation as its fixed heading and with its origin offset and rotated by the specified relative position and orientation.

## -parameters
### -param relativePosition
The positional offset of the origin of the frame of reference, expressed within its coordinate system.

### -param relativeOrientation
The rotation of the origin of the frame of reference, relative to the direction of the heading.

## -returns
The locator-attached frame of reference.

## -remarks

## -examples

## -see-also
[CreateAttachedFrameOfReferenceAtCurrentHeading](spatiallocator_createattachedframeofreferenceatcurrentheading_609311736.md), [CreateAttachedFrameOfReferenceAtCurrentHeading(Vector3)](spatiallocator_createattachedframeofreferenceatcurrentheading_1242639354.md), [CreateAttachedFrameOfReferenceAtCurrentHeading(Vector3, Quaternion, Double)](spatiallocator_createattachedframeofreferenceatcurrentheading_1283771224.md)