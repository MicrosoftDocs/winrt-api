---
-api-id: M:Windows.Foundation.Diagnostics.LoggingChannel.StartActivity(System.String,Windows.Foundation.Diagnostics.LoggingFields,Windows.Foundation.Diagnostics.LoggingLevel,Windows.Foundation.Diagnostics.LoggingOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Diagnostics.LoggingActivity StartActivity(System.String startEventName, Windows.Foundation.Diagnostics.LoggingFields fields, Windows.Foundation.Diagnostics.LoggingLevel level, Windows.Foundation.Diagnostics.LoggingOptions options)
-->

# Windows.Foundation.Diagnostics.LoggingChannel.StartActivity

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
Returns an object that represents the new activity.

## -remarks
If you provide *options*, **LoggingOptions.ActivityId** and **LoggingOptions.Opcode** are ignored because the new LoggingActivity object's options will be set as follows:

The **Id** is automatically generated.

The **opcode** is set to **LoggingOptions.Opcode.Start**

## -examples

## -see-also
[StartActivity(String)](loggingchannel_startactivity_1851321502.md), [StartActivity(String, LoggingFields)](loggingchannel_startactivity_2067413660.md), [StartActivity(String, LoggingFields, LoggingLevel)](loggingchannel_startactivity_1799218284.md)