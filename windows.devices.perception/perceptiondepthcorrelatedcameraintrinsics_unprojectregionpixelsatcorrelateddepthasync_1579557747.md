---
-api-id: M:Windows.Devices.Perception.PerceptionDepthCorrelatedCameraIntrinsics.UnprojectRegionPixelsAtCorrelatedDepthAsync(Windows.Foundation.Rect,Windows.Devices.Perception.PerceptionDepthFrame,Windows.Foundation.Numerics.Vector3[])
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction UnprojectRegionPixelsAtCorrelatedDepthAsync(Windows.Foundation.Rect region, Windows.Devices.Perception.PerceptionDepthFrame depthFrame, Windows.Foundation.Numerics.Vector3[] results)
-->

# Windows.Devices.Perception.PerceptionDepthCorrelatedCameraIntrinsics.UnprojectRegionPixelsAtCorrelatedDepthAsync

## -description
Unprojects a region of pixels in an image from camera image space out into the coordinate frame of the camera device, using the corresponding depth values from a correlated depth camera.

## -parameters
### -param region
The region of pixels to project from camera image space out into the coordinate frame of the camera device.

### -param depthFrame
The depth frame containing the depth value to use when projecting the points into camera space. The pixelCoordinates will be mapped from camera image space to depth image space, and then used to look up the depth in depthFrame.

### -param results
A set of coordinates, relative to the coordinate system of the camera device and with correlated depth values.

## -returns
This method returns asynchronously.

## -remarks

## -examples

## -see-also
