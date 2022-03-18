---
-api-id: M:Windows.Networking.Sockets.StreamSocket.ConnectAsync(Windows.Networking.HostName,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ConnectAsync(Windows.Networking.HostName remoteHostName, System.String remoteServiceName)
-->

# Windows.Networking.Sockets.StreamSocket.ConnectAsync

## -description
Starts an asynchronous operation on a [StreamSocket](streamsocket.md) object to connect to a remote network destination specified by a remote hostname and a remote service name.

## -parameters
### -param remoteHostName
The hostname or IP address of the remote network destination. For Bluetooth RFCOMM, this is a MAC address.

### -param remoteServiceName
The service name or TCP port number of the remote network destination. For Bluetooth RFCOMM, this is the Bluetooth address.

## -returns
An asynchronous connect operation on a [StreamSocket](streamsocket.md) object.

## -remarks
The *remoteHostName* and *remoteServiceName* parameters must be provided. If the *remoteHostName* is null or the *remoteServiceName* is null or an empty string, an error will occur.

In a UWP app, the [StreamSocket](streamsocket.md) class supports connecting to a remote endpoint when proxies are required to complete the connection. This support for proxies is automatic and transparent to the app. For more detailed information, see the remarks on *Support for proxies* in the [StreamSocket](streamsocket.md) class reference.

In a Windows Phone 8.x app, the [StreamSocket](streamsocket.md) class does not provide automatic support for proxies.

## -examples

## -see-also
[How to set timeouts on socket operations ](/previous-versions/windows/apps/jj710177(v=win.10)), [How to set timeouts on socket operations ](/previous-versions/windows/apps/jj710176(v=win.10)), [ConnectAsync(EndpointPair)](streamsocket_connectasync_13692504.md), [ConnectAsync(EndpointPair, SocketProtectionLevel)](streamsocket_connectasync_706428084.md), [ConnectAsync(HostName, String, SocketProtectionLevel)](streamsocket_connectasync_945708620.md), [ConnectAsync(HostName, String, SocketProtectionLevel, NetworkAdapter)](streamsocket_connectasync_238604852.md), [HostName](../windows.networking/hostname.md)

## -capabilities
internetClientServer, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone]
