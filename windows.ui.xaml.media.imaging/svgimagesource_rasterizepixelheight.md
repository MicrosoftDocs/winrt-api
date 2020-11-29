---
-api-id: P:Windows.UI.Xaml.Media.Imaging.SvgImageSource.RasterizePixelHeight
-api-type: winrt property
---

<!-- Property syntax.
public double RasterizePixelHeight { get;  set; }
-->

# Windows.UI.Xaml.Media.Imaging.SvgImageSource.RasterizePixelHeight

## -description
Gets or sets the height to use for SVG rasterization operations.

Equivalent WinUI property: [Microsoft.UI.Xaml.Media.Imaging.SvgImageSource.RasterizePixelHeight](/windows/winui/api/microsoft.ui.xaml.media.imaging.svgimagesource.rasterizepixelheight).

## -xaml-syntax
```xaml
<SvgImageSource RasterizePixelHeight="double"/>
```

## -property-value
The height (in logical pixels) to use for SVG decoding operations. The default is **Double.NaN**.

## -remarks
Since the units are logical pixels, the SVG is decoded using values that are pre-factored for the logical resolution, and it potentially won't use as much memory.

If RasterizePixelHeight and [RasterizePixelWidth](svgimagesource_rasterizepixelwidth.md) aren't explicitly set, then the application's layout will determine the decode size so that the [SvgImageSource](svgimagesource.md) fits
in the available space.



