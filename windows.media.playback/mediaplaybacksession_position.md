---
-api-id: P:Windows.Media.Playback.MediaPlaybackSession.Position
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan Position { get;  set; }
-->

# Windows.Media.Playback.MediaPlaybackSession.Position

## -description
Gets or sets the current playback position within the currently playing media.

## -property-value
The current playback position within the currently playing media.

## -remarks
Note that after you call [MediaPlayer.Pause](/uwp/api/windows.media.playback.mediaplayer.Pause), the time represented by the **Position** property may not be precisely accurate. Apps that need a frame-accurate position value, such as media editors, should call [MediaPlayer.StepForwardOneFrame](/uwp/api/windows.media.playback.mediaplayer.StepForwardOneFrame) immediately after calling **Pause** before reading the **Position** value.

## -examples

## -see-also
