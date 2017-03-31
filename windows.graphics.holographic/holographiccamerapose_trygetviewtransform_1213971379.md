---
-api-id: M:Windows.Graphics.Holographic.HolographicCameraPose.TryGetViewTransform(Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IReference<Windows.Graphics.Holographic.HolographicStereoTransform> TryGetViewTransform(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem)
-->

# Windows.Graphics.Holographic.HolographicCameraPose.TryGetViewTransform

## -description
Gets the stereo view transform for this camera pose, expressed as a transform from the specified coordinate system. This method will return null if the specified coordinate system cannot be located at the moment.

## -parameters
### -param coordinateSystem
The coordinate system from which the rendered geometry should be transformed.

## -returns
The transforms.

## -remarks
This method will return null if the specified coordinate system cannot be located at the moment.

## -examples

## -see-also
