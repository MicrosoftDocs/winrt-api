---
-api-id: T:Windows.Media.Playback.BackgroundMediaPlayer
-api-type: winrt class
---

<!-- Class syntax.
public class BackgroundMediaPlayer 
-->

# Windows.Media.Playback.BackgroundMediaPlayer

## -description
Provides access to the media player while it is running in the background.

> [!NOTE]
> Starting with Windows, version 1703, **BackgroundMediaPlayer** is deprecated and may not be available in future versions of Windows. Use the [MediaPlayer](mediaplayer.md) class instead. For more information, see [Play media in the background](/windows/uwp/audio-video-camera/background-audio).

## -remarks
Starting with Windows 10, version 1607, apps should use the [MediaPlayer](mediaplayer.md) for media playback. The *MediaPlayer* object allows you to play media in the background seamlessly, using a single process. For information on using **MediaPlayer**, see [Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer). For information on playing media in the background with **MediaPlayer**, see [Play media in the background](/windows/uwp/audio-video-camera/background-audio). For information on the legacy, two-process background playback model, which is still supported for backwards compatibility, see [Legacy background media playback](/windows/uwp/audio-video-camera/legacy-background-media-playback).

## -examples

## -see-also
[Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer), [Play media in the background](/windows/uwp/audio-video-camera/background-audio), [Legacy background media playback](/windows/uwp/audio-video-camera/legacy-background-media-playback)