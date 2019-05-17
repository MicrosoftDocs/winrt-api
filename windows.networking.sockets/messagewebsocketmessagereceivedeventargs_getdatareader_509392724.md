---
-api-id: M:Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs.GetDataReader
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.DataReader GetDataReader()
-->

# Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs.GetDataReader

## -description
Gets a [DataReader](../windows.storage.streams/datareader.md) object to read incoming data received from the remote network destination on a [MessageWebSocket](messagewebsocket.md).

## -returns
A [DataReader](../windows.storage.streams/datareader.md) object to read incoming data received from the remote network destination on a [MessageWebSocket](messagewebsocket.md).

## -remarks
If the underlying TCP connection is suddenly terminated, GetDataReader throws the WININET_E_CONNECTION_ABORTED exception.

An empty message results in GetDataReader returning a valid [IDataReader](../windows.storage.streams/idatareader.md) instance with [UnconsumedBufferLength](../windows.storage.streams/idatareader_unconsumedbufferlength.md) set to 0.

## -examples

## -see-also
[DataReader](../windows.storage.streams/datareader.md), [MessageWebSocket](messagewebsocket.md)
