---
-api-id: P:Windows.UI.Xaml.Media.Imaging.SvgImageSource.RasterizePixelWidth
-api-type: winrt property
---

<!-- Property syntax.
public double RasterizePixelWidth { get;  set; }
-->

# Windows.UI.Xaml.Media.Imaging.SvgImageSource.RasterizePixelWidth

## -description
Gets or sets the width to use for SVG rasterization operations.

Equivalent WinUI property: [Microsoft.UI.Xaml.Media.Imaging.SvgImageSource.RasterizePixelWidth](/windows/winui/api/microsoft.ui.xaml.media.imaging.svgimagesource.rasterizepixelwidth).

## -xaml-syntax
```xaml
<SvgImageSource RasterizePixelWidth="double"/>
```

## -property-value
The width (in logical pixels) to use for SVG decoding operations. The default is **Double.NaN**.

## -remarks
Since the units are logical pixels, the SVG is decoded using values that are pre-factored for the logical resolution, and it potentially won't use as much memory.

If [RasterizePixelHeight](svgimagesource_rasterizepixelheight.md) and RasterizePixelWidth aren't explicitly set, then the application's layout will determine the decode size so that the [SvgImageSource](svgimagesource.md) fits
in the available space.

