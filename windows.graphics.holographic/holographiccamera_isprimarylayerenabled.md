---
-api-id: P:Windows.Graphics.Holographic.HolographicCamera.IsPrimaryLayerEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsPrimaryLayerEnabled { get;  set; }
-->

# Windows.Graphics.Holographic.HolographicCamera.IsPrimaryLayerEnabled

## -description
Gets or sets whether this camera should display the primary back buffer filled by the app.

## -property-value
True, if the primary layer should be displayed; otherwise, false.

## -remarks
The primary layer displays the pixels that an app renders into the back buffer returned by [HolographicCameraRenderingParameters](holographiccamerarenderingparameters.md).  The primary layer appears behind any quad layers.  If an app only intends to render quad layers, for example during a loading screen, it may disable the primary layer.  When the primary layer is disabled, any pixels not covered by quad layers will remain black.

## -see-also

## -examples

