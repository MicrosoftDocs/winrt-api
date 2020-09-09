---
-api-id: T:Windows.Media.Core.MediaSource
-api-type: winrt class
---

<!-- Class syntax.
public class MediaSource : Windows.Foundation.IClosable, Windows.Media.Core.IMediaSource2, Windows.Media.Core.IMediaSource3, Windows.Media.Core.IMediaSource4, Windows.Media.Playback.IMediaPlaybackSource
-->

# Windows.Media.Core.MediaSource

## -description
Represents a media source. Provides a common way to reference media from different sources and exposes a common model for accessing media data regardless of the underlying media format.

## -remarks
Using one of the factory methods, you can create an instance of MediaSource from many different media source representations, including:
+ [AdaptiveMediaSource](../windows.media.streaming.adaptive/adaptivemediasource.md)
+ [MediaStreamSource](mediastreamsource.md)
+ [MseStreamSource](msestreamsource.md)
+ [IStorageFile](../windows.storage/istoragefile.md)
+ [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md)
+ [IRandomAccessStreamReference](../windows.storage.streams/irandomaccessstreamreference.md)
+ [Uri](../windows.foundation/uri.md)

After getting a MediaSource instance, create a new [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md) wrapping the media source and pass the [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md) to one of the media playback objects, such as [MediaPlayer](../windows.media.playback/mediaplayer.md) or [MediaElement](../windows.ui.xaml.controls/mediaelement.md).

For how-to guidance for using **MediaSource** to play back media, see [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | CreateFromMediaBinder |
| 1511 | 10586 | Reset |
| 1511 | 10586 | State |
| 1511 | 10586 | StateChanged |
| 1703 | 15063 | AdaptiveMediaSource |
| 1703 | 15063 | MediaStreamSource |
| 1703 | 15063 | MseStreamSource |
| 1703 | 15063 | OpenAsync |
| 1703 | 15063 | Uri |
| 1709 | 16299 | CreateFromMediaFrameSource |
| 1803 | 17134 | CreateFromDownloadOperation |
| 1803 | 17134 | DownloadOperation |

## -examples

## -see-also
[Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource/), [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md)
