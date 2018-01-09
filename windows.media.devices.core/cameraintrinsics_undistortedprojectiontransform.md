---
-api-id: P:Windows.Media.Devices.Core.CameraIntrinsics.UndistortedProjectionTransform
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Matrix4x4 UndistortedProjectionTransform { get; }
-->

# Windows.Media.Devices.Core.CameraIntrinsics.UndistortedProjectionTransform

## -description
Gets a matrix that transforms a 3D point to the video frame pixel coordinates without compensating for the distortion model of the camera. The result 2D point need further distortion compensation to actually map to the pixel in video frame.   This is useful when app choses to use GPU to do distortion compentation instead using "CameraIntrinsics.UndistortPoints" which applies distortion compensation on CPU.

## -property-value
Gets a matrix that transforms a 3D point to the video frame pixel coordinates without compensating for the distortion model of the camera.

## -remarks

## -examples

## -see-also
