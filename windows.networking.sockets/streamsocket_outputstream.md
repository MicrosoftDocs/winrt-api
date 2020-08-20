---
-api-id: P:Windows.Networking.Sockets.StreamSocket.OutputStream
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IOutputStream OutputStream { get; }
-->

# Windows.Networking.Sockets.StreamSocket.OutputStream

## -description
Gets the output stream to write to the remote host on a [StreamSocket](streamsocket.md) object.

## -property-value
A sequential stream of bytes to be written to the remote destination.

## -remarks
This property can be used to write outgoing data to be sent to the remote network destination on a socket object. Outgoing data can be written using the [IOutputStream.WriteAsync](../windows.storage.streams/ioutputstream_writeasync_897036872.md) method directly or by passing the [IOutputStream](../windows.storage.streams/ioutputstream.md) object to other objects ([DataWriter](../windows.storage.streams/datawriter.md), for example) that accept an [IOutputStream](../windows.storage.streams/ioutputstream.md) as a parameter.

## -examples

See [StreamSocket class](/uwp/api/windows.networking.sockets.streamsocket).

## -see-also
[DataWriter](../windows.storage.streams/datawriter.md), [IOutputStream](../windows.storage.streams/ioutputstream.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
