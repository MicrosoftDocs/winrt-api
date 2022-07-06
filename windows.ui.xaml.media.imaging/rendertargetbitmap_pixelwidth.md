---
-api-id: P:Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap.PixelWidth
-api-type: winrt property
---

<!-- Property syntax
public int PixelWidth { get; }
-->

# Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap.PixelWidth

## -description
Gets the width of the rendered bitmap in pixels.



## -property-value
The width of the rendered bitmap in pixels.

## -remarks
Don't rely on this value prior to [RenderAsync](rendertargetbitmap_renderasync_1804035726.md) being called.

The maximum rendered size of a XAML visual tree is restricted by the maximum dimensions of a Microsoft DirectX texture; for more info see [Resource Limits ()](/windows/desktop/direct3d11/overviews-direct3d-11-resources-limits). This resource limit can vary depending on the hardware where the app runs. Very large content that exceeds this limit might be scaled to fit. If scaling limits are applied in this way, the rendered size after scaling can be queried using the PixelWidth and [PixelHeight](rendertargetbitmap_pixelheight.md) properties. For example, a 10000 by 10000 pixel XAML visual tree might be scaled to 4096 by 4096 pixels, an example of a particular resource limit on 2D textures being applied.

## -examples

## -see-also
