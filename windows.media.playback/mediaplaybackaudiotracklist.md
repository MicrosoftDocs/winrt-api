---
-api-id: T:Windows.Media.Playback.MediaPlaybackAudioTrackList
-api-type: winrt class
---

<!-- Class syntax.
public class MediaPlaybackAudioTrackList : Windows.Foundation.Collections.IIterable<Windows.Media.Core.AudioTrack>, Windows.Foundation.Collections.IVectorView<Windows.Media.Core.AudioTrack>, Windows.Media.Core.ISingleSelectMediaTrackList
-->

# Windows.Media.Playback.MediaPlaybackAudioTrackList

## -description
Represents a read-only list of [AudioTrack](../windows.media.core/audiotrack.md) objects, of which a single track can be selected at one time.

## -remarks
Get an instance of this class by accessing the [AudioTracks](mediaplaybackitem_audiotracks.md) property of a [MediaPlaybackItem](mediaplaybackitem.md). To be notified when the list of tracks changes, handle the [AudioTracksChanged](mediaplaybackitem_audiotrackschanged.md) event.

This class provides access to the list of [AudioTrack](../windows.media.core/audiotrack.md) objects that are associated with a [MediaPlaybackItem](mediaplaybackitem.md). When the media item is opened by a component and the [ItemOpened](mediaplaybacklist_itemopened.md) event is raised, you can select one of the audio tracks in the track list for playback.

Note that this class does not represent a playlist of audio tracks that are played sequentially. To play a sequential list of tracks, use [MediaPlaybackList](mediaplaybacklist.md).

For how-to guidance for working with the audio tracks of a media item, see [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -examples

## -see-also
[IVectorView(AudioTrack)](../windows.foundation.collections/ivectorview_1.md), [IIterable(AudioTrack)](../windows.foundation.collections/iiterable_1.md), [ISingleSelectMediaTrackList](../windows.media.core/isingleselectmediatracklist.md), [AudioTrack](../windows.media.core/audiotrack.md), [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource)