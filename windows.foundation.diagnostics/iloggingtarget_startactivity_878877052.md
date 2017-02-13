---
-api-id: M:Windows.Foundation.Diagnostics.ILoggingTarget.StartActivity(System.String,Windows.Foundation.Diagnostics.LoggingFields,Windows.Foundation.Diagnostics.LoggingLevel,Windows.Foundation.Diagnostics.LoggingOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Diagnostics.LoggingActivity StartActivity(System.String startEventName, Windows.Foundation.Diagnostics.LoggingFields fields, Windows.Foundation.Diagnostics.LoggingLevel level, Windows.Foundation.Diagnostics.LoggingOptions options)
-->

# Windows.Foundation.Diagnostics.ILoggingTarget.StartActivity

## -description
Writes an activity start event with the specified fields, level, and options, and creates a **LoggingActivity** object.

## -parameters
### -param startEventName
The name for this event.

### -param fields
The fields for this event. May be **null**.

### -param level
The level of detail for this event.

### -param options
The options for this event. Pass **null** to use the default options. The options are for advanced scenarios. The default values are designed to work well for most events.

## -returns
An object that represents the new activity.

## -remarks

## -examples

## -see-also
[StartActivity(String)](iloggingtarget_startactivity_1851321502.md), [StartActivity(String, LoggingFields)](iloggingtarget_startactivity_2067413660.md), [StartActivity(String, LoggingFields, LoggingLevel)](iloggingtarget_startactivity_1799218284.md)