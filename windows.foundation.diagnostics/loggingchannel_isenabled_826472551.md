---
-api-id: M:Windows.Foundation.Diagnostics.LoggingChannel.IsEnabled(Windows.Foundation.Diagnostics.LoggingLevel)
-api-type: winrt method
---

<!-- Method syntax
public bool IsEnabled(Windows.Foundation.Diagnostics.LoggingLevel level)
-->

# Windows.Foundation.Diagnostics.LoggingChannel.IsEnabled

## -description
Indicates whether at least one session is listening for events with the specified event severity level from the channel.

## -parameters
### -param level
The event severity level.

## -returns
Returns **true** if at least one session is listening for events with the specified level from the channel, and otherwise **false**.

## -remarks
This property is equivalent to channel.Enabled &amp;&amp; channel.Level &lt;= level.

## -examples

## -see-also
[IsEnabled](loggingchannel_isenabled_180154405.md), [IsEnabled(LoggingLevel, Int64)](loggingchannel_isenabled_1519006295.md)