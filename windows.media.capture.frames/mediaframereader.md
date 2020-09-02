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
Get an instance of this class by calling [CreateFrameReaderAsync](../windows.media.capture/mediacapture_createframereaderasync_1014922223.md) on a [MediaCapture](/windows/uwp/audio-video-camera/capture-photos-and-video-with-mediacapture) object that has been initialized to use the desired media frame source.

For how-to guidance on using [MediaFrameSource](mediaframesource.md) to capture frames, see [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | AcquisitionMode |

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md), [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader)
