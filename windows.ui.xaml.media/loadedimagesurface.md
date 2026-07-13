---
-api-id: T:Windows.UI.Xaml.Media.LoadedImageSurface
-api-type: winrt class
---

<!-- Class syntax.
public class LoadedImageSurface : IClosable, ICompositionSurface
-->

# Windows.UI.Xaml.Media.LoadedImageSurface

## -description
Represents a composition surface that an image can be downloaded, decoded and loaded onto. You can load an image using a Uniform Resource Identifier (URI) that references an image source file, or supplying a [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md).



## -remarks
A **LoadedImageSurface** can be sourced from these image file formats:

* Joint Photographic Experts Group (JPEG)
* Portable Network Graphics (PNG)
* Bitmap (BMP)
* Graphics Interchange Format (GIF)
* Tagged Image File Format (TIFF)
* JPEG XR
* Icons (ICO)

> [!NOTE] **LoadedImageSurface** does not support animated GIF images, so only the first frame of an animated GIF will be shown.

If the image source is a stream, that stream is expected to contain an image file in one of these formats.

### LoadedImageSurface encoding and decoding
The underlying codec support for image files is supplied by Windows Imaging Component (WIC) API in Windows. For more info on specific image formats as documented for the codes, see
[Native WIC Codecs](/windows/desktop/wic/native-wic-codecs).

Using one of the factory methods, you can create an instance of **LoadedImageSurface** from different types of image sources and control the max size that the image decodes at. If 
no max size is specified, then the image will decode to its natural size.

* [StartLoadFromUri(Uri)](loadedimagesurface_startloadfromuri_1520650003.md)
* [StartLoadFromUri(Uri, Size)](loadedimagesurface_startloadfromuri_2119955733.md)
* [StartLoadFromStream(IRandomAccessStream)](loadedimagesurface_startloadfromstream_1253534602.md)
* [StartLoadFromStream(IRandomAccessStream, Size)](loadedimagesurface_startloadfromstream_1850726798.md)

### Surface allocation and the desiredMaxSize threshold

When you specify a `desiredMaxSize`, the system uses it to determine the surface allocation strategy:

- **desiredMaxSize ≤ 2340 pixels** (per dimension): The surface is allocated as a non-virtual (performance-optimized) hardware surface. The image decodes up to `desiredMaxSize × currentDPIScale`, capped at approximately 16,380 pixels. This path is faster for typical UI images.
- **desiredMaxSize > 2340 pixels** (per dimension): The surface is allocated as a virtual surface, which supports resizing up to the hardware texture limit (typically 16,384 pixels per dimension). Initial allocation is slower but allows larger images.

The 2340-pixel threshold is derived from the maximum hardware texture size (16,384) divided by the maximum supported DPI scale factor (7). If you pass a `desiredMaxSize` between 2340 and 16,384 pixels expecting the image to decode at exactly that resolution on a non-virtual surface, the image may be downscaled without warning. To ensure full-resolution decoding for large images, pass a `desiredMaxSize` greater than 2340 pixels per dimension so a virtual surface is allocated.

> [!NOTE]
> The maximum hardware texture size (16,384 pixels) is determined by the graphics hardware and DirectComposition. The 2340-pixel threshold is an internal optimization heuristic and may change in future Windows releases.

### Lifetime management
When a **LoadedImageSurface** is created using one of the factory methods, the underlying surface is immediately initialized to a size of 0x0 and the image content begins
downloading and decoding off of the UI thread. When the image source has been successfully decoded, it then gets loaded onto the surface and the [LoadCompleted](loadedimagesurface_loadcompleted.md) event gets fired
when the surface has been populated. During the loading process, the surface will get resized from 0x0 to its final size based on the decoded size of the image source.

**LoadedImageSurface** automatically retains all of its resources until it loses its final reference. However, you may explicitly dispose of its resources through the [Close](loadedimagesurface_close_811482585.md) method.

> [!NOTE] **LoadedImageSurface** is not available prior to Windows 10, version 1703. If your app's 'minum platform version' setting in Microsoft Visual Studio is less
> than the 'introduced version' shown in the Requirements block later in this page, you cannot use this class.

## -see-also

[ICompositionSurface](../windows.ui.composition/icompositionsurface.md)

## -examples
This example shows how to load an image from a local URI onto a surface and use it in a [CompositionSurfaceBrush](../windows.ui.composition/compositionsurfacebrush.md).

```csharp
Compositor compositor = new Compositor();
CompositionSurfaceBrush imageBrush = compositor.CreateSurfaceBrush();

LoadedImageSurface loadedSurface = LoadedImageSurface.StartLoadFromUri(new Uri("ms-appx:///Assets/myPic.jpg"), new Size(200.0, 400.0));

// The loadedSurface currently has a size of 0x0 since it has not been downloaded, decoded and loaded to the surface yet
imageBrush.Surface = loadedSurface;
```
