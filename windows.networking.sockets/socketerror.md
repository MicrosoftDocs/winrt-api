---
-api-id: T:Windows.Networking.Sockets.SocketError
-api-type: winrt class
---

<!-- Class syntax.
public class SocketError 
-->

# Windows.Networking.Sockets.SocketError

## -description
Provides socket error status for operations on a [DatagramSocket](datagramsocket.md), [StreamSocket](streamsocket.md), or [StreamSocketListener](streamsocketlistener.md).

## -remarks
An error encountered on socket operation is returned as **HRESULT** value. The [GetStatus](socketerror_getstatus.md) method on the [SocketError](socketerror.md) object is used to convert an error from a socket operation to a [SocketErrorStatus](socketerrorstatus.md) enumeration value. Most of the [SocketErrorStatus](socketerrorstatus.md) enumeration values correspond to an error returned by the native Windows sockets operation.

## -examples

## -see-also
[DatagramSocket](datagramsocket.md), [StreamSocket](streamsocket.md), [StreamSocketListener](streamsocketlistener.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
