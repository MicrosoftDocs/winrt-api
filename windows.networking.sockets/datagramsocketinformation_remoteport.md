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
The RemotePort property represents the UDP port number for the remote network destination associated with a [DatagramSocket](datagramsocket.md) object.

An app can set the remote hostname or IP address and remote service name or UDP port number to use by calling the [ConnectAsync](datagramsocket_connectasync_13692504.md) or [GetOutputStreamAsync](datagramsocket_getoutputstreamasync_1619245957.md) method on the [DatagramSocket](datagramsocket.md). The connect operation will bind the socket to a specific remote IP address and remote UDP port number. The RemotePort property is the UDP port number the remote service name resolved to.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [DatagramSocket](datagramsocket.md), [DatagramSocket.ConnectAsync](datagramsocket_connectasync_13692504.md), [DatagramSocket.GetOutputStreamAsync](datagramsocket_getoutputstreamasync_1619245957.md), [LocalAddress](datagramsocketinformation_localaddress.md), [LocalPort](datagramsocketinformation_localport.md), [RemoteAddress](datagramsocketinformation_remoteaddress.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
