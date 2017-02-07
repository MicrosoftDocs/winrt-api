---
-api-id: T:Windows.Networking.Sockets.SocketActivityTriggerReason
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Sockets.SocketActivityTriggerReason : int
-->

# SocketActivityTriggerReason

## -description
The reason why a [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md) occurred.

## -enum-fields
### -field None:0
No reason why a  occurred is available.

### -field SocketActivity:1
A packet was received by the socket brokering service for a [StreamSocket](streamsocket.md) or [DatagramSocket](datagramsocket.md).

### -field ConnectionAccepted:2
A connection was accepted by the socket brokering service for a [StreamSocketListener](streamsocketlistener.md).

### -field KeepAliveTimerExpired:3
The keep-alive timer expired on a [StreamSocket](streamsocket.md).

### -field SocketClosed:4
A [StreamSocket](streamsocket.md) was closed.


## -remarks

## -examples

## -see-also
[DatagramSocket](datagramsocket.md), [SocketActivityTrigger](../windows.applicationmodel.background/socketactivitytrigger.md), [StreamSocket](streamsocket.md), [StreamSocketListener](streamsocketlistener.md)