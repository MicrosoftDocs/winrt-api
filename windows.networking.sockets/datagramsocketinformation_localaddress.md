---
-api-id: P:Windows.Networking.Sockets.DatagramSocketInformation.LocalAddress
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.HostName LocalAddress { get; }
-->

# Windows.Networking.Sockets.DatagramSocketInformation.LocalAddress

## -description
The local IP address associated with a [DatagramSocket](datagramsocket.md) object.

## -property-value
The local hostname or IP address.

## -remarks
The LocalAddress property represents the local IP address bound to the [DatagramSocket](datagramsocket.md) object.

An app can set the local hostname or IP address to use by calling the [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) , [ConnectAsync(EndpointPair)](datagramsocket_connectasync_13692504.md) , or [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) methods on the [DatagramSocket](datagramsocket.md). The bind or connect operation will bind the socket to the specific local IP address and local UDP port number. After the bind or connect operation completes, LocalAddress property contains the IP address and the [LocalPort](datagramsocketinformation_localport.md) property contains the local UDP port number that the local hostname and service name resolved to.

If the local hostname or IP address passed to the [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) , [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md), [ConnectAsync(EndpointPair)](datagramsocket_connectasync_13692504.md) , or [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) methods is null or the [ConnectAsync(HostName, String)](datagramsocket_connectasync_1841953676.md) or [GetOutputStreamAsync(HostName, String)](datagramsocket_getoutputstreamasync_1619245957.md) method is called, the system will determine the local IP address to bind to the [DatagramSocket](datagramsocket.md) object.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [DatagramSocket](datagramsocket.md), [DatagramSocket.BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md), [DatagramSocket.BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md), [DatagramSocket.ConnectAsync](datagramsocket_connectasync_13692504.md), [DatagramSocket.GetOutputStreamAsync](datagramsocket_getoutputstreamasync_1619245957.md), [HostName](../windows.networking/hostname.md), [LocalPort](datagramsocketinformation_localport.md), [RemoteAddress](datagramsocketinformation_remoteaddress.md), [RemotePort](datagramsocketinformation_remoteport.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
