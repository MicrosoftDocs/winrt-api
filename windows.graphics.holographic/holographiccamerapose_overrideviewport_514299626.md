---
-api-id: M:Windows.Graphics.Holographic.HolographicCameraPose.OverrideViewport(Windows.Foundation.Rect,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax.
public void HolographicCameraPose.OverrideViewport(Rect leftViewport, Rect rightViewport)
-->

# Windows.Graphics.Holographic.HolographicCameraPose.OverrideViewport

## -description
Specifies an alternate viewport rectangle within the frame buffer that the app is rendering into this frame.

## -parameters
### -param leftViewport
The left eye viewport rectangle.

### -param rightViewport
The right eye viewport rectangle.

## -remarks
It is an error to call OverrideViewport on devices where [CanOverrideViewport](holographiccamera_canoverrideviewport.md) returns false, such as HoloLens.

## -see-also

## -examples

