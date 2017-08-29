---
-api-id: M:Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.UpdateViewport(Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax.
public void HolographicQuadLayerUpdateParameters.UpdateViewport(Rect value)
-->

# Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.UpdateViewport

## -description
Updates the viewport rectangle within the quad layer's texture to display.

## -parameters
### -param value
The viewport rectangle.

## -remarks
By default, quad layers display the full contents of the texture buffer to fill the specified extents.  If the app fills the buffer with a texture atlas, it can then specify a viewport to fill the quad layer with jut a subset of the image.

For example, if the quad layer is used to display a reticle, the app can fill the texture buffer with one texture containing four reticle images.  The app can then change just the viewport rectangle to select among those four images.

## -see-also

## -examples

