---
-api-id: M:Windows.Media.Playback.MediaPlayer.Pause
-api-type: winrt method
---

<!-- Method syntax
public void Pause()
-->

# Windows.Media.Playback.MediaPlayer.Pause

## -description
Pauses media playback.

## -remarks
Note that after you call **Pause**, the time represented by the [**Position**](https://docs.microsoft.com/en-us/uwp/api/windows.media.playback.mediaplaybacksession#Windows_Media_Playback_MediaPlaybackSession_Position) property may not be precisely accurate. Apps that need a frame-accurate position value, such as media editors, should call [**MediaPlayer.StepForwardOneFrame**](https://docs.microsoft.com/en-us/uwp/api/windows.media.playback.mediaplayer#Windows_Media_Playback_MediaPlayer_StepForwardOneFrame) immediately after calling **Pause** before reading the **Position** value.

## -examples

## -see-also
