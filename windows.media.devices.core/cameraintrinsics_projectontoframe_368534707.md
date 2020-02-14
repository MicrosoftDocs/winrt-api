---
-api-id: M:Windows.Media.Devices.Core.CameraIntrinsics.ProjectOntoFrame(Windows.Foundation.Numerics.Vector3)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Point ProjectOntoFrame(Windows.Foundation.Numerics.Vector3 coordinate)
-->

# Windows.Media.Devices.Core.CameraIntrinsics.ProjectOntoFrame

## -description
Projects a camera space point into screen space pixel coordinates.

## -parameters
### -param coordinate
The camera space point to project into screen space.

## -returns
The screen space pixel coordinates.

## -remarks
The 3D coordinate must be expressed in meters, using a left-handed coordinate system, with +X pointing right, +Y pointing up, and +Z pointing forward out from the camera through the center (principal point) of the image. The resulting 2D coordinate will be expressed in pixels, with the origin in the top-left corner of the image; that is, +X pointing right, and +Y pointing down.

## -examples

## -see-also
