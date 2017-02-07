---
-api-id: T:Windows.Perception.Automation.Monitoring.PerceptionMonitorChannelDeliveryMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Perception.Automation.Monitoring.PerceptionMonitorChannelDeliveryMode : int
-->

# PerceptionMonitorChannelDeliveryMode

## -description
Defines the mode of data delivery for a [PerceptionMonitorChannel](perceptionmonitorchannel.md).

## -enum-fields
### -field BestEffort:0
Data on the current channel is delivered with a best-effort protocol. The data is stateless and it's allowable to lose a buffer in transit. This is a hint that UDP may be used to transmit the data.

### -field Guaranteed:1
Data on the current channel is delivered in-order and is guaranteed reach the destination. This is a hint that TCP may be used to transmit the data.


## -remarks

## -examples

## -see-also