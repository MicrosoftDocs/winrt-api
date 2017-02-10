---
-api-id: M:Windows.Foundation.Diagnostics.FileLoggingSession.AddLoggingChannel(Windows.Foundation.Diagnostics.ILoggingChannel)
-api-type: winrt method
---

<!-- Method syntax
public void AddLoggingChannel(Windows.Foundation.Diagnostics.ILoggingChannel loggingChannel)
-->

# Windows.Foundation.Diagnostics.FileLoggingSession.AddLoggingChannel

## -description
Adds a logging channel to the current logging session.

## -parameters
### -param loggingChannel
The logging channel to add.

## -remarks
The logging level is set to **LoggingLevel.Verbose**. The **LoggingChannel ** will accept all events.

Adding a channel to a session more than once updates the level.

## -examples

## -see-also
[AddLoggingChannel(ILoggingChannel, LoggingLevel)](fileloggingsession_addloggingchannel_1409249414.md)