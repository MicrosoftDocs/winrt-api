---
-api-id: M:Windows.Media.Capture.MediaCapture.CreateFrameReaderAsync(Windows.Media.Capture.Frames.MediaFrameSource,System.String,Windows.Graphics.Imaging.BitmapSize)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.Frames.MediaFrameReader> CreateFrameReaderAsync(Windows.Media.Capture.Frames.MediaFrameSource inputSource, System.String outputSubtype, Windows.Graphics.Imaging.BitmapSize outputSize)
-->

# Windows.Media.Capture.MediaCapture.CreateFrameReaderAsync

## -description
Creates a [MediaFrameReader](../windows.media.capture.frames/mediaframereader.md) that is used to acquire frames with the specified media encoding subtype and size from a [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md).

## -parameters
### -param inputSource
The media frame source from which the reader will acquire frames.

### -param outputSubtype
A string specifying the requested media encoding subtype for the frames acquired by the frame reader. This value must be one of the strings defined by the properties of the [MediaEncodingSubtypes](../windows.media.mediaproperties/mediaencodingsubtypes.md) class.

### -param outputSize
An object specifying the requested size for the frames acquired by the frame reader.

## -returns
An asynchronous operation that returns a [MediaFrameReader](../windows.media.capture.frames/mediaframereader.md) on completion.

## -remarks

## -examples

## -see-also
[CreateFrameReaderAsync(MediaFrameSource)](mediacapture_createframereaderasync_823585061.md), [CreateFrameReaderAsync(MediaFrameSource, String)](mediacapture_createframereaderasync_2112545947.md)