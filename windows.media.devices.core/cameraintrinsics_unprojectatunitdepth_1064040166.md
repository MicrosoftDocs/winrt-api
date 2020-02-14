---
-api-id: M:Windows.Media.Devices.Core.CameraIntrinsics.UnprojectAtUnitDepth(Windows.Foundation.Point)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Numerics.Vector2 UnprojectAtUnitDepth(Windows.Foundation.Point pixelCoordinate)
-->

# Windows.Media.Devices.Core.CameraIntrinsics.UnprojectAtUnitDepth

## -description
Unprojects pixel coordinates into a camera space ray from the camera origin, expressed as a X, Y coordinates on a plane one meter from the camera.

## -parameters
### -param pixelCoordinate
The pixel coordinates to unproject into camera space.

## -returns
The X, Y coordinates of the unprojected pixel on a plane one meter from the camera.

## -remarks
The image coordinate must be expressed in pixels, with the origin in the top-left corner of the image; that is, +X pointing right, and +Y pointing down. The unprojected coordinate will be expressed in meters, with +X pointing right, and +Y pointing up, on a plane located at the center (principal point) of the image, one meter away from the camera.

## -examples

## -see-also
