---
-api-id: T:Windows.Media.Playback.MediaBreakInsertionMethod
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Playback.MediaBreakInsertionMethod : int
-->

# MediaBreakInsertionMethod

## -description
Specifies the method that is used to insert the [MediaBreak](mediabreak.md) playback into the playback of the [MediaPlaybackItem](mediaplaybackitem.md) to which it belongs.

## -enum-fields
### -field Interrupt:0
The main content is paused while the content of the [MediaBreak](mediabreak.md) plays.

### -field Replace:1
The main content is not paused, but is replaced by the content of the [MediaBreak](mediabreak.md).


## -remarks
In a typical implementation, **Interrupt** is used for on-demand content so that none of the content is obscured by the media break, and **Replace** is used for live content so that the content doesn't accumulate a delay while pausing during the media break.

## -examples

## -see-also