---
-api-id: P:Windows.Media.Playback.MediaPlaybackList.MaxPrefetchTime
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.TimeSpan> MaxPrefetchTime { get;  set; }
-->

# Windows.Media.Playback.MediaPlaybackList.MaxPrefetchTime

## -description
Gets or sets the maximum prefetch time for [MediaPlaybackItem](mediaplaybackitem.md) objects in the playback list. The prefetch time is the amount of time before an item is expected to begin playing that the system retrieves the item's media content.

## -property-value
The maximum prefetch time for [MediaPlaybackItem](mediaplaybackitem.md) objects in the playback list.

## -remarks

Prefetching allows the system to provide a more seamless playback experience because media content is retrieved before it is needed for playback. Setting a smaller maximum prefetch time can reduce bandwidth usage if the user stops playback before an item begins playing.

## -examples

## -see-also
