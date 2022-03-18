---
-api-id: M:Windows.Graphics.Imaging.BitmapEncoder.CreateForTranscodingAsync(Windows.Storage.Streams.IRandomAccessStream,Windows.Graphics.Imaging.BitmapDecoder)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.BitmapEncoder> CreateForTranscodingAsync(Windows.Storage.Streams.IRandomAccessStream stream, Windows.Graphics.Imaging.BitmapDecoder bitmapDecoder)
-->

# Windows.Graphics.Imaging.BitmapEncoder.CreateForTranscodingAsync

## -description
Asynchronously creates a new [BitmapEncoder](bitmapencoder.md) and initializes it using data from an existing [BitmapDecoder](bitmapdecoder.md).

## -parameters
### -param stream
The output stream.

### -param bitmapDecoder
A [BitmapDecoder](bitmapdecoder.md) containing the image data to be copied.

## -returns
An object that manages the asynchronous creation of a new [BitmapEncoder](bitmapencoder.md) using data from an existing [BitmapDecoder](bitmapdecoder.md).

## -remarks
Call this method when you want to edit some elements in an image but want to preserve the rest of the data intact. For example, if you want to write some metadata or properties but don't want to touch the image itself. When you create a [BitmapEncoder](bitmapencoder.md) using this method, it is initialized using data from the *bitmapDecoder* argument. Any data that you set on the encoder will overwrite the existing data, and all other data is preserved unchanged.

This method only allows you to create an encoder of the same image format as the decoder.

## -examples

## -see-also
[Imaging](/windows/uwp/audio-video-camera/imaging)
