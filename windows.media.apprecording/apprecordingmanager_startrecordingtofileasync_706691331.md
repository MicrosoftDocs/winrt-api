---
-api-id: M:Windows.Media.AppRecording.AppRecordingManager.StartRecordingToFileAsync(Windows.Storage.StorageFile)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppRecordingResult> AppRecordingManager.StartRecordingToFileAsync(StorageFile file)
-->

# Windows.Media.AppRecording.AppRecordingManager.StartRecordingToFileAsync

## -description
Writes audio and video content of the current app to the specified destination file, beginning at the current time and ending when the operation is cancelled or storage space has been exceeded.

## -parameters
### -param file
The file to which the recorded media is written.

## -returns
An asynchronous operation that returns an [AppRecordingResult](/uwp/api/windows.media.apprecording.apprecordingresult) object upon completion, which contains information about the status of the recording operation.

Before calling this method, call [GetStatus](apprecordingmanager_recordtimespantofileasync_583577299.md) and check the value of the [CanRecord](apprecordingstatus_canrecord.md) to determine if the current app is currently able to make an app recording.

To end an app recording that was initiated with this method, cancel the operation by calling [Cancel](/uwp/api/windows.foundation.iasyncinfo.Cancel) on the [IAsyncOperation](/uwp/api/windows.foundation.iasyncoperation_tresult_) returned by this method.

## -remarks

## -see-also

## -examples

