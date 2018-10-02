---
-api-id: M:Windows.Perception.Spatial.Preview.SpatialGraphInteropPreview.CreateCoordinateSystemForNode(System.Guid,Windows.Foundation.Numerics.Vector3,Windows.Foundation.Numerics.Quaternion)
-api-type: winrt method
---

<!-- Method syntax.
public SpatialCoordinateSystem SpatialGraphInteropPreview.CreateCoordinateSystemForNode(Guid nodeId, Vector3 relativePosition, Quaternion relativeOrientation)
-->

# Windows.Perception.Spatial.Preview.SpatialGraphInteropPreview.CreateCoordinateSystemForNode

## -description
Creates a spatial coordinate system that tracks adjustments to a static spatial node with its origin offset and rotated by the specified relative position and orientation.

## -parameters
### -param nodeId
The static spatial node's ID.

### -param relativePosition
The rigid positional offset from the spatial node origin to this coordinate system's origin, expressed within the coordinate system of the node origin.

### -param relativeOrientation
The rigid rotation from the spatial node origin to the coordinate system's origin, expressed within the coordinate system of the node origin.

## -returns
The spatial coordinate system.

## -remarks

## -see-also

## -examples

