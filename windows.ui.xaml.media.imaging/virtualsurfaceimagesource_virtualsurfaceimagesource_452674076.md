---
-api-id: M:Windows.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource.#ctor(System.Int32,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public VirtualSurfaceImageSource(System.Int32 pixelWidth, System.Int32 pixelHeight)
-->

# Windows.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource.VirtualSurfaceImageSource

## -description
Initializes a new instance of the [VirtualSurfaceImageSource](virtualsurfaceimagesource.md) class, specifying the size of the drawing area.


## -parameters
### -param pixelWidth
Width of the drawing area in pixels.

### -param pixelHeight
Height of the drawing area in pixels.

## -remarks
<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 464445-->
### Windows 8 behavior

Windows 8 validates that *pixelWidth* and *pixelHeight* are under 100 million (100,000,000). Starting with Windows 8.1 the validation limit is 17 million (17,000,000) in each dimension. > [!NOTE]
> Other factors might impact how much content can be rendered in a single [VirtualSurfaceImageSource](virtualsurfaceimagesource.md). For example, placing a [VirtualSurfaceImageSource](virtualsurfaceimagesource.md) in a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) might further reduce the effective size based on the [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md)'s limits.

## -examples

## -see-also
[VirtualSurfaceImageSource(Int32, Int32, Boolean)](virtualsurfaceimagesource_virtualsurfaceimagesource_566678036.md)
