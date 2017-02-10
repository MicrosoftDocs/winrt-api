---
-api-id: P:Windows.Networking.Sockets.StreamWebSocket.OutputStream
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IOutputStream OutputStream { get; }
-->

# Windows.Networking.Sockets.StreamWebSocket.OutputStream

## -description
Gets the output stream to write to the remote network destination on a [StreamWebSocket](streamwebsocket.md) object.

## -property-value
A sequential stream of bytes to be written to the remote destination.

## -remarks
This property is used with the [DataWriter](../windows.storage.streams/datawriter.md) object to write outgoing data to be sent to the remote network destination on a [StreamWebSocket](streamwebsocket.md) object.

The following specific errors can occur when you call [IOutputStream.FlushAsync](../windows.storage.streams/ioutputstream_flushasync.md) on the [OutputStream](streamwebsocket_outputstream.md) of a [StreamWebSocket](streamwebsocket.md) if the websocket is in an invalid state at the time.


+ If the websocket instance has been explicitly closed (via delete, **Dispose**, or **Close**) or implicitly closed (fallen out of scope), [FlushAsync](../windows.storage.streams/ioutputstream_flushasync.md) throws an **RO_E_CLOSED** exception.
+ If the IOutputStream object associated with the websocket has been explicitly closed (via delete, **Dispose**, or **Close**) or implicitly closed (for example, by disposing of a [DataWriter](../windows.storage.streams/datawriter.md) instance before calling [DetachStream](../windows.storage.streams/datawriter_detachstream.md) on it), [FlushAsync](../windows.storage.streams/ioutputstream_flushasync.md) throws an **RO_E_CLOSED** exception.
+ If the websocket is not connected yet ([ConnectAsync](streamwebsocket_connectasync.md) has not been called), then [FlushAsync](../windows.storage.streams/ioutputstream_flushasync.md) throws an **E_ILLEGAL_METHOD_CALL** exception.


## -examples

## -see-also
[DataWriter](../windows.storage.streams/datawriter.md), [IOutputStream](../windows.storage.streams/ioutputstream.md)