---
-api-id: P:Windows.Media.Streaming.Adaptive.AdaptiveMediaSource.DesiredSeekableWindowSize
-api-type: winrt property
---

<!-- Property syntax.
public IReference<TimeSpan> DesiredSeekableWindowSize { get;  set; }
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSource.DesiredSeekableWindowSize

## -description
Gets or sets the requested maximum size of the time window within which the user can seek within the streaming media.

## -property-value
The requested maximum size of the time window in which the user can seek within the streaming media. This value must be between zero and the value of [MaxSeekableWindowSize](adaptivemediasource_maxseekablewindowsize.md). If the specified value is greater than the maximum value, the system automatically clamps to the allowed range, but when you retrieve the property it will return the unclamped value.

## -remarks

## -see-also

## -examples

