---
-api-id: P:Windows.Networking.Sockets.StreamWebSocketControl.OutboundBufferSizeInBytes
-api-type: winrt property
---

<!-- Property syntax
public uint OutboundBufferSizeInBytes { get;  set; }
-->

# Windows.Networking.Sockets.StreamWebSocketControl.OutboundBufferSizeInBytes

## -description
The size, in bytes, of the send buffer to be used for sending data on a [StreamWebSocket](streamwebsocket.md) object.

## -property-value
The size, in bytes, of the send buffer to be used for sending data.

## -remarks
The OutboundBufferSizeInBytes property sets the value of the **SO_SNDBUF** socket option on the TCP socket used by the [StreamWebSocket](streamwebsocket.md). The default value is the local computer's default send buffer size. This value varies based on the system memory size. For more detailed information, see [SOL_SOCKET Socket Options](/windows/desktop/WinSock/sol-socket-socket-options) in the Windows Sockets documentation.

For most apps, this property should not be set since this disables TCP send auto-tuning by the system on this [StreamWebSocket](streamwebsocket.md) object. With TCP send auto-tuning disabled, network throughput is often worse especially on a connections with high latency. So this property should only be used in very specific situations.

The OutboundBufferSizeInBytes property must be set before the [StreamWebSocket](streamwebsocket.md) is connected. Setting this property after the [MessageWebSocket](messagewebsocket.md) is connected has no effect.

## -examples

## -see-also
[How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)), [SOL_SOCKET Socket Options](/windows/desktop/WinSock/sol-socket-socket-options), [StreamWebSocket](streamwebsocket.md)
