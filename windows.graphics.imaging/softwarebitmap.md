---
-api-id: T:Windows.Graphics.Imaging.SoftwareBitmap
-api-type: winrt class
---

<!-- Class syntax.
public class SoftwareBitmap : Windows.Foundation.IClosable, Windows.Graphics.Imaging.ISoftwareBitmap
-->

# Windows.Graphics.Imaging.SoftwareBitmap

## -description
Represents an uncompressed bitmap.

## -remarks
This class provides a representation of a bitmap that makes it easy to use with different imaging APIs. Use [GetSoftwareBitmapAsync](bitmapdecoder_getsoftwarebitmapasync.md) to create a [SoftwareBitmap](softwarebitmap.md) from a stream resource such as an image file. Use [CopyToBuffer](softwarebitmap_copytobuffer.md) and [CopyFromBuffer](softwarebitmap_copyfrombuffer.md) to copy pixel data back and forth between a [SoftwareBitmap](softwarebitmap.md) and the [PixelBuffer](../windows.ui.xaml.media.imaging/writeablebitmap_pixelbuffer.md) of a [WriteableBitmap](../windows.ui.xaml.media.imaging/writeablebitmap.md). Use [CreateCopyFromSurfaceAsync](softwarebitmap_createcopyfromsurfaceasync.md) to create a [SoftwareBitmap](softwarebitmap.md) from a [Direct3DSurface](softwarebitmap_createcopyfromsurfaceasync_1413621451.md) object.

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md)