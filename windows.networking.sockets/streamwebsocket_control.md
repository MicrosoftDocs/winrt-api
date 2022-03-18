---
-api-id: P:Windows.Networking.Sockets.StreamWebSocket.Control
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.StreamWebSocketControl Control { get; }
-->

# Windows.Networking.Sockets.StreamWebSocket.Control

## -description
Gets socket control data on a [StreamWebSocket](streamwebsocket.md) object.

## -property-value
Socket control data on a [StreamWebSocket](streamwebsocket.md) object.

## -remarks
The Control property gets the [StreamWebSocketControl](streamwebsocketcontrol.md) instance associated with a [StreamWebSocket](streamwebsocket.md) object.

A [StreamWebSocketControl](streamwebsocketcontrol.md) object is automatically created with the parent [StreamWebSocket](streamwebsocket.md) object. The [StreamWebSocketControl](streamwebsocketcontrol.md) instance can then be used to get or set control data used by the [StreamWebSocket](streamwebsocket.md) object. These properties on the [MessageWebSocketControl](messagewebsocketcontrol.md) instance include the following:


+ [NoDelay](streamwebsocketcontrol_nodelay.md) - A value that indicates whether the Nagle algorithm is used on a [StreamWebSocket](streamwebsocket.md) object.
+ [OutboundBufferSizeInBytes](streamwebsocketcontrol_outboundbuffersizeinbytes.md) - The size, in bytes, of the send buffer to be used for sending data on a [StreamWebSocket](streamwebsocket.md) object.
+ [ProxyCredential](streamwebsocketcontrol_proxycredential.md) - The credential to use to authenticate to the proxy server through HTTP header authentication using a [StreamWebSocket](streamwebsocket.md) object.
+ [ServerCredential](streamwebsocketcontrol_servercredential.md) - The credential to use to authenticate to the WebSocket server through HTTP header authentication using a [StreamWebSocket](streamwebsocket.md) object.
+ [SupportedProtocols](streamwebsocketcontrol_supportedprotocols.md) - Gets a collection that can be used to add a list of supported sub-protocols that will be advertised to the server during the connect handshake.


Any changes to the [StreamWebSocketControl](streamwebsocketcontrol.md) property values must be set before the [StreamWebSocket](streamwebsocket.md) is connected. As a result if you need to make changes to the [NoDelay](streamwebsocketcontrol_nodelay.md), [OutboundBufferSizeInBytes](streamwebsocketcontrol_outboundbuffersizeinbytes.md), [ProxyCredential](streamwebsocketcontrol_proxycredential.md), [ServerCredential](streamwebsocketcontrol_servercredential.md), or [SupportedProtocols](streamwebsocketcontrol_supportedprotocols.md) properties, then these changes must occur before a successful call to the [ConnectAsync](streamsocket_connectasync_13692504.md) method on the [StreamWebSocket](streamwebsocket.md).

## -examples

## -see-also
[How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)), [NoDelay](streamwebsocketcontrol_nodelay.md), [OutboundBufferSizeInBytes](streamwebsocketcontrol_outboundbuffersizeinbytes.md), [ProxyCredential](streamwebsocketcontrol_proxycredential.md), [ServerCredential](streamwebsocketcontrol_servercredential.md), [StreamWebSocketControl](streamwebsocketcontrol.md), [SupportedProtocols](streamwebsocketcontrol_supportedprotocols.md)
