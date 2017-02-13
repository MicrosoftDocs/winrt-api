---
-api-id: M:Windows.Devices.Perception.PerceptionDepthCorrelatedCameraIntrinsics.UnprojectPixelAtCorrelatedDepth(Windows.Foundation.Point,Windows.Devices.Perception.PerceptionDepthFrame)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Numerics.Vector3 UnprojectPixelAtCorrelatedDepth(Windows.Foundation.Point pixelCoordinate, Windows.Devices.Perception.PerceptionDepthFrame depthFrame)
-->

# Windows.Devices.Perception.PerceptionDepthCorrelatedCameraIntrinsics.UnprojectPixelAtCorrelatedDepth

## -description
Unprojects a point in camera image space out into the coordinate frame of the camera device, using the corresponding depth from a correlated depth camera.

## -parameters
### -param pixelCoordinate
A point, relative to the camera frame.

### -param depthFrame
The depth frame containing the depth value to use when projecting the point into camera space. The pixelCoordinate will be mapped from camera image space to depth image space, and then used to look up the depth in depthFrame.

## -returns
An unprojected coordinate, relative to the coordinate system of the camera device. The coordinate is located in front of the camera, at the depth of the corresponding pixel in depthFrame.

## -remarks

## -examples

## -see-also
