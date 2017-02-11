---
-api-id: M:Windows.Foundation.Diagnostics.LoggingActivity.LogEvent(System.String,Windows.Foundation.Diagnostics.LoggingFields,Windows.Foundation.Diagnostics.LoggingLevel,Windows.Foundation.Diagnostics.LoggingOptions)
-api-type: winrt method
---

<!-- Method syntax
public void LogEvent(System.String eventName, Windows.Foundation.Diagnostics.LoggingFields fields, Windows.Foundation.Diagnostics.LoggingLevel level, Windows.Foundation.Diagnostics.LoggingOptions options)
-->

# Windows.Foundation.Diagnostics.LoggingActivity.LogEvent

## -description
Logs an event with the specified name, fields, level, and options.

## -parameters
### -param eventName
The name for this event.

### -param fields
The fields for this event. May be **null**.

### -param level
The severity level for this event.

### -param options
The options for this event. Pass **null** to use the default options. The options are for advanced scenarios. The default values are designed to work well for most events.

## -remarks
If you provide *options*,**LoggingOptions.ActivityId** and **LoggingOptions.RelatedActivityId** are ignored because the activity object automatically manages these values for the event.

*eventName* should not be used as a payload field. For example, use `LogEvent(“MyEvent”, fieldsWithStringData)` instead of `LogEvent(stringData)`.

## -examples

## -see-also
[LogEvent(String)](loggingactivity_logevent_1783961521.md), [LogEvent(String, LoggingFields)](loggingactivity_logevent_2134360499.md), [LogEvent(String, LoggingFields, LoggingLevel)](loggingactivity_logevent_1865424709.md)