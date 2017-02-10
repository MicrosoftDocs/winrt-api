---
-api-id: M:Windows.Devices.Perception.PerceptionDepthCorrelatedCameraIntrinsics.UnprojectAllPixelsAtCorrelatedDepthAsync(Windows.Devices.Perception.PerceptionDepthFrame,Windows.Foundation.Numerics.Vector3[])
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction UnprojectAllPixelsAtCorrelatedDepthAsync(Windows.Devices.Perception.PerceptionDepthFrame depthFrame, Windows.Foundation.Numerics.Vector3[] results)
-->

# Windows.Devices.Perception.PerceptionDepthCorrelatedCameraIntrinsics.UnprojectAllPixelsAtCorrelatedDepthAsync

## -description
Unprojects all pixels in an image from camera image space out into the coordinate frame of the camera device, using the corresponding depth values from a correlated depth camera.

## -parameters
### -param depthFrame
The depth frame containing the depth value to use when projecting the points into camera space. The coordinates of each pixel in the image will be mapped from camera image space to depth image space, and then used to look up the depth in this depth frame.

### -param results
Returns a set of coordinates, relative to the coordinate system of the camera device and with correlated depth values.

## -returns
This method returns asynchronously.

## -remarks

## -examples

## -see-also
