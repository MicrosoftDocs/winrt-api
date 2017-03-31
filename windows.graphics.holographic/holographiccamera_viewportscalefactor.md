---
-api-id: P:Windows.Graphics.Holographic.HolographicCamera.ViewportScaleFactor
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public double ViewportScaleFactor { get;  set; }
-->

# Windows.Graphics.Holographic.HolographicCamera.ViewportScaleFactor

## -description
Gets or sets the scale factor to apply to the default viewport size.

## -property-value
The viewport scale factor.

## -remarks
Each frame, the system decides the size of the viewport within the render target that the app must render that frame. Sometimes the system may lower this to free up system resources, for example when video capture is occurring. Regardless of the viewport size, the rendered image is always scaled up to the full size of the displays. An app looking to lower its rendering cost for other reasons can request a smaller viewport.

You can specify a scale factor between 0.0 and 1.0, which is multiplied by the default viewport size. In future frames, the system will specify that you render to the nearest valid viewport size to this requested size.

## -examples

## -see-also
