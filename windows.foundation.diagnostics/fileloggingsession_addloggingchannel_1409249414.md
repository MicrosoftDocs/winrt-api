---
-api-id: M:Windows.Foundation.Diagnostics.FileLoggingSession.AddLoggingChannel(Windows.Foundation.Diagnostics.ILoggingChannel,Windows.Foundation.Diagnostics.LoggingLevel)
-api-type: winrt method
---

<!-- Method syntax
public void AddLoggingChannel(Windows.Foundation.Diagnostics.ILoggingChannel loggingChannel, Windows.Foundation.Diagnostics.LoggingLevel maxLevel)
-->

# Windows.Foundation.Diagnostics.FileLoggingSession.AddLoggingChannel

## -description
Adds a logging channel to the current logging session. The logging channel only accepts events that have a logging level at or above the specified logging level.

## -parameters
### -param loggingChannel
The logging channel to add.

### -param maxLevel
The *minimum* logging level that an event must have to be accepted by the session.

## -remarks
*maxLevel* specifies the which events from the channel the session will accept and which are ignored. It does not change the level of the channel itself.

## -examples

## -see-also
[AddLoggingChannel(ILoggingChannel)](fileloggingsession_addloggingchannel_604200962.md)