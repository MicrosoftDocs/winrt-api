---
-api-id: P:Windows.Networking.Sockets.StreamWebSocketControl.SupportedProtocols
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> SupportedProtocols { get; }
-->

# Windows.Networking.Sockets.StreamWebSocketControl.SupportedProtocols

## -description
Gets a collection that can be used to add a list of supported sub-protocols that will be advertised to the server during the connect handshake.

## -property-value
A collection that contains the WebSocket sub-protocols supported by the [StreamWebSocket](streamwebsocket.md) object.

## -remarks
The [SupportedProtocols](streamwebsocketcontrol_supportedprotocols.md) property contains a collection of WebSocket sub-protocols supported by the [StreamWebSocket](streamwebsocket.md) object. Before calling the [ConnectAsync](streamwebsocket_connectasync_682685111.md) method, additional supported sub-protocol strings can be added to this collection, which will be sent to the server in the "Sec-WebSocket-Protocol" header during the WebSocket handshake. The protocol chosen by the WebSocket server will then be exposed on the [Protocol](streamwebsocketinformation_protocol.md) property.

An attempt to add a sub-protocol to this collection after a successful call to [ConnectAsync](streamwebsocket_connectasync_682685111.md) method will not result in an error but the new value is ignored. However, if the [ConnectAsync](streamwebsocket_connectasync_682685111.md) method call or the connect operation completes with an error, an app can update the collection stored in the [SupportedProtocols](streamwebsocketcontrol_supportedprotocols.md) property and retry the [ConnectAsync](streamwebsocket_connectasync_682685111.md) method call and the new value will be applied.

## -examples

## -see-also
[How to use advanced WebSocket controls ](https://msdn.microsoft.com/library/0a47f7c3-66f9-4315-886e-bd1afe77bf39), [How to use advanced WebSocket controls ](https://msdn.microsoft.com/library/4ab9621e-90e5-420e-88d0-09f1c7239d7a), [StreamWebSocket](streamwebsocket.md), [StreamWebSocketInformation.Protocol](streamwebsocketinformation_protocol.md)
