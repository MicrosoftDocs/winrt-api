---
-api-id: P:Windows.Media.Playback.MediaPlaybackItem.IsDisabledInPlaybackList
-api-type: winrt property
---

<!-- Property syntax.
public bool IsDisabledInPlaybackList { get;  set; }
-->

# Windows.Media.Playback.MediaPlaybackItem.IsDisabledInPlaybackList

## -description
Gets or sets a value that specifies whether a [MediaPlaybackItem](mediaplaybackitem.md) is disabled in a [MediaPlaybackList](mediaplaybacklist.md).

## -property-value
True if the media playback item is disabled in the playback list; otherwise, false.

## -remarks
A example scenario for using this property is when network connectivity is lost, your app can check the [TotalDownloadProgress](mediaplaybackitem_totaldownloadprogress.md) property to see which items in the playback list have completed downloading. For items that have not completed, set **IsDisabledInPlaybackList** to true so that the item won't be played in the list.

Note that after playback of an item has begun, setting the **IsDisabledInPlaybackList** property has no effect.

## -see-also

## -examples

