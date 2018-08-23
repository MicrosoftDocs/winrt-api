---
-api-id: E:Windows.Foundation.Diagnostics.FileLoggingSession.LogFileGenerated
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler LogFileGenerated<Windows.Foundation.Diagnostics.IFileLoggingSession,  Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs>
-->

# Windows.Foundation.Diagnostics.FileLoggingSession.LogFileGenerated

## -description
Raised when a log file is saved.

## -remarks
If no handler is registered for this event, log files will accumulate in the ApplicationData folder.

This event is raised when the session rolls over from one log file to the next. If the file needs to be preserved, your handler must move the file to a new location before returning. The FileLoggingSession might delete or overwrite the file anytime after your handler has returned.

When you register a handler for this event, if log files had been saved while there was no handler registered for this event, your newly-added handler will immediately be invoked once for each of the previously-saved log files.

Your handler must do any processing necessary to preserve the file.

This event is not raised for the last log file because the last log file does not roll over. Use [CloseAndSaveToFileAsync](fileloggingsession_closeandsavetofileasync_867561099.md) to access the last log file.

## -examples

## -see-also
