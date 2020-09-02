---
-api-id: E:Windows.Media.Playback.MediaPlayer.SubtitleFrameChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler SubtitleFrameChanged<MediaPlayer,  object>
-->

# Windows.Media.Playback.MediaPlayer.SubtitleFrameChanged

## -description
Occurs when the current subtitle content has changed while the [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) is in frame server mode. 

## -remarks
In the handler for this event, you can call one of the overloads of [RenderSubtitlesToSurface](/uwp/api/windows.media.playback.mediaplayer#Windows_Media_Playback_MediaPlayer_RenderSubtitlesToSurface_Windows_Graphics_DirectX_Direct3D11_IDirect3DSurface_) to request that the system render the current subtitles to the provided IDirect3DSurface. If this method returns false, then no subtitles were rendered. In this case, you may choose to hide the subtitle render surface until the next time the event is raised.

In order for this event to be raised, you must place the [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) into frame server mode by setting [IsVideoFrameServerEnabled](/uwp/api/windows.media.playback.mediaplayer.IsVideoFrameServerEnabled) to **true**, and the playing media content must have at least one timed metadata track that has had its presentation mode set to [PlatformPresented](/uwp/api/windows.media.playback.timedmetadatatrackpresentationmode) with a call to [Media​Playback​Timed​Metadata​Track​List.SetPresentationMode](/uwp/api/windows.media.playback.mediaplaybacktimedmetadatatracklist#Windows_Media_Playback_MediaPlaybackTimedMetadataTrackList_SetPresentationMode_System_UInt32_Windows_Media_Playback_TimedMetadataTrackPresentationMode_). For more information on using MediaPlayer in frame server mode, see [Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer). For more information on working with metadata tracks, see [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -see-also
[IDirect3DSurface](/uwp/api/Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface)
[MediaPlayer](/uwp/api/windows.media.playback.mediaplayer)
[SubtitleFrameChanged](/uwp/api/windows.media.playback.mediaplayer.SubtitleFrameChanged)
[Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer)
[Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource)

## -examples

