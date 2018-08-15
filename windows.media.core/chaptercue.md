---
-api-id: T:Windows.Media.Core.ChapterCue
-api-type: winrt class
---

<!-- Class syntax.
public class ChapterCue : IMediaCue
-->

# Windows.Media.Core.ChapterCue

## -description
Represents a chapter cue that can be included in a [TimedMetadataTrack](timedmetadatatrack.md).

## -remarks
A **ChapterCue** can be added to a [TimedMetadataTrack](timedmetadatatrack.md) with the [AddCue](timedmetadatatrack_addcue_1989081881.md) method. When the cue's start time is reached, the [CueEntered](timedmetadatatrack_cueentered.md) event is raised and you can use the [MediaCueEventArgs](mediacueeventargs.md) passed into the handler to get a copy of the **ChapterCue**. 

## -see-also

## -examples

