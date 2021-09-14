---
-api-id: M:Windows.UI.Xaml.Media.Imaging.SurfaceImageSource.#ctor(System.Int32,System.Int32,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public SurfaceImageSource(System.Int32 pixelWidth, System.Int32 pixelHeight, System.Boolean isOpaque)
-->

# Windows.UI.Xaml.Media.Imaging.SurfaceImageSource.SurfaceImageSource

## -description
Initializes a new instance of the [SurfaceImageSource](surfaceimagesource.md) class, specifying the size of the drawing area, and whether opacity is expected to be always full opacity. Use this with `isOpaque=true` if [SurfaceImageSource](surfaceimagesource.md) should not support transparency; this can increase performance.


## -parameters
### -param pixelWidth
Width of the drawing area in pixels.

### -param pixelHeight
Height of the drawing area in pixels.

### -param isOpaque
**true** if the area should render opaque. **false** to render with possible alpha transparency. A value of **true** can provide a performance benefit if the content is not transparent.

## -remarks

## -examples

## -see-also
[SurfaceImageSource(Int32, Int32)](surfaceimagesource_surfaceimagesource_452674076.md)
