---
-api-id: P:Windows.Networking.Sockets.MessageWebSocketControl.MaxMessageSize
-api-type: winrt property
---

<!-- Property syntax
public uint MaxMessageSize { get;  set; }
-->

# Windows.Networking.Sockets.MessageWebSocketControl.MaxMessageSize

## -description
The maximum message size, in bytes, for a WebSocket message to be configured on the [MessageWebSocket](messagewebsocket.md) object.

## -property-value
The maximum message size, in bytes, to be configured on the [MessageWebSocket](messagewebsocket.md) object.

## -remarks
The MaxMessageSize property is used to configure the maximum size of a WebSocket message on a [MessageWebSocket](messagewebsocket.md) object. If a message exceeds this size, [MessageReceived](messagewebsocket_messagereceived.md) event will be raised on the [MessageWebSocket](messagewebsocket.md) object, and the [GetDataReader](messagewebsocketmessagereceivedeventargs_getdatareader_509392724.md) or [GetDataStream](messagewebsocketmessagereceivedeventargs_getdatastream_1357691687.md) method on the [MessageWebSocketMessageReceivedEventArgs](messagewebsocketmessagereceivedeventargs.md) callback parameter will fail (with an error code indicating that the maximum message size has been exceeded).

The default value for the MaxMessageSize property is INFINITE.

The MaxMessageSize property can only be set before calling the [ConnectAsync](messagewebsocket_connectasync_682685111.md) method on the [MessageWebSocket](messagewebsocket.md) object. If the [MessageWebSocket](messagewebsocket.md) is already connected, an attempt to set this property will return an error.

## -examples

## -see-also
[How to use advanced WebSocket controls](/previous-versions/windows/apps/hh994400(v=win.10)), [MessageWebSocket](messagewebsocket.md)
