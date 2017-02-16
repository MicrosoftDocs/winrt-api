---
-api-id: E:Windows.Foundation.Diagnostics.LoggingChannel.LoggingEnabled
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler LoggingEnabled<Windows.Foundation.Diagnostics.ILoggingChannel,  object>
-->

# Windows.Foundation.Diagnostics.LoggingChannel.LoggingEnabled

## -description
Raised when the logging channel is attached to a [LoggingSession](loggingsession.md) or other event tracing and debugging tools.

## -remarks
The [LoggingEnabled](loggingchannel_loggingenabled.md) event is raised when a channel is consumed by a session within the app's process, or by a kernel-mode ETW session started with a debugging or performance analysis tool.

## -examples

## -see-also
[LoggingSession](loggingsession.md)