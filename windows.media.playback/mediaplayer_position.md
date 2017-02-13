---
-api-id: P:Windows.Media.Playback.MediaPlayer.Position
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan Position { get;  set; }
-->

# Windows.Media.Playback.MediaPlayer.Position

## -description
Gets or sets the playback position within the media. 

> [!NOTE]
> **MediaPlayer.Position** may be altered or unavailable after Windows 10, version 1607. Instead, use the [MediaPlayer.PlaybackSession](mediaplayer_playbacksession.md) property to get a [MediaPlaybackSession](mediaplaybacksession.md) object and then use the [MediaPlaybackSession.Position](mediaplaybacksession_position.md) property.

## -property-value
The playback position within the media.

## -remarks
The position can't be moved forward while a [MediaPlaybackItem](mediaplaybackitem.md) with [CanSkip](mediaplaybackitem_canskip.md) set to false is playing. Attempting to do so will cause an exception to be thrown.

## -examples

## -see-also
