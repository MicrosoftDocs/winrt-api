---
-api-id: T:Windows.Media.Playback.MediaPlaybackVideoTrackList
-api-type: winrt class
---

<!-- Class syntax.
public class MediaPlaybackVideoTrackList : Windows.Foundation.Collections.IIterable<Windows.Media.Core.VideoTrack>, Windows.Foundation.Collections.IVectorView<Windows.Media.Core.VideoTrack>, Windows.Media.Core.ISingleSelectMediaTrackList
-->

# Windows.Media.Playback.MediaPlaybackVideoTrackList

## -description
Represents a read-only list of [VideoTrack](../windows.media.core/videotrack.md) objects, of which a single track can be selected at one time.

## -remarks
Get an instance of this class by accessing the [VideoTracks](mediaplaybackitem_videotracks.md) property of a [MediaPlaybackItem](mediaplaybackitem.md). To be notified when the list of tracks changes, handle the [VideoTracksChanged](mediaplaybackitem_videotrackschanged.md) event.

This class provides access to the list of [VideoTrack](../windows.media.core/videotrack.md) objects that are associated with a [MediaPlaybackItem](mediaplaybackitem.md). When the media item is opened by a component and the [ItemOpened](mediaplaybacklist_itemopened.md) event is raised, you can select one of the video tracks in the track list for playback.

Note that this class does not represent a playlist of video tracks that are played sequentially. To play a sequential list of tracks, use [MediaPlaybackList](mediaplaybacklist.md).

For how-to guidance for working with the video tracks of a media item, see [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -examples

## -see-also
[IVectorView(VideoTrack)](../windows.foundation.collections/ivectorview_1.md), [IIterable(VideoTrack)](../windows.foundation.collections/iiterable_1.md), [ISingleSelectMediaTrackList](../windows.media.core/isingleselectmediatracklist.md), [VideoTrack](../windows.media.core/videotrack.md), [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource)