---
-api-id: M:Windows.Foundation.Diagnostics.LoggingActivity.IsEnabled(Windows.Foundation.Diagnostics.LoggingLevel,System.Int64)
-api-type: winrt method
---

<!-- Method syntax
public bool IsEnabled(Windows.Foundation.Diagnostics.LoggingLevel level, System.Int64 keywords)
-->

# Windows.Foundation.Diagnostics.LoggingActivity.IsEnabled

## -description
Indicates whether at least one session is listening for events with the specified level and keywords from the channel associated with this activity.

## -parameters
### -param level
The event severity level.

### -param keywords
The keywords. Each bit of the keywords value represents an event category.

## -returns
Returns **true** if at least one session is listening for events with the specified level and keywords from the channel associated with this activity, and otherwise **false**.

## -remarks
This function is equivalent to [LoggingChannel.IsEnabled(level, keywords)](loggingchannel_isenabled_1519006295.md).

## -examples

## -see-also
[IsEnabled](loggingactivity_isenabled_180154405.md), [IsEnabled(LoggingLevel)](loggingactivity_isenabled_826472551.md)