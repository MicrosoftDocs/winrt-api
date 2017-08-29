---
-api-id: M:Windows.Graphics.Holographic.HolographicQuadLayer.#ctor(Windows.Foundation.Size,Windows.Graphics.DirectX.DirectXPixelFormat)
-api-type: winrt method
---

<!-- Method syntax.
public HolographicQuadLayer.HolographicQuadLayer(Size size, DirectXPixelFormat pixelFormat)
-->

# Windows.Graphics.Holographic.HolographicQuadLayer.HolographicQuadLayer

## -description
Creates a new quad layer with a specified texture size and pixel format.

## -parameters
### -param size
The size in pixels of the texture that will back this quad layer.

### -param pixelFormat
The pixel format for the texture that will back this quad layer.

## -remarks
Note that the spatial location and extents of this new quad layer in world coordinates must also be specified by requesting a [HolographicQuadLayerUpdateParameters](holographicquadlayerupdateparameters.md) instance.

The pixel format specified must be an RGB format, such as DXGI_FORMAT_B8G8R8A8_UNORM.

## -see-also

## -examples

