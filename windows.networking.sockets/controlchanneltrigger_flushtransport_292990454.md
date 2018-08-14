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

> [!NOTE]
> The ControlChannelTrigger class is not supported on Windows Phone.

## -remarks
The [FlushTransport](controlchanneltrigger_flushtransport_292990454.md) method flushes any networking data used by the transport connection associated with the [ControlChannelTrigger](controlchanneltrigger.md) to the networking stack. This method is called at the end of a background task. It ensures any networking data that is being sent leaves the process and has a chance to get to networking stack.

## -examples

## -see-also
