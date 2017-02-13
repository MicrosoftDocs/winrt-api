---
-api-id: M:Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper.UnprojectPoints(Windows.Foundation.Point[],Windows.Perception.Spatial.SpatialCoordinateSystem,Windows.Foundation.Numerics.Vector3[])
-api-type: winrt method
---

<!-- Method syntax
public void UnprojectPoints(Windows.Foundation.Point[] sourcePoints, Windows.Perception.Spatial.SpatialCoordinateSystem targetCoordinateSystem, Windows.Foundation.Numerics.Vector3[] results)
-->

# Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper.UnprojectPoints

## -description
Unprojects an array of 2D points from a [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) to a point in 3D space, using depth information from the [DepthMediaFrame](../windows.media.capture.frames/depthmediaframe.md) from which the coordinate mapper was created with a call to [TryCreateCoordinateMapper](../windows.media.capture.frames/depthmediaframe_trycreatecoordinatemapper.md).

## -parameters
### -param sourcePoints
The array of 2D source points within the [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) to map.

### -param targetCoordinateSystem
The coordinate system to which the points are unprojected.

### -param results
An array of points in 3D space.

## -remarks

## -examples

## -see-also
