---
-api-id: P:Windows.Networking.Sockets.StreamSocket.InputStream
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IInputStream InputStream { get; }
-->

# Windows.Networking.Sockets.StreamSocket.InputStream

## -description
Gets the input stream to read from the remote destination on a [StreamSocket](streamsocket.md) object.

## -property-value
A sequential stream of bytes to be read from the remote destination.

## -remarks
This property can be used to read incoming data received from the remote network destination on a socket object. Incoming data can be read using the [IInputStream.ReadAsync](../windows.storage.streams/iinputstream_readasync_1012630619.md) method directly or by passing the [IInputStream](../windows.storage.streams/iinputstream.md) object to other objects ([DataReader](../windows.storage.streams/datareader.md), for example) that accept an [IInputStream](../windows.storage.streams/iinputstream.md) as a parameter.

## -examples

See [StreamSocket class](/uwp/api/windows.networking.sockets.streamsocket).

## -see-also
[DataReader](../windows.storage.streams/datareader.md), [IInputStream](../windows.storage.streams/iinputstream.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
