---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameSourceInfo
-api-type: winrt class
---

<!-- Class syntax.
public class MediaFrameSourceInfo : Windows.Media.Capture.Frames.IMediaFrameSourceInfo
-->

# Windows.Media.Capture.Frames.MediaFrameSourceInfo

## -description
Provides information about a [MediaFrameSource](mediaframesource.md).

## -remarks
Get an instance of this class by accessing the [Info](mediaframesource_info.md) property of a [MediaFrameSource](mediaframesource.md) object or by accessing the [SourceInfos](mediaframesourcegroup_sourceinfos.md) property of a [MediaFrameSourceGroup](mediaframesourcegroup.md) object which represents a group of media frame sources..

For how-to guidance on using [MediaFrameSource](mediaframesource.md) to capture frames, see [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | ProfileId |
| 1803 | 17134 | VideoProfileMediaDescription |
| 2004 | 19041 | GetRelativePanel |

## -examples

## -see-also
[Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader)
