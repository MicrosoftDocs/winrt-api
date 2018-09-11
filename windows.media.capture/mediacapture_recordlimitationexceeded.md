---
-api-id: E:Windows.Media.Capture.MediaCapture.RecordLimitationExceeded
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Media.Capture.RecordLimitationExceededEventHandler RecordLimitationExceeded
-->

# Windows.Media.Capture.MediaCapture.RecordLimitationExceeded

## -description
Occurs when the record limit is exceeded.

## -remarks
If an app receives a [RecordLimitationExceeded](mediacapture_recordlimitationexceeded.md) event, it is expected to finalize the file it is recording. If it does not finalize, the capture engine will stop sending samples to the file that the app was recording to.

In the current release, the record limit is three hours.

## -examples

## -see-also
[StartRecordToStorageFileAsync](mediacapture_startrecordtostoragefileasync_1923577468.md)
## -capabilities
backgroundMediaRecording
