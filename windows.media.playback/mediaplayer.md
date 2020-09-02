---
-api-id: T:Windows.Media.Playback.MediaPlayer
-api-type: winrt class
---

<!-- Class syntax.
public class MediaPlayer : Windows.Foundation.IClosable, Windows.Media.Playback.IMediaPlayer, Windows.Media.Playback.IMediaPlayer2, Windows.Media.Playback.IMediaPlayer3, Windows.Media.Playback.IMediaPlayer4, Windows.Media.Playback.IMediaPlayer5, Windows.Media.Playback.IMediaPlayerEffects, Windows.Media.Playback.IMediaPlayerEffects2, Windows.Media.Playback.IMediaPlayerSource, Windows.Media.Playback.IMediaPlayerSource2
-->

# Windows.Media.Playback.MediaPlayer

## -description

Provides access to media playback functionality such as play, pause, fast-forward, rewind, and volume.

## -remarks

The [Media playback](/windows/uwp/audio-video-camera/media-playback) section of the documentation contains how-to articles that provide detailed guidance for adding media playback features to your app. The following table lists some of the available articles.

| Topic                                                                                             | Description                                                                                                                                                                                                                                                                                    |
|---------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer) | Shows you how to take advantage of the new features and improvements to the media playback system for UWP apps.                                                                                                          |
| [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource)                         | Shows you how to use the [**MediaSource**](/uwp/api/Windows.Media.Core.MediaSource) class, which provides a common way to reference and play back media from different sources such as local or remote files and exposes a common model for accessing media data, regardless of the underlying media format.                                                                                                               |
| [Integrate with the System Media Transport Controls](/windows/uwp/audio-video-camera/integrate-with-systemmediatransportcontrols)                               | Shows you how to integrate your app with the System Media Transport Controls (SMTC).                                    |
| [System-supported timed metadata cues](/windows/uwp/audio-video-camera/system-supported-metadata-cues)                               | Describes how to take advantage of several formats of timed metadata that may be embedded in media files or streams.                                   |
| [Create, schedule, and manage media breaks](/windows/uwp/audio-video-camera/create-schedule-and-manage-media-breaks)                                                                             | Shows you how to create, schedule, and manage media breaks to your media playback app.                                                                                                                      |
| [Play media in the background](/windows/uwp/audio-video-camera/background-audio)                                                                             | Shows you how to configure your app so that media continues to play when your app moves from the foreground to the background.                                                                                                                     |
| [Adaptive Streaming](/windows/uwp/audio-video-camera/adaptive-streaming)                                                       | Describes how to add playback of adaptive streaming multimedia content to a Universal Windows Platform (UWP) apps.                                           |
| [Media casting](/windows/uwp/audio-video-camera/media-casting)                                                                 | Shows you how to cast media to remote devices from a Universal Windows app.                                                                                                                                                                                                       |
| [PlayReady DRM](/windows/uwp/audio-video-camera/playready-client-sdk)                                                          | Describes how to add PlayReady protected media content to your Universal Windows Platform (UWP) app.                                                                                                                                                                                |

## Media playback SDK samples

The following SDK samples demonstrate the media playback features available to UWP apps on Windows 10. Use these samples to see the media playback APIs used in context or as a starting point for your own app.

* [Adaptive streaming sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/AdaptiveStreaming)
* [Background Audio sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundMediaPlayback)
* [System Media Transport sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/SystemMediaTransportControls)
* [360-degree Video Playback sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/360VideoPlayback)
* [Background media playback sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/BackgroundMediaPlayback)
* [Video playback synchronization sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/VideoPlaybackSynchronization)

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | AddAudioEffect |
| 1511 | 10586 | RemoveAllEffects |
| 1607 | 14393 | AddVideoEffect |
| 1607 | 14393 | AudioBalance |
| 1607 | 14393 | AudioDevice |
| 1607 | 14393 | BreakManager |
| 1607 | 14393 | CommandManager |
| 1607 | 14393 | GetAsCastingSource |
| 1607 | 14393 | GetSurface |
| 1607 | 14393 | IsMutedChanged |
| 1607 | 14393 | PlaybackSession |
| 1607 | 14393 | RealTimePlayback |
| 1607 | 14393 | SetSurfaceSize |
| 1607 | 14393 | SourceChanged |
| 1607 | 14393 | StepBackwardOneFrame |
| 1607 | 14393 | StepForwardOneFrame |
| 1607 | 14393 | StereoscopicVideoRenderMode |
| 1607 | 14393 | TimelineController |
| 1607 | 14393 | TimelineControllerPositionOffset |
| 1703 | 15063 | CopyFrameToStereoscopicVideoSurfaces |
| 1703 | 15063 | CopyFrameToVideoSurface(IDirect3DSurface) |
| 1703 | 15063 | CopyFrameToVideoSurface(IDirect3DSurface,Rect) |
| 1703 | 15063 | IsVideoFrameServerEnabled |
| 1703 | 15063 | VideoFrameAvailable |
| 1709 | 16299 | RenderSubtitlesToSurface(IDirect3DSurface) |
| 1709 | 16299 | RenderSubtitlesToSurface(IDirect3DSurface,Rect) |
| 1709 | 16299 | SubtitleFrameChanged |
| 1803 | 17134 | AudioStateMonitor |

## -examples

## -see-also
