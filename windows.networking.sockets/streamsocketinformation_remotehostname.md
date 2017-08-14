---
-api-id: P:Windows.Networking.Sockets.StreamSocketInformation.RemoteHostName
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.HostName RemoteHostName { get; }
-->

# Windows.Networking.Sockets.StreamSocketInformation.RemoteHostName

## -description
Get the hostname or IP address of the remote network destination associated with a [StreamSocket](streamsocket.md) object.

## -property-value
The hostname or IP address of the remote network destination.

## -remarks
The [RemoteHostName](streamsocketinformation_remotehostname.md) property represents the remote hostname or IP address for the remote network destination associated with a [StreamSocket](streamsocket.md) object. The remote hostname or IP address that a [StreamSocket](streamsocket.md) object connects to is passed in the *remoteHostName* parameter to the [ConnectAsync](streamsocket_connectasync.md) method on the [StreamSocket](streamsocket.md).

The [RemoteHostName](streamsocketinformation_remotehostname.md) property can be one of the following:


+ The name of the local host that can be resolved by the Domain Name System (DNS) or by another namespace provider.
+ The name of the local host that matches a string in the following file on the local computer: %WINDIR%\\system32\drivers\etc\hosts.
+ A string that contains an IPv4 or an IPv6 network address of the local host. An IPv4 address string is in dotted-decimal notation ("192.168.1.111", for example). An IPv6 address is in hexadecimal notation ("21DA:00D3:0010:2F3B:02AA:00FF:FE28:9C5A", for example).
When this property is the "localhost" string, this represents all loopback addresses on the local computer.

The [RemoteServiceName](streamsocketinformation_remoteservicename.md) property represents the remote service name or TCP port number for the remote network destination associated with a [StreamSocket](streamsocket.md) object.

After a connection is established, the [RemoteAddress](streamsocketinformation_remoteaddress.md) property contains the IP address and the [RemotePort](streamsocketinformation_remoteport.md) property contains the TCP port number of the remote endpoint for the socket connection.

## -examples

## -see-also
[ConnectAsync](streamsocket_connectasync.md), [HostName](../windows.networking/hostname.md), [RemoteAddress](streamsocketinformation_remoteaddress.md), [RemotePort](streamsocketinformation_remoteport.md), [RemoteServiceName](streamsocketinformation_remoteservicename.md), [StreamSocket](streamsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
