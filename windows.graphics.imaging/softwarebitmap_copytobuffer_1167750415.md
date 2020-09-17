---
-api-id: M:Windows.Graphics.Imaging.SoftwareBitmap.CopyToBuffer(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public void CopyToBuffer(Windows.Storage.Streams.IBuffer buffer)
-->

# Windows.Graphics.Imaging.SoftwareBitmap.CopyToBuffer

## -description
Copies the software bitmap pixel data into the specified [IBuffer](../windows.storage.streams/ibuffer.md).

## -parameters
### -param buffer
The target buffer to which the pixel data will be copied.

## -remarks
Use this method to copy pixel data from a [SoftwareBitmap](softwarebitmap.md) into the [PixelBuffer](../windows.ui.xaml.media.imaging/writeablebitmap_pixelbuffer.md) of a [WriteableBitmap](../windows.ui.xaml.media.imaging/writeablebitmap.md).

## -examples

For a code example showing how to access pixel data, see the [WriteableBitmap.PixelBuffer](/uwp/api/windows.ui.xaml.media.imaging.writeablebitmap.pixelbuffer) property.

## -see-also

[WriteableBitmap.PixelBuffer](/uwp/api/windows.ui.xaml.media.imaging.writeablebitmap.pixelbuffer)
