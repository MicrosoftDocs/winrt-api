---
-api-id: M:Windows.Foundation.Diagnostics.LoggingActivity.StartActivity(System.String,Windows.Foundation.Diagnostics.LoggingFields)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Diagnostics.LoggingActivity StartActivity(System.String startEventName, Windows.Foundation.Diagnostics.LoggingFields fields)
-->

# Windows.Foundation.Diagnostics.LoggingActivity.StartActivity

## -description
Writes an activity start event with fields and creates a **LoggingActivity** object.

## -parameters
### -param startEventName
The name for the start event.

### -param fields
The fields for this event.

## -returns
An object that represents the new activity.

## -remarks
Methods that accept a [LoggingFields](loggingfields.md) parameter also accept **null**. A **null** value is semantically equivalent to a newly-constructed or cleared [LoggingFields](loggingfields.md) object and represents an empty payload.

## -examples

## -see-also
[StartActivity(String)](loggingactivity_startactivity_1851321502.md), [StartActivity(String, LoggingFields, LoggingLevel)](loggingactivity_startactivity_1799218284.md), [StartActivity(String, LoggingFields, LoggingLevel, LoggingOptions)](loggingactivity_startactivity_878877052.md)