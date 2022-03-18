---
-api-id: M:Windows.Media.Playback.MediaPlayer.RenderSubtitlesToSurface(Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface)
-api-type: winrt method
---

<!-- Method syntax.
public bool MediaPlayer.RenderSubtitlesToSurface(IDirect3DSurface destination)
-->

# Windows.Media.Playback.MediaPlayer.RenderSubtitlesToSurface

## -description
Requests for the system to render the current subtitle text to the provided [IDirect3DSurface](/uwp/api/Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface).

## -parameters
### -param destination
The object that implements **IDirect3DSurface**  to which the subtitle text is rendered.

## -returns
True if the system rendered subtitles to the surface; otherwise false.

## -remarks
Handle the [SubtitleFrameChanged](/uwp/api/windows.media.playback.mediaplayer.SubtitleFrameChanged) event to receive a notification that the subtitle content has changed. Check the return value to see if subtitles were rendered. If the method returns false, then no subtitles were rendered. In this case you may decide to hide the subtitle render surface in your UI.

In order to use this feature, you must place the [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) into frame server mode by setting [IsVideoFrameServerEnabled](/uwp/api/windows.media.playback.mediaplayer.IsVideoFrameServerEnabled) to **true**, and the playing media content must have at least one timed metadata track that has had its presentation mode set to [PlatformPresented](/uwp/api/windows.media.playback.timedmetadatatrackpresentationmode) with a call to [Media​Playback​Timed​Metadata​Track​List.SetPresentationMode](/uwp/api/windows.media.playback.mediaplaybacktimedmetadatatracklist#Windows_Media_Playback_MediaPlaybackTimedMetadataTrackList_SetPresentationMode_System_UInt32_Windows_Media_Playback_TimedMetadataTrackPresentationMode_). For more information on using MediaPlayer in frame server mode, see [Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer). For more information on working with metadata tracks, see [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -see-also
[IDirect3DSurface](/uwp/api/Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface)
[MediaPlayer](/uwp/api/windows.media.playback.mediaplayer)
[SubtitleFrameChanged](/uwp/api/windows.media.playback.mediaplayer.SubtitleFrameChanged)
[Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer)
[Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource)

## -examples

