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
This class provides a representation of a bitmap that makes it easy to use with different imaging APIs. Use [GetSoftwareBitmapAsync](bitmapdecoder_getsoftwarebitmapasync_1163471917.md) to create a SoftwareBitmap from a stream resource such as an image file. Use [CopyToBuffer](softwarebitmap_copytobuffer_1167750415.md) and [CopyFromBuffer](softwarebitmap_copyfrombuffer_50356126.md) to copy pixel data back and forth between a SoftwareBitmap and the [PixelBuffer](../windows.ui.xaml.media.imaging/writeablebitmap_pixelbuffer.md) of a [WriteableBitmap](../windows.ui.xaml.media.imaging/writeablebitmap.md). Use [CreateCopyFromSurfaceAsync](softwarebitmap_createcopyfromsurfaceasync_1666076722.md) to create a SoftwareBitmap from a [Direct3DSurface](softwarebitmap_createcopyfromsurfaceasync_1413621451.md) object.

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md)
