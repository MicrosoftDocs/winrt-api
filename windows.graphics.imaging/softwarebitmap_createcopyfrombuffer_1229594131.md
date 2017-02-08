---
-api-id: M:Windows.Graphics.Imaging.SoftwareBitmap.CreateCopyFromBuffer(Windows.Storage.Streams.IBuffer,Windows.Graphics.Imaging.BitmapPixelFormat,System.Int32,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Graphics.Imaging.SoftwareBitmap CreateCopyFromBuffer(Windows.Storage.Streams.IBuffer source, Windows.Graphics.Imaging.BitmapPixelFormat format, System.Int32 width, System.Int32 height)
-->

# Windows.Graphics.Imaging.SoftwareBitmap.CreateCopyFromBuffer

## -description
Creates a new [SoftwareBitmap](softwarebitmap.md) by performing a deep copy of the provided buffer. Modifications to the data in the new [SoftwareBitmap](softwarebitmap.md) will not effect the buffer from which it was created.

## -parameters
### -param source
The source buffer from which the copy will be created.

### -param format
The pixel format of the software bitmap.

### -param width
The width of the software bitmap, in pixels.

### -param height
The height of the software bitmap, in pixels.

## -returns
The new software bitmap.

## -remarks
Use this method and its overloads to copy data from the [PixelBuffer](../windows.ui.xaml.media.imaging/writeablebitmap_pixelbuffer.md) of a [WriteableBitmap](../windows.ui.xaml.media.imaging/writeablebitmap.md) into an existing [SoftwareBitmap](softwarebitmap.md).



## -examples

## -see-also
[CreateCopyFromBuffer(IBuffer, BitmapPixelFormat, Int32, Int32, BitmapAlphaMode)](softwarebitmap_createcopyfrombuffer_1251135091.md)