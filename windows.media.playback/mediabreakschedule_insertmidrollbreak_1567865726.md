---
-api-id: M:Windows.Media.Playback.MediaBreakSchedule.InsertMidrollBreak(Windows.Media.Playback.MediaBreak)
-api-type: winrt method
---

<!-- Method syntax
public void InsertMidrollBreak(Windows.Media.Playback.MediaBreak mediaBreak)
-->

# Windows.Media.Playback.MediaBreakSchedule.InsertMidrollBreak

## -description
Adds a [MediaBreak](mediabreak.md) to the schedule that will be played at a point during the playback of the [MediaPlaybackItem](mediaplaybackitem.md) with which the [MediaBreakSchedule](mediabreakschedule.md) is associated.

## -parameters
### -param mediaBreak
The [MediaBreak](mediabreak.md) to add to the schedule.

## -remarks
Remove a midroll break by calling [RemoveMidrollBreak](mediabreakschedule_removemidrollbreak_1073766102.md).

Access the current list of midroll media breaks in the schedule with the [MidrollBreaks](mediabreakschedule_midrollbreaks.md) property.

If you want a **MediaBreak** to be played before the associated [MediaPlaybackItem](mediaplaybackitem.md) plays, assign it to the [PrerollBreak](mediabreakschedule_prerollbreak.md) property. If you want a **MediaBreak** to be played after the associated [MediaPlaybackItem](mediaplaybackitem.md) plays, assign it to the [PostrollBreak](mediabreakschedule_postrollbreak.md) property.

## -examples

## -see-also
