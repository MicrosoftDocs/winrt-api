---
-api-id: M:Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper.MapPoints(Windows.Foundation.Point[],Windows.Perception.Spatial.SpatialCoordinateSystem,Windows.Media.Devices.Core.CameraIntrinsics,Windows.Foundation.Point[])
-api-type: winrt method
---

<!-- Method syntax
public void MapPoints(Windows.Foundation.Point[] sourcePoints, Windows.Perception.Spatial.SpatialCoordinateSystem targetCoordinateSystem, Windows.Media.Devices.Core.CameraIntrinsics targetCameraIntrinsics, Windows.Foundation.Point[] results)
-->

# Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper.MapPoints

## -description
Maps an array of points from one [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) to another, using depth information from the [DepthMediaFrame](../windows.media.capture.frames/depthmediaframe.md) from which the coordinate mapper was created with a call to [TryCreateCoordinateMapper](../windows.media.capture.frames/depthmediaframe_trycreatecoordinatemapper_1923171226.md).

## -parameters
### -param sourcePoints
An array of source points to be mapped to the coordinate system of a different media frame source, which is specified in the *targetCoordinateSystem* parameter.

### -param targetCoordinateSystem
The coordinate system of the target media frame source to which the points are mapped.

### -param targetCameraIntrinsics
The camera intrinsics describing the projection and distortion models of the media frame source to which the points are mapped.

### -param results
An array mapped points.

## -remarks

## -examples

## -see-also
