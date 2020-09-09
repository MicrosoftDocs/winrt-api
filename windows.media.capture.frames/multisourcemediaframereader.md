---
-api-id: T:Windows.Media.Capture.Frames.MultiSourceMediaFrameReader
-api-type: winrt class
---

<!-- Class syntax.
public class MultiSourceMediaFrameReader : IClosable
-->

# Windows.Media.Capture.Frames.MultiSourceMediaFrameReader

## -description
Provides access to time-correlated frames from multiple [MediaFrameSource](mediaframesource.md) and provides notifications when new frames arrive. This is useful if you need to process frames from different sources, such as a depth camera and an rbg camera, and you need to make sure that the frames from each source were captured close to each other in time.

## -remarks
Get an instance of this class by calling [CreateMultiSourceFrameReaderAsync](../windows.media.capture/mediacapture_createmultisourceframereaderasync_1316837028.md) on a [MediaCapture](../windows.media.capture/mediacapture.md) object that has been initialized to use the desired media frame source.

To read frames from one or more [MediaFrameSource](mediaframesource.md) objects without time correlation between different sources, you can use [MediaFrameReader](../mediaframereader.md).

For how-to guidance on using [MediaFrameSource](mediaframesource.md) to capture frames, see [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | AcquisitionMode |

## -see-also

## -examples

