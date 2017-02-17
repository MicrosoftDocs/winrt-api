---
-api-id: P:Windows.Graphics.Holographic.HolographicDisplay.MaxViewportSize
-api-type: winrt property
---

<!-- Property syntax.
public Size MaxViewportSize { get; }
-->

# Windows.Graphics.Holographic.HolographicDisplay.MaxViewportSize

## -description
Gets the maximum viewport size that an app will ever be asked to render to for this display.

## -property-value
The maximum viewport size.

## -remarks
An app can use this maximum size to pre-allocate secondary buffers for its own use during rendering.

Note that this maximum viewport size will exceed the physical resolution of the headset's screen for displays with lens distortion.

## -see-also

## -examples

