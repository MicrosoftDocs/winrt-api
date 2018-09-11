---
-api-id: M:Windows.Graphics.Imaging.BitmapEncoder.FlushAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction FlushAsync()
-->

# Windows.Graphics.Imaging.BitmapEncoder.FlushAsync

## -description
Asynchronously commits and flushes all of the image data.

## -returns
An object that manages the asynchronous flush operation.

## -remarks
Call this method when you are done encoding and before you close the output stream. The minimum data you need to set on a new image before calling [FlushAsync](bitmapencoder_flushasync_491532439.md) is the pixel data ([SetPixelData](bitmapencoder_setpixeldata_644328650.md)). After this method is called, any subsequent calls to [BitmapEncoder](bitmapencoder.md) methods will fail.

If, after encoding is complete, you want to reuse the [IRandomAccessStream](http://msdn.microsoft.com/library/d2eceb3d-d13e-44c1-bfe2-1aa57f7432c6) from which the [BitmapEncoder](bitmapencoder.md) was created, such as passing it to the [Windows.Storage.Compression](../windows.storage.compression/windows_storage_compression.md) APIs, you must first reset the stream's seek position to 0, the start of the stream, by calling [IRandomAccessStream.Seek](../windows.storage.streams/irandomaccessstream_seek_1797934981.md).

## -examples

## -see-also
