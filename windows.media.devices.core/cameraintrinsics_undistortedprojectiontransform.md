---
-api-id: P:Windows.Media.Devices.Core.CameraIntrinsics.UndistortedProjectionTransform
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Matrix4x4 UndistortedProjectionTransform { get; }
-->

# Windows.Media.Devices.Core.CameraIntrinsics.UndistortedProjectionTransform

## -description
Gets a matrix that transforms a 2D coordinate in meters on the image plane to video frame pixel coordinates without compensating for the distortion model of the camera. The 2D point resulting from this transformation will not accurately map to the pixel coordinate in a video frame unless the app applies its own distortion compensation.   This is useful for apps that choose to implement GPU-based distortion compensation instead of using [UndistortPoint](/uwp/api/windows.media.devices.core.cameraintrinsics#Windows_Media_Devices_Core_CameraIntrinsics_UndistortPoint_Windows_Foundation_Point_), which uses the CPU to compute the distortion compensation.

## -property-value
Gets a matrix that transforms a 2D coordinate in meters on the image plane to the video frame pixel coordinates without compensating for the distortion model of the camera.

## -remarks
The transform converts from a 2D coordinate in meters on the image plane (origin at the principal point, +X pointing to the right and +Y pointing up), to a 2D coordinate in pixels with the origin at the top-left corner of the image, and +X pointing to the right, and +Y pointing down. If the 2D coordinate is expressed as a vector with four components, Z must be set to 0 and W must set to 1.

To convert a 3D coordinate in the camera's coordinate system to pixel coordinates, the X and Y components of the coordinate must first be divided by the distance from the camera (i.e. the Z coordinate) to project them onto the image plane. Note that camera coordinate systems are right-handed by convention, with +X pointing right, +Y pointing up, and -Z pointing out from the camera through the center (principal point) of the image. In that convention, the Z coordinate must be negated when dividing into the X and Y components. For example:

```cppwinrt
using namespace winrt::Windows::Foundation::Numerics;
winrt::Windows::Foundation::Point ProjectCameraCoordinateToPixelCoordinate(
    const winrt::Windows::Media::Devices::Core::CameraIntrinsics& cameraIntrinsics,
    const float3& cameraCoordinate)
{
    const float2 imagePlaneCoordinate = float2{ cameraCoordinate.x / -cameraCoordinate.z, cameraCoordinate.y / -cameraCoordinate.z };
    float2 pixelCoordinate = transform(imagePlaneCoordinate, cameraIntrinsics.UndistortedProjectionTransform());
    return winrt::Windows::Foundation::Point{ pixelCoordinate.x, pixelCoordinate.y };
}
```

An equivalent result can be acheived using a vector with four components by setting the Z component to 1 and the W component to the distance from the camera. Note that the resulting X and Y components must be divided by the resulting W component to yield the final pixel coordinates:

```cppwinrt
using namespace winrt::Windows::Foundation::Numerics;
winrt::Windows::Foundation::Point ProjectCameraCoordinateToPixelCoordinate(
    const winrt::Windows::Media::Devices::Core::CameraIntrinsics& cameraIntrinsics,
    const float3& cameraCoordinate)
{
    float4 cameraCoordinateVector{ cameraCoordinate.x, cameraCoordinate.y, 1, -cameraCoordinate.z };
    float4 pixelCoordinate = transform(cameraCoordinateVector, cameraIntrinsics.UndistortedProjectionTransform());
    return winrt::Windows::Foundation::Point{ pixelCoordinate.x / pixelCoordinate.w, pixelCoordinate.y / pixelCoordinate.w };
}
```

If this transform will be applied to many 3D coordinates, it may be more convenient to adjust the matrix itself, rather than each input coordinate. This can be accomplished by swapping the third and fourth rows of the matrix, and using a homogeneous coordinate transform function like <a href="/windows/win32/api/directxmath/nf-directxmath-xmvector3transformcoordstream">XMVector3TransformCoordStream</a>. Note that a right-handed-to-left-handed conversion is also applied as part of the transform so that the distance from the camera is a positive value:

```cppwinrt
using namespace DirectX;
void ProjectCameraCoordinatesToPixelCoordinates(
    const winrt::Windows::Media::Devices::Core::CameraIntrinsics& cameraIntrinsics,
    const winrt::array_view<XMFLOAT3>& cameraCoordinates,
    winrt::array_view<winrt::Windows::Foundation::Point>& pixelCoordinates)
{
    XMMATRIX undistortedProjectionTransform = XMLoadFloat4x4(&cameraIntrinsics.UndistortedProjectionTransform());
    std::swap(undistortedProjectionTransform.r[2], undistortedProjectionTransform.r[3]);

    // convert right-handed coordinates (-Z forward) to right-handed coordinates (+Z forward) as part of the transform
    static const XMMATRIX rightToLeft = XMMatrixScaling(1, 1, -1);

    std::vector<XMFLOAT3> pixelCoordinateVectors(cameraCoordinates.size());
    XMVector3TransformCoordStream(
        pixelCoordinateVectors.data(), sizeof(pixelCoordinateVectors[0]),
        cameraCoordinates.data(), sizeof(cameraCoordinates[0]), cameraCoordinates.size(),
        rightToLeft * undistortedProjectionTransform);

    std::transform(pixelCoordinateVectors.begin(), pixelCoordinateVectors.end(), pixelCoordinates.begin(),
        [](const XMFLOAT3& v) { return winrt::Windows::Foundation::Point{ v.x, v.y }; });
}
```
  
## -examples

## -see-also