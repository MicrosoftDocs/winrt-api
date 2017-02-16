---
-api-id: M:Windows.Foundation.Diagnostics.LoggingChannel.#ctor(System.String)
-api-type: winrt method
---

<!-- Method syntax
public LoggingChannel(System.String name)
-->

# Windows.Foundation.Diagnostics.LoggingChannel.LoggingChannel

## -description
This constructor creates a **LoggingChannel** in Windows 8.1 compatibility mode.

## -parameters
### -param name
The name of the logging channel.

## -remarks
This constructor creates a **LoggingChannel** in Windows 8.1 compatibility mode. For a description of the differences between Windows 8.1 compatibility mode and the new behavior supported by Windows 10, see [LoggingChannel](loggingchannel.md).

> **Windows 10**
> This constructor should only be used if you need compatibility with Windows 8.1. For Windows 10 and later, use [LoggingChannel(String, LoggingChannelOptions)](loggingchannel_loggingchannel_1496214966.md) or [LoggingChannel(String, LoggingChannelOptions, Guid)](loggingchannel_loggingchannel_2599058.md).

## -examples

## -see-also
[LoggingChannel(String, LoggingChannelOptions)](loggingchannel_loggingchannel_1496214966.md), [LoggingChannel(String, LoggingChannelOptions, Guid)](loggingchannel_loggingchannel_2599058.md), [LoggingSession](loggingsession.md), [FileLoggingSession](fileloggingsession.md)