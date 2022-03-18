---
-api-id: P:Windows.Networking.Sockets.IWebSocketControl.SupportedProtocols
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> SupportedProtocols { get; }
-->

# Windows.Networking.Sockets.IWebSocketControl.SupportedProtocols

## -description
Gets a collection that can be used to add a list of supported sub-protocols that will be advertised to the server during the connect handshake.

## -property-value
A collection that contains the WebSocket sub-protocols supported by the [IWebSocket](iwebsocket.md) object.

## -remarks
The SupportedProtocols property contains a collection of WebSocket sub-protocols supported by the [IWebSocket](iwebsocket.md) object. Before calling the [ConnectAsync](iwebsocket_connectasync_682685111.md) method, additional supported sub-protocol strings can be added to this collection, which will be sent to the server in the "Sec-WebSocket-Protocol" header during the WebSocket handshake. The protocol chosen by the WebSocket server will then be exposed on the [Protocol](iwebsocketinformation_protocol.md) property.

An attempt to add a sub-protocol to this collection after a successful call to [ConnectAsync](iwebsocket_connectasync_682685111.md) method will result in an error. However, if the [ConnectAsync](iwebsocket_connectasync_682685111.md) method call or the connect operation completes with an error, an appl can update the collection stored in the SupportedProtocols property and retry the [ConnectAsync](iwebsocket_connectasync_682685111.md) method call.

## -examples

## -see-also
[IWebSocket](iwebsocket.md), [IWebSocketInformation.Protocol](iwebsocketinformation_protocol.md), [How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10))
