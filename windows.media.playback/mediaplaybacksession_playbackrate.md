---
-api-id: P:Windows.Media.Playback.MediaPlaybackSession.PlaybackRate
-api-type: winrt property
---

<!-- Property syntax
public double PlaybackRate { get;  set; }
-->

# Windows.Media.Playback.MediaPlaybackSession.PlaybackRate

## -description
Gets or sets a value representing the current playback rate for the [MediaPlaybackSession](mediaplaybacksession.md).

## -property-value
The current playback rate for the [MediaPlaybackSession](mediaplaybacksession.md).

## -remarks
This value is expressed as a percentage. For example, a value of 1.5 sets the playback rate to 150% of the original.

The playback rate can't be set to a value greater than 1.0 while a [MediaPlaybackItem](mediaplaybackitem.md) with [CanSkip](mediaplaybackitem_canskip.md) set to false is playing. Attempting to do so will cause an exception to be thrown.

## -examples

## -see-also
