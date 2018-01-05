---
-api-id: P:Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadCompletedEventArgs.ResourceDuration
-api-type: winrt property
---

<!-- Property syntax.
public IReference<TimeSpan> ResourceDuration { get; }
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadCompletedEventArgs.ResourceDuration

## -description
Gets a [TimeSpan](../windows.foundation/timespan.md) representing the duration of the resource associated with the event.

## -property-value
The duration of the resource associated with the event.

## -remarks
This value only applies to content with a [ResourceType](adaptivemediasourcedownloadcompletedeventargs_resourcetype.md) of **MediaSegment** and is optional. The property will be set if the value is found in the DASH manifest.


## -see-also

## -examples

