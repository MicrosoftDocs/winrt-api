---
-api-id: P:Windows.Networking.Sockets.StreamSocketInformation.LocalPort
-api-type: winrt property
---

<!-- Property syntax
public string LocalPort { get; }
-->

# Windows.Networking.Sockets.StreamSocketInformation.LocalPort

## -description
Get the TCP port number associated with a [StreamSocket](streamsocket.md).

## -property-value
The local TCP port number of service name.

## -remarks
The [LocalPort](streamsocketinformation_localport.md) property represents the local TCP port number the [StreamSocket](streamsocket.md) object is bound to after a connection is established.

An app can set the local service name or TCP port number to use by calling the [ConnectAsync(EndpointPair)](streamsocket_connectasync_13692504.md) or [ConnectAsync(EndpointPair, SocketProtectionLevel)](streamsocket_connectasync_706428084.md) method on the [StreamSocket](streamsocket.md). The connect operation will bind the socket to the specific local IP address and local UDP port number. After the bind or connect operation completes, the [LocalPort](streamsocketinformation_localport.md) property contains the IP address and the [LocalPort](streamsocketinformation_localport.md) property contains the local TCP port number that the local hostname and service name resolved to.

If the local service name or TCP port number passed to the [ConnectAsync(EndpointPair)](streamsocket_connectasync_13692504.md) or [ConnectAsync(EndpointPair, SocketProtectionLevel)](streamsocket_connectasync_706428084.md) method is an empty string or the [ConnectAsync(HostName, String)](streamsocket_connectasync_1841953676.md) or [ConnectAsync(HostName, String, SocketProtectionLevel)](streamsocket_connectasync_945708620.md) method is called, the system will determine the local TCP port number to bind to the [StreamSocket](streamsocket.md) object.

## -examples

## -see-also
[How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [LocalAddress](streamsocketinformation_localaddress.md), [StreamSocket](streamsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
