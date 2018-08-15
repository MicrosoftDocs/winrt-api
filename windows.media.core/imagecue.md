---
-api-id: T:Windows.Media.Core.ImageCue
-api-type: winrt class
---

<!-- Class syntax.
public class ImageCue : IMediaCue
-->

# Windows.Media.Core.ImageCue

## -description
Represents a image cue that can be included in a [TimedMetadataTrack](timedmetadatatrack.md).

## -remarks
An **ImageCue** can be added to a [TimedMetadataTrack](timedmetadatatrack.md) with the [AddCue](timedmetadatatrack_addcue_1989081881.md) method. When the cue's start time is reached, the [CueEntered](timedmetadatatrack_cueentered.md) event is raised and you can use the [MediaCueEventArgs](mediacueeventargs.md) passed into the handler to get a copy of the **ImageCue**. 

## -see-also

## -examples

