---
-api-id: P:Windows.Media.Playback.MediaPlayer.PlaybackRate
-api-type: winrt property
---

<!-- Property syntax
public double PlaybackRate { get;  set; }
-->

# Windows.Media.Playback.MediaPlayer.PlaybackRate

## -description
Gets or sets the playback rate, expressed as a ratio. 

> [!NOTE]
> **MediaPlayer.PlaybackRate** may be altered or unavailable after Windows 10, version 1607. Instead, use the [MediaPlayer.PlaybackSession](mediaplayer_playbacksession.md) property to get a [MediaPlaybackSession](mediaplaybacksession.md) object and then use the [MediaPlaybackSession.PlaybackRate](mediaplaybacksession_playbackrate.md) property.

## -property-value
The playback rate, expressed as a ratio.

## -remarks
This value is expressed as a ratio of the desired playback speed to normal playback speed. For example, a value of 1.5 sets the playback rate to 150% of the original.

The playback rate can't be set to a value greater than 1.0 while a [MediaPlaybackItem](mediaplaybackitem.md) with [CanSkip](mediaplaybackitem_canskip.md) set to false is playing. Attempting to do so will cause an exception to be thrown.

## -examples

## -see-also
