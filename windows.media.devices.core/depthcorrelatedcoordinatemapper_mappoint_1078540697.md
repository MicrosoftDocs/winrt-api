---
-api-id: M:Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper.MapPoint(Windows.Foundation.Point,Windows.Perception.Spatial.SpatialCoordinateSystem,Windows.Media.Devices.Core.CameraIntrinsics)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Point MapPoint(Windows.Foundation.Point sourcePoint, Windows.Perception.Spatial.SpatialCoordinateSystem targetCoordinateSystem, Windows.Media.Devices.Core.CameraIntrinsics targetCameraIntrinsics)
-->

# Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper.MapPoint

## -description
Maps a point from one [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) to another, using depth information from the [DepthMediaFrame](../windows.media.capture.frames/depthmediaframe.md) from which the coordinate mapper was created with a call to [TryCreateCoordinateMapper](../windows.media.capture.frames/depthmediaframe_trycreatecoordinatemapper.md).

## -parameters
### -param sourcePoint
The source point to be mapped to the coordinate system of a different media frame source, which is specified in the *targetCoordinateSystem* parameter.

### -param targetCoordinateSystem
The coordinate system of the target media frame source to which the point is mapped.

### -param targetCameraIntrinsics
The camera intrinsics describing the projection and distortion models of the media frame source to which the point is mapped.

## -returns
A mapped point.

## -remarks

## -examples

## -see-also
