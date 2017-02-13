---
-api-id: M:Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap.GetPixelsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IBuffer> GetPixelsAsync()
-->

# Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap.GetPixelsAsync

## -description
Retrieves the previously rendered [RenderTargetBitmap](rendertargetbitmap.md) image as a buffered stream of bytes in **BGRA8** format.

## -returns
When this method returns, an [IBuffer](../windows.storage.streams/ibuffer.md) stream that contains bytes. This is the binary data for the image and can be converted to a byte array in **BGRA8** format

## -remarks
The [IBuffer](../windows.storage.streams/ibuffer.md) return value enables passing the result to a [WriteableBitmap](writeablebitmap.md) and its [PixelBuffer](writeablebitmap_pixelbuffer.md). Another alternative is passing the buffer to a [BitmapEncoder](../windows.graphics.imaging/bitmapencoder.md). If you want an array of bytes, use a [DataReader](../windows.storage.streams/datareader.md) and the [FromBuffer](../windows.storage.streams/datareader_frombuffer.md) method to help with the conversion.

Through the [IAsyncOperation](../windows.foundation/iasyncoperation_1.md) intermediate value, this method returns the pixels of the image source that was produced by the most recent call to [RenderAsync](rendertargetbitmap_renderasync.md).

Always call [RenderAsync](rendertargetbitmap_renderasync.md) before calling [GetPixelsAsync](rendertargetbitmap_getpixelsasync.md). If you call [GetPixelsAsync](rendertargetbitmap_getpixelsasync.md) and never called [RenderAsync](rendertargetbitmap_renderasync.md) previously on that [RenderTargetBitmap](rendertargetbitmap.md) instance, [GetPixelsAsync](rendertargetbitmap_getpixelsasync.md) will return an empty buffer stream, and no error will occur (async [Status](../windows.foundation/iasyncinfo_status.md) is **Completed**, so you can't use that as an indicator).

## -examples

## -see-also
[BitmapEncoder](../windows.graphics.imaging/bitmapencoder.md), [DataTransferManager](../windows.applicationmodel.datatransfer/datatransfermanager.md), [Windows.Graphics.Imaging namespace](../windows.graphics.imaging/windows_graphics_imaging.md), [XAML render to bitmap sample](http://go.microsoft.com/fwlink/p/?LinkID=309153)