---
-api-id: P:Windows.Networking.Sockets.DatagramSocketInformation.RemotePort
-api-type: winrt property
---

<!-- Property syntax
public string RemotePort { get; }
-->

# Windows.Networking.Sockets.DatagramSocketInformation.RemotePort

## -description
The UDP port number of the remote network destination associated with a [DatagramSocket](datagramsocket.md) object.

## -property-value
The UDP port number of the remote network destination.

## -remarks
The [RemotePort](datagramsocketinformation_remoteport.md) property represents the UDP port number for the remote network destination associated with a [DatagramSocket](datagramsocket.md) object.

An app can set the remote hostname or IP address and remote service name or UDP port number to use by calling the [ConnectAsync](datagramsocket_connectasync_13692504.md) or [GetOutputStreamAsync](datagramsocket_getoutputstreamasync_1619245957.md) method on the [DatagramSocket](datagramsocket.md). The connect operation will bind the socket to a specific remote IP address and remote UDP port number. The [RemotePort](datagramsocketinformation_remoteport.md) property is the UDP port number the remote service name resolved to.

## -examples

## -see-also
[How to use advanced socket controls ](https://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](https://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [DatagramSocket](datagramsocket.md), [DatagramSocket.ConnectAsync](datagramsocket_connectasync_13692504.md), [DatagramSocket.GetOutputStreamAsync](datagramsocket_getoutputstreamasync_1619245957.md), [LocalAddress](datagramsocketinformation_localaddress.md), [LocalPort](datagramsocketinformation_localport.md), [RemoteAddress](datagramsocketinformation_remoteaddress.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
