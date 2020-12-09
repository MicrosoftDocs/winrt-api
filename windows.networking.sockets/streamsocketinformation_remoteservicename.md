---
-api-id: P:Windows.Networking.Sockets.StreamSocketInformation.RemoteServiceName
-api-type: winrt property
---

<!-- Property syntax
public string RemoteServiceName { get; }
-->

# Windows.Networking.Sockets.StreamSocketInformation.RemoteServiceName

## -description
Get the service name or TCP port number of the remote network destination associated with a [StreamSocket](streamsocket.md) object.

## -property-value
The service name or TCP port number of the remote network destination.

## -remarks
The RemoteServiceName property represents the remote service name or TCP port number for the remote network destination associated with a [StreamSocket](streamsocket.md) object. The remote service name or TCP port that a [StreamSocket](streamsocket.md) object connects to is passed in the *remoteServiceName* parameter to the [ConnectAsync](streamsocket_connectasync_13692504.md) method on the [StreamSocket](streamsocket.md).

The RemoteServiceName property can be one of the following:


+ A numeric literal for a TCP port number (80 for the TCP port typically used for the HTTP protocol, for example).
+ A string alias for a port number ("http", for example) that matches a string in the following file on the local computer: %WINDIR%\system32\drivers\etc\services
+ A service name that can be resolved by a namespace provider using a SRV record.
The [RemoteHostName](streamsocketinformation_remotehostname.md) property represents the remote service name or TCP port number for the remote network destination associated with a [StreamSocket](streamsocket.md) object.

After a connection is established, the [RemoteAddress](streamsocketinformation_remoteaddress.md) property contains the IP address and the [RemotePort](streamsocketinformation_remoteport.md) property contains the TCP port number of the remote endpoint for the socket connection.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [ConnectAsync](streamsocket_connectasync_13692504.md), [RemoteAddress](streamsocketinformation_remoteaddress.md), [RemoteHostName](streamsocketinformation_remotehostname.md), [RemotePort](streamsocketinformation_remoteport.md), [StreamSocket](streamsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
