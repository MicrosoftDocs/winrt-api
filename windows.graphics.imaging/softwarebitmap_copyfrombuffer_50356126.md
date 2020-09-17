---
-api-id: M:Windows.Graphics.Imaging.SoftwareBitmap.CopyFromBuffer(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public void CopyFromBuffer(Windows.Storage.Streams.IBuffer buffer)
-->

# Windows.Graphics.Imaging.SoftwareBitmap.CopyFromBuffer

## -description
Copies the pixel data from an IBuffer into the [SoftwareBitmap](softwarebitmap.md).

## -parameters
### -param buffer
The buffer containing the pixel data to be copied.

## -remarks
Use this method to copy data from the [PixelBuffer](../windows.ui.xaml.media.imaging/writeablebitmap_pixelbuffer.md) of a [WriteableBitmap](../windows.ui.xaml.media.imaging/writeablebitmap.md) into an existing [SoftwareBitmap](softwarebitmap.md).

This method assumes that the input buffer has the same pixel format, width, height, color space, alpha mode, and DPI. It also assumes that the data in the buffer is contiguous. In other words, it expects that the stride of the image is equal to the width, with no additional padding.

## -examples

For a code example showing how to access pixel data, see the [WriteableBitmap.PixelBuffer](/uwp/api/windows.ui.xaml.media.imaging.writeablebitmap.pixelbuffer) property.

## -see-also

[WriteableBitmap.PixelBuffer](/uwp/api/windows.ui.xaml.media.imaging.writeablebitmap.pixelbuffer)
