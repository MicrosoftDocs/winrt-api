---
-api-id: T:Windows.Media.Core.DataCue
-api-type: winrt class
---

<!-- Class syntax.
public class DataCue : Windows.Media.Core.IDataCue, Windows.Media.Core.IDataCue2, Windows.Media.Core.IMediaCue
-->

# Windows.Media.Core.DataCue

## -description
Represents a data cue that can be included in a [TimedMetadataTrack](timedmetadatatrack.md).

## -remarks
A **DataCue** can be added to a [TimedMetadataTrack](timedmetadatatrack.md) with the [AddCue](timedmetadatatrack_addcue_1989081881.md) method. When the cue's start time is reached, the [CueEntered](timedmetadatatrack_cueentered.md) event is raised and you can use the [MediaCueEventArgs](mediacueeventargs.md) passed into the handler to get a copy of the **DataCue**. The [Data](datacue_data.md) property of **DataCue** is an [IBuffer](../windows.storage.streams/ibuffer.md) that can contain any type of data. If you want to display text when the cue is encountered, the [TimedTextCue](timedtextcue.md) class is provided for this scenario.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Properties |

## -examples

## -see-also
[IMediaCue](imediacue.md)
