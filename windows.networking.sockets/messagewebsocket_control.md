---
-api-id: P:Windows.Networking.Sockets.MessageWebSocket.Control
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.MessageWebSocketControl Control { get; }
-->

# Windows.Networking.Sockets.MessageWebSocket.Control

## -description
Gets socket control data on a [MessageWebSocket](messagewebsocket.md) object.

## -property-value
Socket control data on a [MessageWebSocket](messagewebsocket.md) object.

## -remarks
The Control property gets the [MessageWebSocketControl](messagewebsocketcontrol.md) instance associated with a [MessageWebSocket](messagewebsocket.md) object.

A [MessageWebSocketControl](messagewebsocketcontrol.md) object is automatically created with the parent [MessageWebSocket](messagewebsocket.md) object. The [MessageWebSocketControl](messagewebsocketcontrol.md) instance can then be used to get or set control data used by the [MessageWebSocket](messagewebsocket.md) object. These properties on the [MessageWebSocketControl](messagewebsocketcontrol.md) instance include the following:


+ [MaxMessageSize](messagewebsocketcontrol_maxmessagesize.md) - The maximum message size, in bytes, for a WebSocket message to be configured on the [MessageWebSocket](messagewebsocket.md) object.
+ [MessageType](messagewebsocketcontrol_messagetype.md) - The WebSocket message type to be configured on a [MessageWebSocket](messagewebsocket.md) object for write operations.
+ [OutboundBufferSizeInBytes](messagewebsocketcontrol_outboundbuffersizeinbytes.md) - The size, in bytes, of the send buffer to be used for sending data on a [MessageWebSocket](messagewebsocket.md) object.
+ [ProxyCredential](messagewebsocketcontrol_proxycredential.md) - The credential to use to authenticate to the proxy server through HTTP header authentication using a [MessageWebSocket](messagewebsocket.md) object.
+ [ServerCredential](messagewebsocketcontrol_servercredential.md) - The credential to use to authenticate to the WebSocket server through HTTP header authentication using a [MessageWebSocket](messagewebsocket.md) object.
+ [SupportedProtocols](messagewebsocketcontrol_supportedprotocols.md) - Gets a collection that can be used to add a list of supported sub-protocols that will be advertised to the server during the connect handshake.


The [SupportedProtocols](messagewebsocketcontrol_supportedprotocols.md) property gets the value of this property and can be called at any time.

The [MessageType](messagewebsocketcontrol_messagetype.md) property can be changed at any time before or after the [MessageWebSocket](messagewebsocket.md) is connected. This allows an app to switch between binary and UTF-8 messages when needed.

The [OutboundBufferSizeInBytes](messagewebsocketcontrol_outboundbuffersizeinbytes.md) property must be set before the [MessageWebSocket](messagewebsocket.md) is connected. Setting this property after the [MessageWebSocket](messagewebsocket.md) is connected has no effect.

Changes to any other property values on the [MessageWebSocketControl](messagewebsocketcontrol.md) must be set before the [MessageWebSocket](messagewebsocket.md) is connected. As a result if you need to make changes to the [MaxMessageSize](messagewebsocketcontrol_maxmessagesize.md), [OutboundBufferSizeInBytes](messagewebsocketcontrol_outboundbuffersizeinbytes.md), [ProxyCredential](messagewebsocketcontrol_proxycredential.md), or [ServerCredential](messagewebsocketcontrol_servercredential.md) properties, then these changes must occur before a successful call to the [ConnectAsync](messagewebsocket_connectasync_682685111.md) method on the [MessageWebSocket](messagewebsocket.md).

## -examples

## -see-also
[How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)), [MaxMessageSize](messagewebsocketcontrol_maxmessagesize.md), [MessageType](messagewebsocketcontrol_messagetype.md), [MessageWebSocketControl](messagewebsocketcontrol.md), [OutboundBufferSizeInBytes](messagewebsocketcontrol_outboundbuffersizeinbytes.md), [ProxyCredential](messagewebsocketcontrol_proxycredential.md), [SupportedProtocols](messagewebsocketcontrol_supportedprotocols.md)
