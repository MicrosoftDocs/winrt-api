---
-api-id: M:Windows.Foundation.Diagnostics.LoggingActivity.StopActivity(System.String,Windows.Foundation.Diagnostics.LoggingFields)
-api-type: winrt method
---

<!-- Method syntax
public void StopActivity(System.String stopEventName, Windows.Foundation.Diagnostics.LoggingFields fields)
-->

# Windows.Foundation.Diagnostics.LoggingActivity.StopActivity

## -description
Marks the activity as closed/disposed and generates a stop event with the specified event name and fields.

## -parameters
### -param stopEventName
The name for this event.

### -param fields
The fields for this event. May be **null**.

## -remarks
Methods that accept a [LoggingFields](loggingfields.md) parameter also accept **null**. A **null** value is semantically equivalent to a newly-constructed or cleared [LoggingFields](loggingfields.md) object and represents an empty payload.

## -examples

## -see-also
[StopActivity(String)](loggingactivity_stopactivity_294925909.md), [StopActivity(String, LoggingFields, LoggingOptions)](loggingactivity_stopactivity_1420206369.md)