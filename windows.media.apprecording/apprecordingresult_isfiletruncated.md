---
-api-id: P:Windows.Media.AppRecording.AppRecordingResult.IsFileTruncated
-api-type: winrt property
---

<!-- Property syntax.
public bool IsFileTruncated { get; }
-->

# Windows.Media.AppRecording.AppRecordingResult.IsFileTruncated

## -description
Gets a value that indicates if the saved app recording was truncated.

## -property-value
True if the file was truncated; otherwise, false.

## -remarks
[RecordTimeSpanToFileAsync](apprecordingmanager_recordtimespantofileasync_583577299.md) allows you to specify a requested duration for the app recording, but it is possible a recording to complete successfully, but for a shorter duration than requested, such as if the allocated storage space for recordings is filled. Check the value of the [Duration](apprecordingresult_duration.md) property to determine the actual duration of the recorded file.

## -see-also

## -examples

