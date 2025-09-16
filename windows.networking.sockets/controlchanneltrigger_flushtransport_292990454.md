---
-api-id: M:Windows.Networking.Sockets.ControlChannelTrigger.FlushTransport
-api-type: winrt method
---

<!-- Method syntax
public void FlushTransport()
-->

# Windows.Networking.Sockets.ControlChannelTrigger.FlushTransport

## -description
Flushes any networking data used by the transport connection associated with the [ControlChannelTrigger](controlchanneltrigger.md) to the networking stack. 

## -remarks
The FlushTransport method flushes any networking data used by the transport connection associated with the [ControlChannelTrigger](controlchanneltrigger.md) to the networking stack. This method is called at the end of a background task. It ensures any networking data that is being sent leaves the process and has a chance to get to networking stack.

## -examples

## -see-also
