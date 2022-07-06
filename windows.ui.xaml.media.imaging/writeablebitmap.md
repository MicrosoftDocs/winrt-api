---
-api-id: T:Windows.UI.Xaml.Media.Imaging.WriteableBitmap
-api-type: winrt class
---

<!-- Class syntax.
public class WriteableBitmap : Windows.UI.Xaml.Media.Imaging.BitmapSource, Windows.UI.Xaml.Media.Imaging.IWriteableBitmap
-->

# Windows.UI.Xaml.Media.Imaging.WriteableBitmap

## -description

Provides a [BitmapSource](bitmapsource.md) that can be written to and updated.



## -remarks

The image source data of a WriteableBitmap is an underlying pixel buffer.

The [IBuffer](/uwp/api/windows.storage.streams.ibuffer) returned by [WriteableBitmap.PixelBuffer](writeablebitmap_pixelbuffer.md) can't be written to directly. But you can use language-specific techniques to write to the underlying pixel content in the buffer. For details, see the **Remarks** section of [WriteableBitmap.PixelBuffer](writeablebitmap_pixelbuffer.md).

Some of the scenarios where you might have used a **WriteableBitmap** class in previous XAML frameworks can be accomplished in the Windows Runtime by using the [RenderTargetBitmap](rendertargetbitmap.md) class instead. For more info see [RenderTargetBitmap](rendertargetbitmap.md).

## -examples

For code examples in C#, C++/WinRT, and C++/CX, see [WriteableBitmap.PixelBuffer](writeablebitmap_pixelbuffer.md).

## -see-also

[BitmapSource](bitmapsource.md), [WriteableBitmap.PixelBuffer](writeablebitmap_pixelbuffer.md), [BitmapDecoder](../windows.graphics.imaging/bitmapdecoder.md), [Windows.Graphics.Imaging namespace](../windows.graphics.imaging/windows_graphics_imaging.md), [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample), [Camera preview frame sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620516)
