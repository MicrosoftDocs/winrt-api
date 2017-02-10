---
-api-id: M:Windows.Foundation.Diagnostics.LoggingSession.AddLoggingChannel(Windows.Foundation.Diagnostics.ILoggingChannel,Windows.Foundation.Diagnostics.LoggingLevel)
-api-type: winrt method
---

<!-- Method syntax
public void AddLoggingChannel(Windows.Foundation.Diagnostics.ILoggingChannel loggingChannel, Windows.Foundation.Diagnostics.LoggingLevel maxLevel)
-->

# Windows.Foundation.Diagnostics.LoggingSession.AddLoggingChannel

## -description
Adds a logging channel with the specified logging level to the current logging session.

## -parameters
### -param loggingChannel
The logging channel to add.

### -param maxLevel
The logging level for *loggingChannel*.

## -remarks
You can also use this function to change the level at which a channel is added to a session; to do so, call **AddLoggingChannel**, using the existing logging channel, but with the updated level.

## -examples

## -see-also
[LoggingChannel](loggingchannel.md), [AddLoggingChannel(ILoggingChannel)](loggingsession_addloggingchannel_604200962.md)