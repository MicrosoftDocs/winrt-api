---
-api-id: T:Windows.Foundation.Diagnostics.LoggingLevel
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Foundation.Diagnostics.LoggingLevel : int
-->

# LoggingLevel

## -description
Specifies the severity level of an event.

## -enum-fields
### -field Verbose:0
Log all messages.

### -field Information:1
Log messages of information level and higher.

### -field Warning:2
Log messages of warning level and higher.

### -field Error:3
Log messages of error level and higher.

### -field Critical:4
Log only critical messages.


## -remarks
When writing events, for example from [LoggingChannel](loggingchannel.md), the  is the severity of the event.

When controlling the event logger, for example from [LoggingSession](loggingsession.md), only events that meet the minimum severity specified by  is are logged.

## -examples

## -see-also
[LoggingChannel](loggingchannel.md), [LoggingSession](loggingsession.md)