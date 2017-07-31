---
-api-id: P:Windows.Media.AppRecording.AppRecordingResult.Duration
-api-type: winrt property
---

<!-- Property syntax.
public TimeSpan Duration { get; }
-->

# Windows.Media.AppRecording.AppRecordingResult.Duration

## -description
Gets the duration of the recorded file.

## -property-value
The duration of the recorded file.

## -remarks
[**RecordTimeSpanToFileAsync**](apprecordingmanager_recordtimespantofileasync_583577299.md) allows you to specify a requested duration for the app recording, but it is possible a recording to complete successfully, but for a shorter duration than requested, such as if the allocated storage space for recordings is filled. Check the value of the [**IsFileTruncated**](apprecordingresult_isfiletruncated.md) property to determine if the file was truncated.

## -see-also

## -examples

