---
-api-id: M:Windows.Media.Capture.MediaCapture.CreateFrameReaderAsync(Windows.Media.Capture.Frames.MediaFrameSource)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.Frames.MediaFrameReader> CreateFrameReaderAsync(Windows.Media.Capture.Frames.MediaFrameSource inputSource)
-->

# Windows.Media.Capture.MediaCapture.CreateFrameReaderAsync

## -description
Creates a [MediaFrameReader](../windows.media.capture.frames/mediaframereader.md) that is used to acquire frames from a [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md).

## -parameters
### -param inputSource
The media frame source from which the reader will acquire frames.

## -returns
An asynchronous operation that returns a [MediaFrameReader](../windows.media.capture.frames/mediaframereader.md) on completion.

## -remarks

## -examples
A **MediaFrameReader** created with this overload of the **CreateFrameReaderAsync** method returns frames for which the data is stored in a constrained pool of memory. When this pool of memory has been filled, no more frames will be read until you manually free previously obtained frames by calling  [Close](../windows.media.capture.frames/mediaframereference_close_811482585.md) (or **Dispose** in C#). The other two overloads of this method, [CreateFrameReaderAsync(Windows.Media.Capture.Frames.MediaFrameSource inputSource, System.String outputSubtype, Windows.Graphics.Imaging.BitmapSize outputSize)](mediacapture_createframereaderasync_1014922223.md) and [CreateFrameReaderAsync(Windows.Media.Capture.Frames.MediaFrameSource inputSource, System.String outputSubtype)](mediacapture_createframereaderasync_2112545947.md), return copies of the original frame data and so they do not cause frame acquisition to halt when they are retained.

## -see-also
[CreateFrameReaderAsync(MediaFrameSource, String)](mediacapture_createframereaderasync_2112545947.md), [CreateFrameReaderAsync(MediaFrameSource, String, BitmapSize)](mediacapture_createframereaderasync_1014922223.md)
## -capabilities
backgroundMediaRecording
