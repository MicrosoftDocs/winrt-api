---
-api-id: P:Windows.Networking.Sockets.MessageWebSocketControl.MessageType
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.SocketMessageType MessageType { get;  set; }
-->

# Windows.Networking.Sockets.MessageWebSocketControl.MessageType

## -description
The WebSocket message type to be configured on a [MessageWebSocket](messagewebsocket.md) object for write operations.

## -property-value
The WebSocket message type. The default is binary.

## -remarks
A WebSocket message on the [MessageWebSocket](messagewebsocket.md) object can be either a binary message or a UTF-8 message. The default value is [SocketMessageType.Binary](socketmessagetype.md).

This property only affects write operations on [OutputStream](messagewebsocket_outputstream.md). It does not affect the format of received messages.

The MessageType property can be changed at any time. This allows an app to switch between binary and UTF-8 messages when needed.

Before changing the MessageType on a bound or connected [MessageWebSocket](messagewebsocket.md), any outgoing packets should first be flushed to ensure that all previously-written data is sent out with the previous message type



## -examples

## -see-also
[How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)), [MessageWebSocket](messagewebsocket.md), [SocketMessageType](socketmessagetype.md)
