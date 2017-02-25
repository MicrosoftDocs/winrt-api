---
-api-id: M:Windows.Media.Playback.MediaPlaybackSession.IsSupportedPlaybackRateRange(System.Double,System.Double)
-api-type: winrt method
---

<!-- Method syntax.
public bool MediaPlaybackSession.IsSupportedPlaybackRateRange(Double rate1, Double rate2)
-->

# Windows.Media.Playback.MediaPlaybackSession.IsSupportedPlaybackRateRange

## -description
Gets a value indicating whether the specified range of playback rates is supported.

## -parameters

### -param rate1
The lower bound of the playback rate range for which support is queried.

### -param rate2
The upper bound of the playback rate range for which support is queried.

## -returns
True if the playback range is supported; otherwise, false.

## -remarks
Playback rates are expressed as a ratio of the specified rate to the normal playback rate, so 2.0 is twice as fast as normal and .5 is half as fast as normal. You can use this method to see if slow motion playback is supported by testing the range (0, 1), or you can see if reverse playback is supported by testing the range (-1, 0). You can also test to see if a specific rate is supported by using the same value for both bounds, such as (2, 2) for double-speed playback or (4, 4) for four times the normal playback speed.

## -see-also

## -examples

