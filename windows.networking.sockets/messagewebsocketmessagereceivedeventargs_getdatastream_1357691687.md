---
-api-id: M:Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs.GetDataStream
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IInputStream GetDataStream()
-->

# Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs.GetDataStream

## -description
Gets an [IInputStream](../windows.storage.streams/iinputstream.md) object (a message represented as a sequential stream of bytes) from the remote network destination on a [MessageWebSocket](messagewebsocket.md) object.

## -returns
A message represented as a sequential stream of bytes.

## -remarks
If the underlying TCP connection is suddenly terminated, [GetDataStream](messagewebsocketmessagereceivedeventargs_getdatastream.md) throws the WININET_E_CONNECTION_ABORTED exception.

An empty message results in [GetDataStream](messagewebsocketmessagereceivedeventargs_getdatastream.md) returning a valid [IInputStream](../windows.storage.streams/iinputstream.md) instance that yields zero bytes.

## -examples

## -see-also
[GetDataReader](datagramsocketmessagereceivedeventargs_getdatareader.md), [IInputStream](../windows.storage.streams/iinputstream.md)