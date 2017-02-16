---
-api-id: P:Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs.LocalAddress
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.HostName LocalAddress { get; }
-->

# Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs.LocalAddress

## -description
Gets the local IP address associated with a [DatagramSocket](datagramsocket.md) when a message was received.

## -property-value
The local IP address where the message was received by the [DatagramSocket](datagramsocket.md).

## -remarks
The [DatagramSocketMessageReceivedEventArgs.LocalAddress](datagramsocketmessagereceivedeventargs_localaddress.md) property gets the local IP address where a message was received on a [DatagramSocket](datagramsocket.md). A message received event can only occur after a successful connect or bind operation on the [DatagramSocket](datagramsocket.md).

## -examples

## -see-also
[BindServiceNameAsync](datagramsocket_bindservicenameasync.md), [ConnectAsync](datagramsocket_connectasync.md), [DatagramSocket](datagramsocket.md), [DatagramSocketInformation.LocalAddress](datagramsocketinformation_localaddress.md), [DatagramSocketInformation.LocalPort](datagramsocketinformation_localport.md), [DatagramSocketInformation.RemoteAddress](datagramsocketinformation_remoteaddress.md), [DatagramSocketInformation.RemotePort](datagramsocketinformation_remoteport.md), [DatagramSocketMessageReceivedEventArgs.RemoteAddress](datagramsocketmessagereceivedeventargs_remoteaddress.md), [DatagramSocketMessageReceivedEventArgs.RemotePort](datagramsocketmessagereceivedeventargs_remoteport.md), [HostName](../windows.networking/hostname.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]