---
-api-id: M:Windows.Graphics.Imaging.BitmapDecoder.GetFrameAsync(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.BitmapFrame> GetFrameAsync(System.UInt32 frameIndex)
-->

# Windows.Graphics.Imaging.BitmapDecoder.GetFrameAsync

## -description
Asynchronously retrieves a frame from the image file.

## -parameters
### -param frameIndex
The zero-based index of the frame to be retrieved.

## -returns
Object that manages the asynchronous retrieval of the frame.

## -remarks
You don't need to use this method to access data from the first frame in an image file. [BitmapDecoder](bitmapdecoder.md) already provides a method to access the first frame.

You can get the total number of frames on the image using the [FrameCount](bitmapdecoder_framecount.md) property.

## -examples

## -see-also
