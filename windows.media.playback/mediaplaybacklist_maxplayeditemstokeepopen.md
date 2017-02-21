---
-api-id: P:Windows.Media.Playback.MediaPlaybackList.MaxPlayedItemsToKeepOpen
-api-type: winrt property
---

<!-- Property syntax.
public IReference<uint> MaxPlayedItemsToKeepOpen { get;  set; }
-->

# Windows.Media.Playback.MediaPlaybackList.MaxPlayedItemsToKeepOpen

## -description
Gets or sets a value that specifies the number of [MediaPlaybackItem](mediaplaybackitem.md) objects that should be kept open after they have been played. 

## -property-value
A value that specifies the number of [MediaPlaybackItem](mediaplaybackitem.md) objects that should be kept open after they have been played.

## -remarks
Set this value to cause the system to keep the specified number of media playback items open after they have been played so that, if the users navigates backwards through the playback list, the open items can be played immediately without needing to be reopened. The trade off is that the more items that are kept open, the more memory is used by your app, which is especially important to consider with background media playback, where resources are more limited than for a foreground app.

## -see-also

## -examples

