---
-api-id: T:Windows.Media.Playback.MediaPlaybackItem
-api-type: winrt class
---

<!-- Class syntax.
public class MediaPlaybackItem : Windows.Media.Playback.IMediaPlaybackItem, Windows.Media.Playback.IMediaPlaybackItem2, Windows.Media.Playback.IMediaPlaybackItem3, Windows.Media.Playback.IMediaPlaybackSource
-->

# Windows.Media.Playback.MediaPlaybackItem

## -description
Represents a media item that can be played back. This class acts as a wrapper around a [MediaSource](../windows.media.core/mediasource.md) that exposes the audio tracks, video tracks, and timed metadata tracks included in the media source.

## -remarks
A **MediaPlaybackItem** can be passed directly to a player such as [MediaPlayer](mediaplayer.md), [MediaElement](../windows.ui.xaml.controls/mediaelement.md) or [MediaPlayerElement](../windows.ui.xaml.controls/mediaplayerelement.md). Or, you can even pass the player a list of multiple media playback items using the [MediaPlaybackList](mediaplaybacklist.md) class.

For how-to guidance for working with media items, see [Media items, playlists, and tracks](https://msdn.microsoft.com/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -examples

## -see-also
[IMediaPlaybackSource](imediaplaybacksource.md), [Media items, playlists, and tracks](https://msdn.microsoft.com/windows/uwp/audio-video-camera/media-playback-with-mediasource)
