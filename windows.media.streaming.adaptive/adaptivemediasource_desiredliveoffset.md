---
-api-id: P:Windows.Media.Streaming.Adaptive.AdaptiveMediaSource.DesiredLiveOffset
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan DesiredLiveOffset { get;  set; }
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSource.DesiredLiveOffset

## -description
Gets or sets the desired offset of live playback from the end of the known media content that has been downloaded.

## -property-value
The desired offset for the live playback of the streaming media. This value must be greater than [MinLiveOffset](adaptivemediasource_minliveoffset.md). If the specified value is less than the minimum value, it is automatically clamped to the allowed range.

## -remarks

## -examples

## -see-also
[AdaptiveMediaSource](adaptivemediasource.md)