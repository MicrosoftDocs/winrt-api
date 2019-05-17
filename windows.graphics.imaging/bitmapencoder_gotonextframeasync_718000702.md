---
-api-id: M:Windows.Graphics.Imaging.BitmapEncoder.GoToNextFrameAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction GoToNextFrameAsync()
-->

# Windows.Graphics.Imaging.BitmapEncoder.GoToNextFrameAsync

## -description
Asynchronously commits the current frame data and appends a new empty frame to be edited.

## -returns
An object that manages the asynchronous operation of committing the current frame data and appending a new empty frame to be edited.

## -remarks
After this method is called, data on the just-committed frame is no longer accessible. Instead, a new, empty frame is appended to the image and subsequent reads and writes on the [BitmapEncoder](bitmapencoder.md) will access this frame. You can't "rewind" to a previously committed frame.

Don't call this method if the current frame is intended to be the last frame in the image, as this will result in a superfluous, empty frame at the end of the image. Instead, call [FlushAsync](bitmapencoder_flushasync_491532439.md) which will commit the frame and close the entire [BitmapEncoder](bitmapencoder.md). For example, in most scenarios the application only needs to save a single-frame image. In these cases GoToNextFrameAsync should never be called.

The first time this method is called, all container level data as well as the first frame data is committed. Afterwards, any attempts to access container level data will fail.

## -examples

## -see-also
[GoToNextFrameAsync(IIterable(IKeyValuePair))](bitmapencoder_gotonextframeasync_1063265177.md)
