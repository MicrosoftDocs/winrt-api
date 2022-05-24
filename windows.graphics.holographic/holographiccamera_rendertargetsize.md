---
-api-id: P:Windows.Graphics.Holographic.HolographicCamera.RenderTargetSize
-api-type: winrt property
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Property syntax
public Windows.Foundation.Size RenderTargetSize { get; }
-->

# Windows.Graphics.Holographic.HolographicCamera.RenderTargetSize

## -description
Gets the dimensions in pixels of the back buffers allocated for this camera.

## -property-value
The width and height of the [HolographicCamera](holographiccamera.md) render target.

## -remarks
Each frame, your application may set [ViewportScaleFactor](holographiccamera_viewportscalefactor.md) to decide how much of the back buffer to use for rendering.  The system will scale the rendered image to fill the display.

To change the render target size for a [HolographicCamera](holographiccamera.md), retrieve its [ViewConfiguration](holographiccamera_viewconfiguration.md) property and use it to call [RequestRenderTargetSize](holographicviewconfiguration_requestrendertargetsize_54701265.md).

## -examples

## -see-also
[HolographicViewConfiguration.RenderTargetSize](holographicviewconfiguration_rendertargetsize.md)
