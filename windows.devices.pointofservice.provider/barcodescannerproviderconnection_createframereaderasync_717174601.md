---
-api-id: M:Windows.Devices.PointOfService.Provider.BarcodeScannerProviderConnection.CreateFrameReaderAsync(Windows.Graphics.Imaging.BitmapPixelFormat)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<BarcodeScannerFrameReader> BarcodeScannerProviderConnection.CreateFrameReaderAsync(BitmapPixelFormat preferredFormat)
-->

# Windows.Devices.PointOfService.Provider.BarcodeScannerProviderConnection.CreateFrameReaderAsync

## -description
Creates a new [BarcodeScannerFrameReader](barcodescannerframereader.md) instance that returns frames in the preferred format when possible.

## -parameters
### -param preferredFormat
The preferred image format as a [BitmapPixelFormat](../windows.graphics.imaging/bitmappixelformat.md).

## -returns
A new **BarcodeScannerFrameReader** instance that reads frames from this **BarcodeScannerProviderConnection**.

## -remarks
If the requested format cannot be returned by the camera, frames will be returned using a default supported format. To ensure that the returned frames conform to a particular format, check the [Format](barcodescannervideoframe_format.md) property on the returned [BarcodeScannerVideoFrame](barcodescannervideoframe.md) objects.

## -see-also

## -examples

