---
-api-id: P:Windows.Networking.Sockets.DatagramSocketInformation.LocalPort
-api-type: winrt property
---

<!-- Property syntax
public string LocalPort { get; }
-->

# Windows.Networking.Sockets.DatagramSocketInformation.LocalPort

## -description
The local service name or UDP port number associated with a [DatagramSocket](datagramsocket.md).

## -property-value
The local service name or UDP port number.

## -remarks
The LocalPort property represents the local service name or UDP port number bound to the [DatagramSocket](datagramsocket.md) object.

An app can set the local service name or UDP port number to use by calling the [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) , [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md), [ConnectAsync(EndpointPair)](datagramsocket_connectasync_13692504.md) , or [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) methods on the [DatagramSocket](datagramsocket.md). The bind or connect operation will bind the socket to the specific local IP address and local UDP port number. After the bind or connect operation completes, [LocalAddress](datagramsocketinformation_localaddress.md) property contains the IP address and the LocalPort property contains the local UDP port number that the local hostname and service name resolved to.

If the local service name or UDP port number passed to the [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) , [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md), [ConnectAsync(EndpointPair)](datagramsocket_connectasync_13692504.md) , or [GetOutputStreamAsync(EndpointPair)](datagramsocket_getoutputstreamasync_228240991.md) methods is an empty string or the [ConnectAsync(HostName, String)](datagramsocket_connectasync_1841953676.md) or [GetOutputStreamAsync(HostName, String)](datagramsocket_getoutputstreamasync_1619245957.md) method is called, the system will determine the local UDP port to bind to the [DatagramSocket](datagramsocket.md) object.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [DatagramSocket](datagramsocket.md), [DatagramSocket.BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md), [DatagramSocket.BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md), [DatagramSocket.ConnectAsync](datagramsocket_connectasync_13692504.md), [DatagramSocket.GetOutputStreamAsync](datagramsocket_getoutputstreamasync_1619245957.md), [LocalAddress](datagramsocketinformation_localaddress.md), [RemoteAddress](datagramsocketinformation_remoteaddress.md), [RemotePort](datagramsocketinformation_remoteport.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
