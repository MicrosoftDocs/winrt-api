---
-api-id: P:Windows.Networking.Sockets.StreamSocketInformation.RemotePort
-api-type: winrt property
---

<!-- Property syntax
public string RemotePort { get; }
-->

# Windows.Networking.Sockets.StreamSocketInformation.RemotePort

## -description
Get the TCP port number or service name of the remote network destination associated with a [StreamSocket](streamsocket.md) object.

## -property-value
The TCP port number of the remote network endpoint after a connection is established.

## -remarks
The [RemoteHostName](streamsocketinformation_remotehostname.md) property represents the remote hostname or IP address for the remote network destination associated with a [StreamSocket](streamsocket.md) object. The [RemoteServiceName](streamsocketinformation_remoteservicename.md) property represents the remote service name or TCP port number for the remote network destination associated with a [StreamSocket](streamsocket.md) object. The [RemoteHostName](streamsocketinformation_remotehostname.md) and [RemoteServiceName](streamsocketinformation_remoteservicename.md) properties are passed to the [ConnectAsync](streamsocket_connectasync_13692504.md) method on the [StreamSocket](streamsocket.md) to establish a connection.

After a connection is established, the [RemoteAddress](streamsocketinformation_remoteaddress.md) property contains the IP address and the RemotePort property contains the TCP port number of the remote endpoint for the socket connection. Before a connection is established, the [RemoteAddress](streamsocketinformation_remoteaddress.md) property is null and the RemotePort property contains an empty string.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [ConnectAsync](streamsocket_connectasync_13692504.md), [RemoteAddress](streamsocketinformation_remoteaddress.md), [RemoteHostName](streamsocketinformation_remotehostname.md), [RemoteServiceName](streamsocketinformation_remoteservicename.md), [StreamSocket](streamsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
