---
-api-id: M:Windows.Foundation.Diagnostics.LoggingActivity.IsEnabled(Windows.Foundation.Diagnostics.LoggingLevel)
-api-type: winrt method
---

<!-- Method syntax
public bool IsEnabled(Windows.Foundation.Diagnostics.LoggingLevel level)
-->

# Windows.Foundation.Diagnostics.LoggingActivity.IsEnabled

## -description
Indicates whether at least one session is listening for events with the specified event severity level from the channel associated with this activity.

## -parameters
### -param level
The event severity level.

## -returns
Returns **true** if at least one session is listening for events with the specified level from the channel associated with this activity, and otherwise **false**.

## -remarks
This function is equivalent to [LoggingChannel.IsEnabled(level)](loggingchannel_isenabled_826472551.md).

## -examples

## -see-also
[IsEnabled](loggingactivity_isenabled_180154405.md), [IsEnabled(LoggingLevel, Int64)](loggingactivity_isenabled_1519006295.md)