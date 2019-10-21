---
-api-id: M:Windows.Media.AppRecording.AppRecordingManager.RecordTimeSpanToFileAsync(Windows.Foundation.DateTime,Windows.Foundation.TimeSpan,Windows.Storage.StorageFile)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppRecordingResult> AppRecordingManager.RecordTimeSpanToFileAsync(DateTime startTime, TimeSpan duration, StorageFile file)
-->

# Windows.Media.AppRecording.AppRecordingManager.RecordTimeSpanToFileAsync

## -description
Writes audio and video content of the current app from the historical buffer, with a time range defined by the specified start time and duration, to the specified destination file.

## -parameters
### -param startTime
The time at which the content to be recorded started. This value must be within the duration of the historical buffer, which can be determined by calling [AppRecordingManager.GetStatus](apprecordingmanager_getstatus_169641651.md) and then checking the value of the [AppRecordingStatus.HistoricalBufferDuration](apprecordingstatus_historicalbufferduration.md) property.

### -param duration
The requested duration of the app recording. An app recording can succeed, but record a shorter duration than specified with this parameter if the allocated storage for recordings is reached. To determine the duration of the file that was actually recorded, check the value [AppRecordingResult.Duration](apprecordingresult_duration.md) property of the object returned from this operation.

### -param file
The file to which the recorded media is written.

## -returns
An asynchronous operation that returns an [AppRecordingResult](C:\Users\drewbat\Source\Repos\winrt-api\windows.media.apprecording\apprecordingresult.md) object upon completion, which contains information about the status of the recording operation.

## -remarks
The stored file containing the app recording is created as an MP4 with h.264 video and AAC audio. Video files recorded using **AppRecordingManager** are not ingested into first-party experiences like GameDVR or the XBox app.

Before calling this method, call GetStatus and check the value of the [CanRecordTimeSpan](apprecordingstatus_canrecordtimespan.md) to determine if the current app is currently able to make a time span recording.

Use [StartRecordingToFileAsync](apprecordingmanager_startrecordingtofileasync_706691331.md) to begin an app recording at the current time.

## -see-also

## -examples

