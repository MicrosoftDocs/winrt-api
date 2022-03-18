---
-api-id: T:Windows.Foundation.Diagnostics.LoggingSession
-api-type: winrt class
---

<!-- Class syntax.
public class LoggingSession : Windows.Foundation.Diagnostics.ILoggingSession, Windows.Foundation.IClosable
-->

# Windows.Foundation.Diagnostics.LoggingSession

## -description

Represents the destination of logged messages from [LoggingChannel](loggingchannel.md) instances.

## -remarks

Use the LoggingSession class to log messages and data to an in-memory circular buffer as your app runs. Use the [SaveToFileAsync](loggingsession_savetofileasync_705962807.md) method to save the buffer to a file. You can view the log files by using the Windows Performance Toolkit (WPT) and other utilities like tracerpt.exe.

LoggingSession instances keep logged messages in memory until the [SaveToFileAsync](loggingsession_savetofileasync_705962807.md) method is called. This enables on-demand saving of events until the app saves the in-memory messages.

Add [LoggingChannel](loggingchannel.md) instances to a LoggingSession, and call LoggingSession instance methods to remove channels, dispose, and perform other operations.

LoggingSession records the most recent 260KB of events, after which it will begin overwriting older events.

You cannot have more than one session with the same name. In addition, each app is limited to 4 sessions total.

## -examples

## -see-also

[LoggingChannel](loggingchannel.md), [ILoggingSession](iloggingsession.md), [IClosable](../windows.foundation/iclosable.md), [Logging sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Logging)
