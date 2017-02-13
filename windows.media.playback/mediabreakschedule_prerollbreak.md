---
-api-id: P:Windows.Media.Playback.MediaBreakSchedule.PrerollBreak
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Playback.MediaBreak PrerollBreak { get;  set; }
-->

# Windows.Media.Playback.MediaBreakSchedule.PrerollBreak

## -description
Gets or sets the [MediaBreak](mediabreak.md) to be played before the [MediaPlaybackItem](mediaplaybackitem.md) associated with the [MediaBreakSchedule](mediabreakschedule.md) plays.

## -property-value
The [MediaBreak](mediabreak.md) to be played before the [MediaPlaybackItem](mediaplaybackitem.md) associated with the [MediaBreakSchedule](mediabreakschedule.md) plays.

## -remarks
If you want a **MediaBreak** to be played after the associated [MediaPlaybackItem](mediaplaybackitem.md) plays, assign it to the [PostrollBreak](mediabreakschedule_postrollbreak.md) property. If you want a **MediaBreak** to play at a point during the playback of the associated **MediaPlaybackItem**, use the [InsertMidrollBreak](mediabreakschedule_insertmidrollbreak.md) method.

## -examples

## -see-also
