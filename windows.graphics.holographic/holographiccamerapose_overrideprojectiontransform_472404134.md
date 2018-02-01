---
-api-id: M:Windows.Graphics.Holographic.HolographicCameraPose.OverrideProjectionTransform(Windows.Graphics.Holographic.HolographicStereoTransform)
-api-type: winrt method
---

<!-- Method syntax.
public void HolographicCameraPose.OverrideProjectionTransform(HolographicStereoTransform projectionTransform)
-->

# Windows.Graphics.Holographic.HolographicCameraPose.OverrideProjectionTransform

## -description
Notifies the compositor that the app is rendering with an alternate suboptimal projection transform this frame.

## -parameters
### -param projectionTransform
The alternate suboptimal projection transform.

## -remarks
**Warning:** Rendering a frame with any projection transform other than that frame's [ProjectionTransform](holographiccamerapose_projectiontransform.md) value will result in reduced visual quality.

However, if you must render a frame with an alternate projection transform, be sure to call this method and provide that transform.  Visual quality will be even worse if the compositor does not know the the actual transforms used for rendering.

## -see-also

## -examples

