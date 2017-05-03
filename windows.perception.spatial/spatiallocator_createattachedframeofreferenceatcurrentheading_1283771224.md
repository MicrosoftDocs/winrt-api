---
-api-id: M:Windows.Perception.Spatial.SpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading(Windows.Foundation.Numerics.Vector3,Windows.Foundation.Numerics.Quaternion,System.Double)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(Windows.Foundation.Numerics.Vector3 relativePosition, Windows.Foundation.Numerics.Quaternion relativeOrientation, System.Double relativeHeadingInRadians)
-->

# Windows.Perception.Spatial.SpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading

## -description
Creates a frame of reference that's positionally attached to this SpatialLocator with the supplied heading in radians relative to the current orientation and with its origin offset by the specified relative position and orientation.

## -parameters
### -param relativePosition
The positional offset of the origin of the frame of reference, expressed within its coordinate system.

### -param relativeOrientation
The rotation of the origin of the frame of reference, relative to the direction of the heading.

### -param relativeHeadingInRadians
The amount to rotate the fixed heading from the SpatialLocator's current orientation, in radians.

## -returns
The locator-attached frame of reference.

## -remarks

## -examples

## -see-also
[CreateAttachedFrameOfReferenceAtCurrentHeading](spatiallocator_createattachedframeofreferenceatcurrentheading_609311736.md), [CreateAttachedFrameOfReferenceAtCurrentHeading(Vector3)](spatiallocator_createattachedframeofreferenceatcurrentheading_1242639354.md), [CreateAttachedFrameOfReferenceAtCurrentHeading(Vector3, Quaternion)](spatiallocator_createattachedframeofreferenceatcurrentheading_2010331792.md)