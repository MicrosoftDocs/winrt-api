---
-api-id: M:Windows.Devices.Perception.PerceptionDepthCorrelatedCameraIntrinsics.UnprojectPixelsAtCorrelatedDepth(Windows.Foundation.Point[],Windows.Devices.Perception.PerceptionDepthFrame,Windows.Foundation.Numerics.Vector3[])
-api-type: winrt method
---

<!-- Method syntax
public void UnprojectPixelsAtCorrelatedDepth(Windows.Foundation.Point[] sourceCoordinates, Windows.Devices.Perception.PerceptionDepthFrame depthFrame, Windows.Foundation.Numerics.Vector3[] results)
-->

# Windows.Devices.Perception.PerceptionDepthCorrelatedCameraIntrinsics.UnprojectPixelsAtCorrelatedDepth

## -description
Unprojects a set of points in camera image space out into the coordinate frame of the camera device, using the corresponding depth values from a correlated depth camera.

## -parameters
### -param sourceCoordinates
A set of points, relative to the camera frame.

### -param depthFrame
The depth frame containing the depth value to use when projecting the points into camera space. The pixelCoordinate will be mapped from camera image space to depth image space, and then used to look up the depth in depthFrame.

### -param results
A set of coordinates, relative to the coordinate system of the camera device and with correlated depth values.

## -remarks

## -examples

## -see-also
