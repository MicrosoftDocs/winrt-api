---
-api-id: M:Windows.Graphics.Holographic.HolographicCameraPose.TryGetVisibleFrustum(Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IReference<Windows.Perception.Spatial.SpatialBoundingFrustum> TryGetVisibleFrustum(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
-->

# Windows.Graphics.Holographic.HolographicCameraPose.TryGetVisibleFrustum

## -description
Gets the predicted view frustum for the current pose, expressed in the specified coordinate system.

## -parameters
### -param coordinateSystem
The coordinate system in which to express the visible frustum.

## -returns
The visible frustum.

## -remarks
If this is a stereo display, this is the combined frustum of both stereo views, including the left and right view and projection matrices.

This frustum shares the same dimensions as the true view frustum at the time of rendering, although it may be off by some amount due to prediction error. Call TryGetCullingFrustum to get a conservative frustum that takes this uncertainty into account.

This method will return null if the specified coordinate system cannot be located at the moment.

## -examples

## -see-also
