---
-api-id: M:Windows.Media.Devices.Core.CameraIntrinsics.UnprojectPixelsAtUnitDepth(Windows.Foundation.Point[],Windows.Foundation.Numerics.Vector2[])
-api-type: winrt method
---

<!-- Method syntax
public void UnprojectPixelsAtUnitDepth(Windows.Foundation.Point[] pixelCoordinates, Windows.Foundation.Numerics.Vector2[] results)
-->

# Windows.Media.Devices.Core.CameraIntrinsics.UnprojectPixelsAtUnitDepth

## -description
Unprojects an array of pixel coordinates into an array of camera space rays from the camera origin, expressed as a X, Y coordinates on a plane one meter from the camera.

## -parameters
### -param pixelCoordinates
The array of pixel coordinates to unproject into camera space.

### -param results
The array of X, Y coordinates of the unprojected pixels on a plane one meter from the camera.

## -remarks
The image coordinates must be expressed in pixels, with the origin in the top-left corner of the image; that is, +X pointing right, and +Y pointing down. The unprojected coordinates will be expressed in meters, with +X pointing right, and +Y pointing up,on a plane located at the center (principal point) of the image, one meter away from the camera.

## -examples

## -see-also
