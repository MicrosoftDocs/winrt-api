---
-api-id: P:Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs.RemoteAddress
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.HostName RemoteAddress { get; }
-->

# Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs.RemoteAddress

## -description
Gets the IP address of the remote sender of the datagram on the [DatagramSocket](datagramsocket.md) when a message is received.

## -property-value
The IP address of the remote network destination when the message is received on a [DatagramSocket](datagramsocket.md).

## -remarks
The [DatagramSocketMessageReceivedEventArgs.RemoteAddress](datagramsocketmessagereceivedeventargs_remoteaddress.md) property gets the IP address of the remote sender when a datagram was received on a [DatagramSocket](datagramsocket.md). A message received event can only occur after a successful connect or bind operation on the [DatagramSocket](datagramsocket.md).

## -examples

## -see-also
[BindServiceNameAsync](datagramsocket_bindservicenameasync.md), [ConnectAsync](datagramsocket_connectasync.md), [DatagramSocket](datagramsocket.md), [DatagramSocketInformation.LocalAddress](datagramsocketinformation_localaddress.md), [DatagramSocketInformation.LocalPort](datagramsocketinformation_localport.md), [DatagramSocketInformation.RemoteAddress](datagramsocketinformation_remoteaddress.md), [DatagramSocketInformation.RemotePort](datagramsocketinformation_remoteport.md), [DatagramSocketMessageReceivedEventArgs.LocalAddress](datagramsocketmessagereceivedeventargs_localaddress.md), [DatagramSocketMessageReceivedEventArgs.RemotePort](datagramsocketmessagereceivedeventargs_remoteport.md), [HostName](../windows.networking/hostname.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
