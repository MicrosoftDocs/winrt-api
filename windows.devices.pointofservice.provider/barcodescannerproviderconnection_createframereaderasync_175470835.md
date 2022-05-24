---
-api-id: M:Windows.Devices.PointOfService.Provider.BarcodeScannerProviderConnection.CreateFrameReaderAsync(Windows.Graphics.Imaging.BitmapPixelFormat,Windows.Graphics.Imaging.BitmapSize)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<BarcodeScannerFrameReader> BarcodeScannerProviderConnection.CreateFrameReaderAsync(BitmapPixelFormat preferredFormat, BitmapSize preferredSize)
-->

# Windows.Devices.PointOfService.Provider.BarcodeScannerProviderConnection.CreateFrameReaderAsync

## -description
Creates a new [BarcodeScannerFrameReader](barcodescannerframereader.md) instance that returns frames in the preferred format and size when possible.

## -parameters
### -param preferredFormat
The preferred image format as a [BitmapPixelFormat](../windows.graphics.imaging/bitmappixelformat.md).

### -param preferredSize
The preferred frame size as a [BitmapSize](../windows.graphics.imaging/bitmapsize.md) in pixels.

## -returns
A new **BarcodeScannerFrameReader** instance that reads frames from this **BarcodeScannerProviderConnection**.

## -remarks
If the requested format or size cannot be returned by the camera, frames will be returned using a default supported format and/or size. To ensure that the returned frames conform to a particular format or size, check the [Format](barcodescannervideoframe_format.md), [Height](barcodescannervideoframe_height.md) and [Width](barcodescannervideoframe_width.md) properties on the returned [BarcodeScannerVideoFrame](barcodescannervideoframe.md) objects.

## -see-also

## -examples

