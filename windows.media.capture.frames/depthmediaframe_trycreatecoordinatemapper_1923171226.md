---
-api-id: M:Windows.Media.Capture.Frames.DepthMediaFrame.TryCreateCoordinateMapper(Windows.Media.Devices.Core.CameraIntrinsics,Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper TryCreateCoordinateMapper(Windows.Media.Devices.Core.CameraIntrinsics cameraIntrinsics, Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
-->

# Windows.Media.Capture.Frames.DepthMediaFrame.TryCreateCoordinateMapper

## -description
Attempts to create a [DepthCorrelatedCoordinateMapper](../windows.media.devices.core/depthcorrelatedcoordinatemapper.md) for the [DepthMediaFrame](depthmediaframe.md). This object provides methods for mapping pixel coordinates from a [MediaFrameSource](mediaframesource.md) camera to the coordinate system of a different **MediaFrameSource** or to 3D space.

## -parameters
### -param cameraIntrinsics
An object that describes the distortion model of the **MediaFrameSource** camera for which coordinates will be mapped using the [DepthMediaFrame](depthmediaframe.md) data.

### -param coordinateSystem
An object representing the spatial coordinate system of the camera for which coordinates will be mapped using the [DepthMediaFrame](depthmediaframe.md) data.

## -returns
A [DepthCorrelatedCoordinateMapper](../windows.media.devices.core/depthcorrelatedcoordinatemapper.md) if the operation was successful; otherwise, null.

## -remarks
The [DepthCorrelatedCoordinateMapper](../windows.media.devices.core/depthcorrelatedcoordinatemapper.md) returned by this method will use depth data from the [DepthMediaFrame](depthmediaframe.md) to map coordinates from one media frame or [MediaFrameSource](mediaframesource.md) to the coordinate system of another media frame or **MediaFrameSource**. The parameters to this method specify the camera intrinsics and coordinate system of the original coordinates to be mapped.

Get static camera intrinsics for a **MediaFrameSource** by calling [TryGetCameraIntrinsics](mediaframesource_trygetcameraintrinsics.md). Get the static coordinate system for a **MediaFrameSource** by accessing the [CoordinateSystem](mediaframesourceinfo_coordinatesystem.md) property of the [MediaFrameSourceInfo](mediaframesourceinfo.md) associated with the frame source. Get dynamic camera instrinsics by accessing [CameraIntrinsics](videomediaframe_cameraintrinsics.md) property of a [VideoMediaFrame](videomediaframe.md). Get the dynamic coordinate system from a [MediaFrameReference](mediaframereference.md) with the [CoordinateSystem](mediaframereference_coordinatesystem.md) property.

You specify the camera intrinsics and coordinate system of the target frame or frame source, to which the source points will be mapped, when you call the mapping methods of the **DepthCorrelatedCoordinateMapper**.

## -examples

## -see-also
