---
-api-id: P:Windows.Networking.Sockets.MessageWebSocketControl.OutboundBufferSizeInBytes
-api-type: winrt property
---

<!-- Property syntax
public uint OutboundBufferSizeInBytes { get;  set; }
-->

# Windows.Networking.Sockets.MessageWebSocketControl.OutboundBufferSizeInBytes

## -description
The size, in bytes, of the send buffer to be used for sending data on a [MessageWebSocket](messagewebsocket.md) object.

## -property-value
The size, in bytes, of the send buffer to be used for sending data.

## -remarks
The [OutboundBufferSizeInBytes](messagewebsocketcontrol_outboundbuffersizeinbytes.md) property sets the value of the **SO_SNDBUF** socket option on the TCP socket used by the [MessageWebSocket](messagewebsocket.md). The default value is the local computer's default send buffer size. This value varies based on the system memory size. For more detailed information, see [SOL_SOCKET Socket Options](http://msdn.microsoft.com/library/0cd0056e-0c33-4f6e-9f70-5417f8f8da4b) in the Windows Sockets documentation.

For most apps, this property should not be set since this disables TCP send auto-tuning by the system on this [MessageWebSocket](messagewebsocket.md) object. With TCP send auto-tuning disabled, network throughput is often worse especially on a connections with high latency. So this property should only be used in very specific situations.

The [OutboundBufferSizeInBytes](messagewebsocketcontrol_outboundbuffersizeinbytes.md) property must be set before the [MessageWebSocket](messagewebsocket.md) is connected. Setting this property after the [MessageWebSocket](messagewebsocket.md) is connected has no effect.

## -examples

## -see-also
[How to use advanced WebSocket controls ](http://msdn.microsoft.com/library/0a47f7c3-66f9-4315-886e-bd1afe77bf39), [How to use advanced WebSocket controls ](http://msdn.microsoft.com/library/4ab9621e-90e5-420e-88d0-09f1c7239d7a), [MessageWebSocket](messagewebsocket.md)