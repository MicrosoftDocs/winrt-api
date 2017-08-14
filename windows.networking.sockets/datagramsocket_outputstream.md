---
-api-id: P:Windows.Networking.Sockets.DatagramSocket.OutputStream
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IOutputStream OutputStream { get; }
-->

# Windows.Networking.Sockets.DatagramSocket.OutputStream

## -description
Gets the output stream to write to the remote host.

## -property-value
A stream of bytes to be written to the remote host in a UDP datagram.

## -remarks
This property is often used with the [DataWriter](../windows.storage.streams/datawriter.md) object to write outgoing data to be sent to the remote network destination on a socket object.

Every write to the [OutputStream](datagramsocket_outputstream.md) results in a network packet being sent.

## -examples

## -see-also
[DataWriter](../windows.storage.streams/datawriter.md), [IOutputStream](../windows.storage.streams/ioutputstream.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
