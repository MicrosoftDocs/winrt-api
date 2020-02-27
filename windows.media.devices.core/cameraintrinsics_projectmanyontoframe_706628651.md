---
-api-id: M:Windows.Media.Devices.Core.CameraIntrinsics.ProjectManyOntoFrame(Windows.Foundation.Numerics.Vector3[],Windows.Foundation.Point[])
-api-type: winrt method
---

<!-- Method syntax
public void ProjectManyOntoFrame(Windows.Foundation.Numerics.Vector3[] coordinates, Windows.Foundation.Point[] results)
-->

# Windows.Media.Devices.Core.CameraIntrinsics.ProjectManyOntoFrame

## -description
Projects an array of camera space points into screen space pixel coordinates.

## -parameters
### -param coordinates
The array of camera space points to project into screen space.

### -param results
The array of screen space pixel coordinates.

## -remarks
The 3D coordinates must be expressed in meters, using a left-handed coordinate system, with +X pointing right, +Y pointing up, and +Z pointing forward out from the camera through the center (principal point) of the image. The resulting 2D coordinates will be expressed in pixels, with the origin in the top-left corner of the image; that is, +X pointing right, and +Y pointing down.

## -examples

## -see-also
