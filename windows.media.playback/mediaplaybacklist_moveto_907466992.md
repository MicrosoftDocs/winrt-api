---
-api-id: M:Windows.Media.Playback.MediaPlaybackList.MoveTo(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Playback.MediaPlaybackItem MoveTo(System.UInt32 itemIndex)
-->

# Windows.Media.Playback.MediaPlaybackList.MoveTo

## -description
Changes the current item of the [MediaPlaybackList](mediaplaybacklist.md) to the item with the specified index.

## -parameters
### -param itemIndex
The index of the item to make current.

## -returns
The new current [MediaPlaybackItem](mediaplaybackitem.md).

## -remarks
This current item of the [MediaPlaybackList](mediaplaybacklist.md) can't be changed while a [MediaPlaybackItem](mediaplaybackitem.md) with [CanSkip](mediaplaybackitem_canskip.md) set to false is playing. Attempting to do so will cause an exception to be thrown.

## -examples

## -see-also
