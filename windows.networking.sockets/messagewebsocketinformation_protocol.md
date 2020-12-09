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
Both a WebSocket client and a WebSocket server may support multiple sub-protocols. During the WebSocket handshake, the server will select one of the sub-protocols from the mutually supported sub-protocols and reply in the "Sec-WebSocket-Protocol" header. The Protocol property will contain the selected sub-protocol string.

Before the [MessageWebSocket](messagewebsocket.md) is connected, this property is null.

## -examples

## -see-also
[How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)), [MessageWebSocket](messagewebsocket.md), [MessageWebSocket.SupportedProtocols](messagewebsocketcontrol_supportedprotocols.md)
