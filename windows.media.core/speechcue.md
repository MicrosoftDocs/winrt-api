---
-api-id: T:Windows.Media.Core.SpeechCue
-api-type: winrt class
---

<!-- Class syntax.
public class SpeechCue : IMediaCue
-->

# Windows.Media.Core.SpeechCue

## -description
Represents a speech cue that can be included in a [TimedMetadataTrack](timedmetadatatrack.md). This cue can be used to receive events based on metadata included in a text-to-speech (TTS) stream, such as word boundaries, sentence boundaries, and Speech Sythesis Markup Language (SSML) bookmarks. 

## -remarks
A **SpeechCue** can be added to a [TimedMetadataTrack](timedmetadatatrack.md) with the [AddCue](timedmetadatatrack_addcue.md) method. When the cue's start time is reached, the [CueEntered](timedmetadatatrack_cueentered.md) event is raised and you can use the [MediaCueEventArgs](mediacueeventargs.md) passed into the handler to get a copy of the **SpeechCue**. 

The [SpeechSynthesizer](./windows.media.speechsynthesis/speechsynthesizer.md) class generates metadata that uses the following values for the [TimedMetataTrack.Label](timedmetadatatrack_label.md) in order to identify the type of speech metadata included in a track.

<table>
<tr><th>Label</th><th>Description</th></tr>
<tr><td>SpeechBookmark</td><td>The metadata track contains SSML bookmarks.</td></tr>
<tr><td>SpeechSentence</td><td>The metadata track contains sentence boundaries.</td></tr>
<tr><td>SpeechWord</td><td>The metadata track contains word boundaries.</td></tr>
</table>

## -see-also

## -examples

