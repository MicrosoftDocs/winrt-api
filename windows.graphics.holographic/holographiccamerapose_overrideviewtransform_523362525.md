---
-api-id: M:Windows.Graphics.Holographic.HolographicCameraPose.OverrideViewTransform(Windows.Perception.Spatial.SpatialCoordinateSystem,Windows.Graphics.Holographic.HolographicStereoTransform)
-api-type: winrt method
---

<!-- Method syntax.
public void HolographicCameraPose.OverrideViewTransform(SpatialCoordinateSystem coordinateSystem, HolographicStereoTransform coordinateSystemToViewTransform)
-->

# Windows.Graphics.Holographic.HolographicCameraPose.OverrideViewTransform

## -description
Notifies the compositor that the app is rendering with an alternate suboptimal view transform this frame.

## -parameters
### -param coordinateSystem
The coordinate system in which the alternate suboptimal view transform will be expressed.

### -param coordinateSystemToViewTransform
The alternate suboptimal view transform.

## -remarks
**Warning:** Rendering a frame with any view transform other than that frame's [TryGetViewTransform](holographiccamerapose_trygetviewtransform_1213971379.md) value will result in increased misprediction and thus reduced visual quality.  This quality reduction will be most pronounced if the alternate view transform's position component is changed.

However, if you must render a frame with an alternate view transform, be sure to call this method and provide that transform.  Visual quality will be even worse if the compositor does not know the actual transforms used for rendering.

## -see-also

## -examples

