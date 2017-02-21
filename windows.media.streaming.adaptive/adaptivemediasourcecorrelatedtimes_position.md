---
-api-id: P:Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceCorrelatedTimes.Position
-api-type: winrt property
---

<!-- Property syntax.
public IReference<TimeSpan> Position { get; }
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceCorrelatedTimes.Position

## -description
Gets a timespan representing the current playback position of the media player that is playing the content.

## -property-value
A timespan representing the current playback position of the media player that is playing the content.

## -remarks
The position value is a snapshot made when [AdaptiveMediaSource.GetCorrelatedTimes](adaptivemediasource_getcorrelatedtimes_1896702992.md) is called. So if the presentation clock is advancing, the value of this property may be slightly offset from the current presentation time.

## -see-also

## -examples

