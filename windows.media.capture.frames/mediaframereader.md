---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameReader
-api-type: winrt class
---

<!-- Class syntax.
public class MediaFrameReader : Windows.Foundation.IClosable, Windows.Media.Capture.Frames.IMediaFrameReader
-->

# Windows.Media.Capture.Frames.MediaFrameReader

## -description
Provides access to frames from a [MediaFrameSource](mediaframesource.md) and notification when a new frame arrives.

## -remarks
Get an instance of this class by calling [CreateFrameReaderAsync](../windows.media.capture/mediacapture_createframereaderasync_1014922223.md) on a [MediaCapture](https://msdn.microsoft.com/library/1361e82a-202f-40f7-9239-56f00dfca54b) object that has been initialized to use the desired media frame source.

For how-to guidance on using [MediaFrameSource](mediaframesource.md) to capture frames, see [Process media frames with MediaFrameReader](https://msdn.microsoft.com/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md), [Process media frames with MediaFrameReader](https://msdn.microsoft.com/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader)