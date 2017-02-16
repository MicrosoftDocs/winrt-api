---
-api-id: M:Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper.UnprojectPoint(Windows.Foundation.Point,Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Numerics.Vector3 UnprojectPoint(Windows.Foundation.Point sourcePoint, Windows.Perception.Spatial.SpatialCoordinateSystem targetCoordinateSystem)
-->

# Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper.UnprojectPoint

## -description
Unprojects a 2D point from a [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) to a point in 3D space, using depth information from the [DepthMediaFrame](../windows.media.capture.frames/depthmediaframe.md) from which the coordinate mapper was created with a call to [TryCreateCoordinateMapper](../windows.media.capture.frames/depthmediaframe_trycreatecoordinatemapper.md).

## -parameters
### -param sourcePoint
The 2D source point within the [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) to map.

### -param targetCoordinateSystem
The coordinate system to which the point is unprojected.

## -returns
An point in 3D space.

## -remarks

## -examples

## -see-also
