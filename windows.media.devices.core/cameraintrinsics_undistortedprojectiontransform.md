---
-api-id: P:Windows.Media.Devices.Core.CameraIntrinsics.UndistortedProjectionTransform
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Matrix4x4 UndistortedProjectionTransform { get; }
-->

# Windows.Media.Devices.Core.CameraIntrinsics.UndistortedProjectionTransform

## -description
Gets a matrix that transforms a 3D point to video frame pixel coordinates without compensating for the distortion model of the camera. The 2D point resulting from this transformation will not accurately map to the pixel coordinate in a video frame unless the app applies its own distortion compensation.   This is useful for apps that choose to implement GPU-based distortion compensation instead of using [UndistortPoint](https://docs.microsoft.com/uwp/api/windows.media.devices.core.cameraintrinsics#Windows_Media_Devices_Core_CameraIntrinsics_UndistortPoint_Windows_Foundation_Point_), which uses the CPU to compute the distortion compensation.

## -property-value
Gets a matrix that transforms a 3D point to the video frame pixel coordinates without compensating for the distortion model of the camera.

## -remarks

## -examples

## -see-also
