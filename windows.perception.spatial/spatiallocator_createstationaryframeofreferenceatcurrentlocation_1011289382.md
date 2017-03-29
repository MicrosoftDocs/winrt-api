---
-api-id: M:Windows.Perception.Spatial.SpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocation(Windows.Foundation.Numerics.Vector3,Windows.Foundation.Numerics.Quaternion)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Perception.Spatial.SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(Windows.Foundation.Numerics.Vector3 relativePosition, Windows.Foundation.Numerics.Quaternion relativeOrientation)
-->

# Windows.Perception.Spatial.SpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocation

## -description
Creates a frame of reference that remains stationary relative to the user's surroundings, with its initial origin at the specified offset from the SpatialLocator's current location, and then rotated at the specified rotation.

## -parameters
### -param relativePosition
The positional offset of the origin of the frame of reference, expressed within its coordinate system.

### -param relativeOrientation
The rotation of the origin of the frame of reference, relative to the orientation of the SpatialLocator.

## -returns
The stationary frame of reference.

## -remarks

## -examples

## -see-also
[CreateStationaryFrameOfReferenceAtCurrentLocation](spatiallocator_createstationaryframeofreferenceatcurrentlocation_1875209282.md), [CreateStationaryFrameOfReferenceAtCurrentLocation(Vector3)](spatiallocator_createstationaryframeofreferenceatcurrentlocation_25500748.md), [CreateStationaryFrameOfReferenceAtCurrentLocation(Vector3, Quaternion, Double)](spatiallocator_createstationaryframeofreferenceatcurrentlocation_118553838.md)