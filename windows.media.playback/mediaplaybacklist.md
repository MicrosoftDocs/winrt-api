---
-api-id: T:Windows.Media.Playback.MediaPlaybackList
-api-type: winrt class
---

<!-- Class syntax.
public class MediaPlaybackList : Windows.Media.Playback.IMediaPlaybackList, Windows.Media.Playback.IMediaPlaybackList2, Windows.Media.Playback.IMediaPlaybackList3, Windows.Media.Playback.IMediaPlaybackSource
-->

# Windows.Media.Playback.MediaPlaybackList

## -description
Represents a list of [MediaPlaybackItem](mediaplaybackitem.md) objects that can be played back. Provides methods for switching the currently playing item and enabling looping and shuffling.

## -remarks
Items in a [MediaPlaybackList](mediaplaybacklist.md) are rendered using gapless playback. The system will use provided metadata in MP3 or AAC encoded files to determine the delay or padding compensation needed for gapless playback. If the MP3 or AAC encoded files don't provide this metadata, then the system determines the delay or padding heuristically. For lossless formats, such as PCM, FLAC, or ALAC, the system takes no action because these encoders don't introduce delay or padding.

For how-to guidance for working with media items, see [Media items, playlists, and tracks](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -examples

## -see-also
[IMediaPlaybackSource](imediaplaybacksource.md), [Media items, playlists, and tracks](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/media-playback-with-mediasource)