---
-api-id: P:Windows.Networking.Sockets.MessageWebSocketInformation.Protocol
-api-type: winrt property
---

<!-- Property syntax
public string Protocol { get; }
-->

# Windows.Networking.Sockets.MessageWebSocketInformation.Protocol

## -description
Gets the WebSocket sub-protocol negotiated with the server during WebSocket handshake on a [MessageWebSocket](messagewebsocket.md) object.

## -property-value
The sub-protocol negotiated with the server during the WebSocket handshake.

## -remarks
Both a WebSocket client and a WebSocket server may support multiple sub-protocols. During the WebSocket handshake, the server will select one of the sub-protocols from the mutually supported sub-protocols and reply in the "Sec-WebSocket-Protocol" header. The [Protocol](messagewebsocketinformation_protocol.md) property will contain the selected sub-protocol string.

Before the [MessageWebSocket](messagewebsocket.md) is connected, this property is null.

## -examples

## -see-also
[How to use advanced WebSocket controls ](https://msdn.microsoft.com/library/0a47f7c3-66f9-4315-886e-bd1afe77bf39), [How to use advanced WebSocket controls ](https://msdn.microsoft.com/library/4ab9621e-90e5-420e-88d0-09f1c7239d7a), [MessageWebSocket](messagewebsocket.md), [MessageWebSocket.SupportedProtocols](messagewebsocketcontrol_supportedprotocols.md)
