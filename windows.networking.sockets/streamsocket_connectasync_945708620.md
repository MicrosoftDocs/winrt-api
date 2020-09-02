---
-api-id: M:Windows.Networking.Sockets.StreamSocket.ConnectAsync(Windows.Networking.HostName,System.String,Windows.Networking.Sockets.SocketProtectionLevel)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ConnectAsync(Windows.Networking.HostName remoteHostName, System.String remoteServiceName, Windows.Networking.Sockets.SocketProtectionLevel protectionLevel)
-->

# Windows.Networking.Sockets.StreamSocket.ConnectAsync

## -description
Starts an asynchronous operation on a [StreamSocket](streamsocket.md) object to connect to a remote destination specified by a remote hostname, a remote service name, and a [SocketProtectionLevel](socketprotectionlevel.md).

## -parameters
### -param remoteHostName
The hostname or IP address of the remote network destination. For Bluetooth RFCOMM, this is a MAC address.

### -param remoteServiceName
The service name or TCP port number of the remote network destination. For Bluetooth RFCOMM, this is the Bluetooth address.

### -param protectionLevel
The protection level that represents the integrity and encryption for the [StreamSocket](streamsocket.md) object.

## -returns
An asynchronous connect operation on a [StreamSocket](streamsocket.md) object.

## -remarks
The *remoteHostName* and *remoteServiceName* parameters must be provided. If the *remoteHostName* is null or the *remoteServiceName* is null or an empty string, an error will occur.

When the *protectionLevel* parameter is set to a value that requires SSL or TLS, the socket connect operation may not timeout if the remote network destination does not support SSL or TLS. This can occur if initial connect operation succeeds but the remote host does not terminate the connection during the SSL handshake. To protect against this situation, an app should set a timeout on the connect operation when requesting SSL/TLS and abort the operation if the timeout expires. For more information on setting a timeout using JavaScript on socket operations, see [How to set timeouts on socket operations ](/previous-versions/windows/apps/jj710177(v=win.10)). For more information on setting a timeout using VB, C#, or C++ on socket operations, see [How to set timeouts on socket operations ](/previous-versions/windows/apps/jj710176(v=win.10)).

In a UWP app, the [StreamSocket](streamsocket.md) class supports connecting to a remote endpoint when proxies are required to complete the connection. This support for proxies is automatic and transparent to the app. For more detailed information, see the remarks on *Support for proxies* in the [StreamSocket](streamsocket.md) class reference.

In a Windows Phone 8.x app, the [StreamSocket](streamsocket.md) class does not provide automatic support for proxies.

## -examples

## -see-also
[How to set timeouts on socket operations ](/previous-versions/windows/apps/jj710177(v=win.10)), [How to set timeouts on socket operations ](/previous-versions/windows/apps/jj710176(v=win.10)), [ConnectAsync(EndpointPair)](streamsocket_connectasync_13692504.md), [ConnectAsync(HostName, String)](streamsocket_connectasync_1841953676.md), [ConnectAsync(EndpointPair, SocketProtectionLevel)](streamsocket_connectasync_706428084.md), [ConnectAsync(HostName, String, SocketProtectionLevel, NetworkAdapter)](streamsocket_connectasync_238604852.md), [HostName](../windows.networking/hostname.md), [SocketProtectionLevel](socketprotectionlevel.md)

## -capabilities
internetClientServer, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone]
