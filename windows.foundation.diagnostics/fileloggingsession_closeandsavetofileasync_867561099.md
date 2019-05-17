---
-api-id: M:Windows.Foundation.Diagnostics.FileLoggingSession.CloseAndSaveToFileAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CloseAndSaveToFileAsync()
-->

# Windows.Foundation.Diagnostics.FileLoggingSession.CloseAndSaveToFileAsync

## -description
Ends the current logging session and saves it to a file.

## -returns
When this method completes, it returns the new file as a [StorageFile](../windows.storage/storagefile.md). Returns **NULL** if there are no events in the session or if logging has just rolled over into a new file that doesn't contain events yet.

## -remarks
FileLoggingSession.CloseAndSaveToFileAsync closes the current logging session. If there is a handler for the [LogFileGenerated](fileloggingsession_logfilegenerated.md) method, and it has been called but not returned, the function waits for the handler to return. If there is any data in the current log file that has not already been reported with the [LogFileGenerated](fileloggingsession_logfilegenerated.md) event, the function returns a [StorageFile](../windows.storage/storagefile.md) representing that file.

Otherwise, the function returns **NULL**. This can happen if the current log file is empty, or if all log files have already been reported via the [LogFileGenerated](fileloggingsession_logfilegenerated.md) event. Note that CloseAndSaveToFileAsync might return **NULL** even if data was recorded and even if there is no [LogFileGenerated](fileloggingsession_logfilegenerated.md) event. This can happen if the log file became full and was closed, and a new log file was opened immediately before CloseAndSaveToFileAsync was called.

This function is equivalent to [FileLoggingSession.Close](fileloggingsession_close_811482585.md).



## -examples

## -see-also
