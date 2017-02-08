---
-api-id: M:Windows.Media.Capture.MediaCapture.CreateFrameReaderAsync(Windows.Media.Capture.Frames.MediaFrameSource,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.Frames.MediaFrameReader> CreateFrameReaderAsync(Windows.Media.Capture.Frames.MediaFrameSource inputSource, System.String outputSubtype)
-->

# Windows.Media.Capture.MediaCapture.CreateFrameReaderAsync

## -description
Creates a [MediaFrameReader](../windows.media.capture.frames/mediaframereader.md) that is used to acquire frames with the specified media encoding subtype from a [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md).

## -parameters
### -param inputSource
The media frame source from which the reader will acquire frames.

### -param outputSubtype
A string specifying the requested media encoding subtype for the frames acquired by the frame reader. This value must be one of the strings defined by the properties of the [MediaEncodingSubtypes](../windows.media.mediaproperties/mediaencodingsubtypes.md) class.

## -returns
An asynchronous operation that returns a [MediaFrameReader](../windows.media.capture.frames/mediaframereader.md) on completion.

## -remarks

## -examples

## -see-also
[CreateFrameReaderAsync(MediaFrameSource)](mediacapture_createframereaderasync_823585061.md), [CreateFrameReaderAsync(MediaFrameSource, String, BitmapSize)](mediacapture_createframereaderasync_1014922223.md)