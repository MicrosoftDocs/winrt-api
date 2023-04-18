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

## -examples

Sample applications that use this class include the [Camera frames sample](/samples/microsoft/windows-universal-samples/cameraframes/).

For a code example showing how to access pixel data, see the [WriteableBitmap.PixelBuffer](/uwp/api/windows.ui.xaml.media.imaging.writeablebitmap.pixelbuffer) property (also see [CopyToBuffer](softwarebitmap_copytobuffer_1167750415.md), and [CopyFromBuffer](softwarebitmap_copyfrombuffer_50356126.md)).

## -remarks
This class provides a representation of a bitmap that makes it easy to use with different imaging APIs. Use [GetSoftwareBitmapAsync](bitmapdecoder_getsoftwarebitmapasync_1163471917.md) to create a SoftwareBitmap from a stream resource such as an image file.

Use [CopyToBuffer](softwarebitmap_copytobuffer_1167750415.md) and [CopyFromBuffer](softwarebitmap_copyfrombuffer_50356126.md) to copy pixel data back and forth between a **SoftwareBitmap** and the [PixelBuffer](../windows.ui.xaml.media.imaging/writeablebitmap_pixelbuffer.md) of a [WriteableBitmap](../windows.ui.xaml.media.imaging/writeablebitmap.md).
Use [CreateCopyFromSurfaceAsync](softwarebitmap_createcopyfromsurfaceasync_1666076722.md) to create a **SoftwareBitmap** from an [IDirect3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md).
Use [ISoftwareBitmapNativeFactory::CreateFromMF2DBuffer2](/windows/win32/api/windows.graphics.imaging.interop/nf-windows-graphics-imaging-interop-isoftwarebitmapnativefactory-createfrommf2dbuffer2) to create a **SoftwareBitmap** from an [IMF2DBuffer2](/windows/win32/api/mfobjects/nn-mfobjects-imf2dbuffer2).
Use [ISoftwareBitmapNativeFactory::CreateFromIWICBitmap](/windows/win32/api/windows.graphics.imaging.interop/nf-windows-graphics-imaging-interop-isoftwarebitmapnativefactory-createfromwicbitmap) to create a **SoftwareBitmap** from an [IWICBitmap](/windows/desktop/api/wincodec/nn-wincodec-iwicbitmap).


## -see-also
[IClosable](../windows.foundation/iclosable.md), [Camera frames sample](/samples/microsoft/windows-universal-samples/cameraframes/)
