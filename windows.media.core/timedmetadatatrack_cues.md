---
-api-id: P:Windows.Media.Core.TimedMetadataTrack.Cues
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.Core.IMediaCue> Cues { get; }
-->

# Windows.Media.Core.TimedMetadataTrack.Cues

## -description
Gets a read-only list of the media cues in the [TimedMetadataTrack](timedmetadatatrack.md).

## -property-value
A read-only list of the media cues in the timed metadata track.

## -remarks
Add cues to the list by calling [AddCue](timedmetadatatrack_addcue.md).

The cues in the list are sorted in chronological order by the value of the [StartTime](imediacue_starttime.md) property.

## -examples

## -see-also
