---
-api-id: P:Windows.Media.Streaming.Adaptive.AdaptiveMediaSource.MaxSeekableWindowSize
-api-type: winrt property
---

<!-- Property syntax.
public IReference<TimeSpan> MaxSeekableWindowSize { get; }
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSource.MaxSeekableWindowSize

## -description
Gets the maximum time window time window within which the user can seek within the streaming media. 

## -property-value
The maximum time window time window within which the user can seek within the streaming media. 

## -remarks
This time window is calculated by taking the total duration of media that has been downloaded and subtracting the value of the [DesiredLiveOffset](adaptivemediasource_desiredliveoffset.md) property. This value is specified by the media content.

## -see-also

## -examples

