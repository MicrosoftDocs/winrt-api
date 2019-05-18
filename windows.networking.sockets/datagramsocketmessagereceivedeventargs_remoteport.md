---
-api-id: P:Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs.RemotePort
-api-type: winrt property
---

<!-- Property syntax
public string RemotePort { get; }
-->

# Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs.RemotePort

## -description
Gets the UDP port number of the remote sender of the datagram received on the [DatagramSocket](datagramsocket.md).

## -property-value
The UDP port number of the remote network destination when a message is received on a [DatagramSocket](datagramsocket.md).

## -remarks
The DatagramSocketMessageReceivedEventArgs.RemotePort property gets the UDP port number of the remote sender when a datagram was received on a [DatagramSocket](datagramsocket.md). A message received event can only occur after a successful connect or bind operation on the [DatagramSocket](datagramsocket.md).

## -examples

## -see-also
[BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md), [ConnectAsync](datagramsocket_connectasync_13692504.md), [DatagramSocket](datagramsocket.md), [DatagramSocketInformation.LocalAddress](datagramsocketinformation_localaddress.md), [DatagramSocketInformation.LocalPort](datagramsocketinformation_localport.md), [DatagramSocketInformation.RemoteAddress](datagramsocketinformation_remoteaddress.md), [DatagramSocketInformation.RemotePort](datagramsocketinformation_remoteport.md), [DatagramSocketMessageReceivedEventArgs.LocalAddress](datagramsocketmessagereceivedeventargs_localaddress.md), [DatagramSocketMessageReceivedEventArgs.RemoteAddress](datagramsocketmessagereceivedeventargs_remoteaddress.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
