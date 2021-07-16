---
-api-id: T:Windows.Media.Playback.MediaPlaybackTimedMetadataTrackList
-api-type: winrt class
---

<!-- Class syntax.
public class MediaPlaybackTimedMetadataTrackList : Windows.Foundation.Collections.IIterable<Windows.Media.Core.TimedMetadataTrack>, Windows.Foundation.Collections.IVectorView<Windows.Media.Core.TimedMetadataTrack>, Windows.Media.Playback.IMediaPlaybackTimedMetadataTrackList
-->

# Windows.Media.Playback.MediaPlaybackTimedMetadataTrackList

## -description
Represents a read-only list of [TimedMetadataTrack](../windows.media.core/timedmetadatatrack.md) objects.

## -remarks
Get an instance of this class by accessing the [TimedMetadataTracks](mediaplaybackitem_timedmetadatatracks.md) property of a [MediaPlaybackItem](mediaplaybackitem.md). To be notified when the list of tracks changes, handle the [TimedMetadataTracksChanged](mediaplaybackitem_timedmetadatatrackschanged.md) event.

For how-to guidance for working with metadata tracks, see [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -examples

## -see-also
[IVectorView(TimedMetadataTrack)](../windows.foundation.collections/ivectorview_1.md), [IIterable(TimedMetadataTrack)](../windows.foundation.collections/iiterable_1.md), [TimedMetadataTrack](../windows.media.core/timedmetadatatrack.md), [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource)