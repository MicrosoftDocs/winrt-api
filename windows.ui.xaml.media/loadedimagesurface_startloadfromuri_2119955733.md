---
-api-id: M:Windows.UI.Xaml.Media.LoadedImageSurface.StartLoadFromUri(Windows.Foundation.Uri,Windows.Foundation.Size)
-api-type: winrt method
---

<!-- Method syntax.
public LoadedImageSurface LoadedImageSurface.StartLoadFromUri(Uri uri, Size desiredMaxSize)
-->

# Windows.UI.Xaml.Media.LoadedImageSurface.StartLoadFromUri


## -description

Loads an image into a [LoadedImageSurface](loadedimagesurface.md) from the provided Uniform Resource Identifier (URI) with the desired maximum size.



## -parameters

### -param uri

The URI from which the image is loaded.

### -param desiredMaxSize

The desired maximum size of the image surface in device independent pixels.

## -returns

An instance of [LoadedImageSurface](loadedimagesurface.md) with the image loaded onto its surface.

## -remarks

By default, [LoadedImageSurface](loadedimagesurface.md) will fill up as much of the **desiredMaxSize** as possible while preserving the aspect ratio and image content
of the incoming source. This may result in a decodedsize that differs from the input **desiredMaxSize**

## -see-also

## -examples

