---
-api-id: E:Windows.Networking.Sockets.MessageWebSocket.MessageReceived
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler MessageReceived<Windows.Networking.Sockets.MessageWebSocket,  Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs>
-->

# Windows.Networking.Sockets.MessageWebSocket.MessageReceived

## -description
An event that indicates that a message was received on the [MessageWebSocket](messagewebsocket.md) object.

## -remarks
All message processing and connection related errors are communicated through the [GetDataReader](messagewebsocketmessagereceivedeventargs_getdatareader_509392724.md) and [GetDataStream](messagewebsocketmessagereceivedeventargs_getdatastream_1357691687.md) methods. If either of these methods throws an exception, it indicates that either the underlying connection is broken, or the server has sent invalid data, such as corrupt HTTP headers or a message that exceeds the maximum message size. The appropriate action for your code to take in the face of an exception from these methods is to re-establish a known good state by closing the websocket, creating a new one, and reconnecting to the server.

All MessageReceived event handlers must be registered before [ConnectAsync](iwebsocket_connectasync_682685111.md) is called. After that, attempting to add or remove a [MessageReceived](messagewebsocket_messagereceived.md) event handler will fail with E_ILLEGAL_METHOD_CALL, even after the socket has been closed

An empty message results in [GetDataReader](messagewebsocketmessagereceivedeventargs_getdatareader_509392724.md) returning a valid [IDataReader](../windows.storage.streams/idatareader.md) instance with [UnconsumedBufferLength](../windows.storage.streams/idatareader_unconsumedbufferlength.md) set to 0. [GetDataStream](messagewebsocketmessagereceivedeventargs_getdatastream_1357691687.md) returns a valid [IInputStream](../windows.storage.streams/iinputstream.md) instance that yields zero bytes.

## -examples

## -see-also
