---
-api-id: P:Windows.Networking.Sockets.IWebSocketControl.OutboundBufferSizeInBytes
-api-type: winrt property
---

<!-- Property syntax
public uint OutboundBufferSizeInBytes { get;  set; }
-->

# Windows.Networking.Sockets.IWebSocketControl.OutboundBufferSizeInBytes

## -description
The size, in bytes, of the send buffer to be used for sending data on an [IWebSocket](iwebsocket.md) object.

## -property-value
The size, in bytes, of the send buffer to be used for sending data.

## -remarks
This property sets the value of the **SO_SNDBUF** socket option on the TCP socket used by the [IWebSocket](iwebsocket.md). The default value is the local computer's default send buffer size. This value varies based on the system memory size. For more detailed information, see [SOL_SOCKET Socket Options](/windows/desktop/WinSock/sol-socket-socket-options) in the Windows Sockets documentation.

For most apps, this property should not be set since this disables TCP send auto-tuning by the system on this [IWebSocket](iwebsocket.md) object. With TCP send auto-tuning disabled, network throughput is often worse especially on a connections with high latency. So this property should only be used in very specific situations.

This property must be set before the [IWebSocket](iwebsocket.md) connection is made. It will not have any effect if set after the connection has been initiated.

## -examples

## -see-also
[SOL_SOCKET Socket Options](/windows/desktop/WinSock/sol-socket-socket-options), [IWebSocket](iwebsocket.md)
