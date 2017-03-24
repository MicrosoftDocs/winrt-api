---
-api-id: M:Windows.Graphics.Holographic.HolographicCameraPose.TryGetCullingFrustum(Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IReference<Windows.Perception.Spatial.SpatialBoundingFrustum> TryGetCullingFrustum(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
-->

# Windows.Graphics.Holographic.HolographicCameraPose.TryGetCullingFrustum

## -description
Gets the predicted conservative culling frustum for this camera pose, expressed in the specified coordinate system.

## -parameters
### -param coordinateSystem
The coordinate system in which to express the culling frustum.

## -returns
The culling frustum.

## -remarks
This frustum is wider than the displays to account for uncertainty in the camera's pose prediction. As you get closer to the target frame time, this uncertainty reduces and the culling frustum gets smaller in size. This method will return null if the specified coordinate system cannot be located at the moment.

## -examples

## -see-also
