---
-api-id: P:Windows.Media.Playback.MediaPlayer.BufferingProgress
-api-type: winrt property
---

<!-- Property syntax
public double BufferingProgress { get; }
-->

# Windows.Media.Playback.MediaPlayer.BufferingProgress

## -description
Gets the amount of buffering that is completed for the media content, expressed as a percentage.

> [!NOTE]
> **MediaPlayer.BufferingProgress** may be altered or unavailable after Windows 10, version 1607. Instead, use the [MediaPlayer.PlaybackSession](mediaplayer_playbacksession.md) property to get a [MediaPlaybackSession](mediaplaybacksession.md) object and then use the [MediaPlaybackSession.BufferingProgress](mediaplaybacksession_bufferingprogress.md) property.

## -property-value
The amount of buffering that is completed for the media content.

## -remarks
The value ranges from 0 to 1. Multiply by 100 to obtain a percentage. The default value is 0.

## -examples

## -see-also
