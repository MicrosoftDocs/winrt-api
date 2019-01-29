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
Using one of the factory methods, you can create an instance of [MediaSource](mediasource.md) from many different media source representations, including:
+ [AdaptiveMediaSource](../windows.media.streaming.adaptive/adaptivemediasource.md)
+ [MediaStreamSource](mediastreamsource.md)
+ [MseStreamSource](msestreamsource.md)
+ [IStorageFile](../windows.storage/istoragefile.md)
+ [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md)
+ [IRandomAccessStreamReference](../windows.storage.streams/irandomaccessstreamreference.md)
+ [Uri](../windows.foundation/uri.md)


After getting a [MediaSource](mediasource.md) instance, create a new [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md) wrapping the media source and pass the [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md) to one of the media playback objects, such as [MediaPlayer](../windows.media.playback/mediaplayer.md) or [MediaElement](../windows.ui.xaml.controls/mediaelement.md).

For how-to guidance for using **MediaSource** to play back media, see [Media items, playlists, and tracks](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -examples

## -see-also
[Media items, playlists, and tracks](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-playback-with-mediasource/), [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md)
