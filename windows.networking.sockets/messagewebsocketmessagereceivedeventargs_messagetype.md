---
-api-id: P:Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs.MessageType
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.SocketMessageType MessageType { get; }
-->

# Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs.MessageType

## -description
Gets the type of the message received by a [MessageWebSocket](messagewebsocket.md) object.

## -property-value
The type of the message received.

## -remarks
The WebSocket protocol currently supports two message types: UTF-8 and binary messages. If a message is sent as a binary message, it is up to the app to correctly interpret the binary data. Note that it is perfectly legal to return a binary message where the binary data is a UTF-8 string.

The value of MessageType property is informative. It does not affect what methods are supported on the returned data by the [MessageWebSocket](messagewebsocket.md) object.

## -examples

## -see-also
[MessageWebSocket](messagewebsocket.md), [SocketMessageType](socketmessagetype.md), [MessageWebSocketControl.MessageType](messagewebsocketcontrol_messagetype.md)
