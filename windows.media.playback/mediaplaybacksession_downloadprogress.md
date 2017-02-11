---
-api-id: P:Windows.Media.Playback.MediaPlaybackSession.DownloadProgress
-api-type: winrt property
---

<!-- Property syntax
public double DownloadProgress { get; }
-->

# Windows.Media.Playback.MediaPlaybackSession.DownloadProgress

## -description
Gets a value indicating the position after the current playback [Position](mediaplaybacksession_position.md) to which downloading has completed and content is buffered.

## -property-value
A value indicating the position after the current playback [Position](mediaplaybacksession_position.md) to which downloading has completed and content is buffered. The value ranges from 0 to 1. Multiply by 100 to obtain a percentage.

## -remarks
This value is expressed as a value between 0 and 1 where 0 is the beginning of the content and 1 is the entire duration of the content. Your app can assume that content is currently buffered between the current playback position and the position provided by this property. Content before the current playback position may or may not be buffered currently.

## -examples

## -see-also
