---
-api-id: M:Windows.Foundation.Diagnostics.LoggingActivity.StopActivity(System.String,Windows.Foundation.Diagnostics.LoggingFields,Windows.Foundation.Diagnostics.LoggingOptions)
-api-type: winrt method
---

<!-- Method syntax
public void StopActivity(System.String stopEventName, Windows.Foundation.Diagnostics.LoggingFields fields, Windows.Foundation.Diagnostics.LoggingOptions options)
-->

# Windows.Foundation.Diagnostics.LoggingActivity.StopActivity

## -description
Marks the activity as closed/disposed and generates a stop event with the specified event name, fields, and options.

## -parameters
### -param stopEventName
The name for the stop event.

### -param fields
The fields for this event. May be **null**.

### -param options
The options for this event. Pass **null** to use the default options. The options are for advanced scenarios. The default values are designed to work well for most events.

## -remarks
If you pass *LoggingOptions*:

**LoggingOptions.Keywords** is ignored because the keywords for the stop event are based on the keywords for the start event.

**LoggingOptions.Opcode** is ignored because the opcode is always **LoggingOptions.Stop** for a Stop event.

**LoggingOptions.ActivityId** is ignored because the **Id** from this LoggingActivity is used.

**LoggingOptions.RelatedActivityId** is ignored because it is only used for the start event.

## -examples

## -see-also
[StopActivity(String)](loggingactivity_stopactivity_294925909.md), [StopActivity(String, LoggingFields)](loggingactivity_stopactivity_83288151.md)