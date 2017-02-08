---
-api-id: M:Windows.Foundation.Diagnostics.LoggingActivity.StopActivity(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void StopActivity(System.String stopEventName)
-->

# Windows.Foundation.Diagnostics.LoggingActivity.StopActivity

## -description
Marks the activity as closed/disposed and generates a stop event with the specified event name.

## -parameters
### -param stopEventName
The name for the stop event.

## -remarks
The level for this event is the same as the level specified for the start event.

This function will fail if the activity has already been closed or disposed.

## -examples

## -see-also
[StopActivity(String, LoggingFields)](loggingactivity_stopactivity_83288151.md), [StopActivity(String, LoggingFields, LoggingOptions)](loggingactivity_stopactivity_1420206369.md)