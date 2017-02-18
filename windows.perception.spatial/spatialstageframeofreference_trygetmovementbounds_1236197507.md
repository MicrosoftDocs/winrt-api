---
-api-id: M:Windows.Perception.Spatial.SpatialStageFrameOfReference.TryGetMovementBounds(Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
---

<!-- Method syntax.
public Vector3[] SpatialStageFrameOfReference.TryGetMovementBounds(SpatialCoordinateSystem coordinateSystem)
-->

# Windows.Perception.Spatial.SpatialStageFrameOfReference.TryGetMovementBounds

## -description
Gets the boundary vertices of the open area defined by the user where they intend to move while using their headset.

## -parameters

### -param coordinateSystem
The coordinate system in which to express the boundary vertices.

## -returns
The boundary vertices.

## -remarks
This method will return null if the user has not defined movement bounds. (i.e. if [MovementRange](spatialstageframeofreference_movementrange.md) is NoMovement)

## -see-also

## -examples

