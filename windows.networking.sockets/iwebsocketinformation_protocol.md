---
-api-id: P:Windows.Networking.Sockets.IWebSocketInformation.Protocol
-api-type: winrt property
---

<!-- Property syntax
public string Protocol { get; }
-->

# Windows.Networking.Sockets.IWebSocketInformation.Protocol

## -description
Gets the WebSocket sub-protocol negotiated with the server during WebSocket handshake on a [IWebSocket](iwebsocket.md) object.

## -property-value
The sub-protocol negotiated with the server during WebSocket handshake.

## -remarks
Both a WebSocket client and a WebSocket server may support multiple sub-protocols. During the WebSocket handshake, the server will select one of the sub-protocols from the mutually supported sub-protocols and reply in the "Sec-WebSocket-Protocol" header. The Protocol property will contain the selected sub-protocol string.

Before the [IWebSocket](iwebsocket.md) is connected, this property is null.

## -examples

## -see-also
