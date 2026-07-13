---
-api-id: M:Windows.UI.Xaml.Media.LoadedImageSurface.StartLoadFromStream(Windows.Storage.Streams.IRandomAccessStream,Windows.Foundation.Size)
-api-type: winrt method
---

<!-- Method syntax.
public LoadedImageSurface LoadedImageSurface.StartLoadFromStream(IRandomAccessStream stream, Size desiredMaxSize)
-->

# Windows.UI.Xaml.Media.LoadedImageSurface.StartLoadFromStream


## -description

Loads an image into a [LoadedImageSurface](loadedimagesurface.md) from the provided [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md) with the desired maximum size.



## -parameters

### -param stream

The stream from which the image is loaded.

### -param desiredMaxSize

The desired maximum size of the image surface in device independent pixels.

## -returns

An instance of [LoadedImageSurface](loadedimagesurface.md) with the image loaded onto its surface.

## -remarks

By default, [LoadedImageSurface](loadedimagesurface.md) will fill up as much of the **desiredMaxSize** as possible while preserving the aspect ratio and image content of the incoming source. This may result in a decoded size that differs from the input **desiredMaxSize**.

The **desiredMaxSize** parameter also determines the surface allocation strategy. If either dimension of **desiredMaxSize** is 2340 pixels or less, the system allocates a non-virtual (performance-optimized) surface where the effective decode resolution is capped at `desiredMaxSize × currentDPIScale` (up to approximately 16,380 pixels). If either dimension exceeds 2340 pixels, a virtual surface is allocated that supports the full hardware texture limit (typically 16,384 pixels per dimension). For more information, see [LoadedImageSurface remarks](loadedimagesurface.md#surface-allocation-and-the-desiredmaxsize-threshold).

## -see-also

## -examples

