---
-api-id: M:Windows.Foundation.Diagnostics.LoggingActivity.LogEvent(System.String,Windows.Foundation.Diagnostics.LoggingFields)
-api-type: winrt method
---

<!-- Method syntax
public void LogEvent(System.String eventName, Windows.Foundation.Diagnostics.LoggingFields fields)
-->

# Windows.Foundation.Diagnostics.LoggingActivity.LogEvent

## -description
Logs an event with the specified name and fields.

## -parameters
### -param eventName
The name for this event.

### -param fields
The fields for this event. May be **null**.

## -remarks
The level is set to **LoggingLevel.Verbose**.

Methods that accept a [LoggingFields](loggingfields.md) parameter also accept **null**. A **null** value is semantically equivalent to a newly-constructed or cleared [LoggingFields](loggingfields.md) object and represents an empty payload.

## -examples

## -see-also
[LogEvent(String)](loggingactivity_logevent_1783961521.md), [LogEvent(String, LoggingFields, LoggingLevel)](loggingactivity_logevent_1865424709.md), [LogEvent(String, LoggingFields, LoggingLevel, LoggingOptions)](loggingactivity_logevent_812606037.md)