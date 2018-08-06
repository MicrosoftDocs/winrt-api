---
-api-id: P:Windows.Graphics.Holographic.HolographicCamera.RenderTargetSize
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Size RenderTargetSize { get; }
-->

# Windows.Graphics.Holographic.HolographicCamera.RenderTargetSize

## -description
Gets the dimensions in pixels of the back buffers allocated for this camera.

## -property-value
The size.

## -remarks
Each frame, your application may set [ViewportScaleFactor](holographiccamera_viewportscalefactor.md) to decide how much of the back buffer to use for rendering.  The system will scale the rendered image to fill the display.

## -examples

## -see-also
