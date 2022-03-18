---
-api-id: M:Windows.Networking.Sockets.StreamSocket.ConnectAsync(Windows.Networking.EndpointPair)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ConnectAsync(Windows.Networking.EndpointPair endpointPair)
-->

# Windows.Networking.Sockets.StreamSocket.ConnectAsync

## -description
Starts an asynchronous operation on a [StreamSocket](streamsocket.md) object to connect to a remote network destination specified as an [EndpointPair](../windows.networking/endpointpair.md) object.

## -parameters
### -param endpointPair
An [EndpointPair](../windows.networking/endpointpair.md) object that specifies the local hostname or IP address, the local service name or TCP port, the remote hostname or remote IP address, and the remote service name or remote TCP port for the remote network destination.

## -returns
An asynchronous connect operation on a [StreamSocket](streamsocket.md) object.

## -remarks
If the [EndpointPair](../windows.networking/endpointpair.md) object passed in the *endpointPair* parameter contains null for the [LocalHostName](../windows.networking/endpointpair_localhostname.md) property, then the system will supply the local IP address that will be used. If the [EndpointPair](../windows.networking/endpointpair.md) object passed in the *endpointPair* parameter contains an empty string for the [LocalServiceName](../windows.networking/endpointpair_localservicename.md) property, then the system will supply the local TCP port that will be used.

In a UWP app, the [StreamSocket](streamsocket.md) class supports connecting to a remote endpoint when proxies are required to complete the connection. This support for proxies is automatic and transparent to the app. Connecting through proxies is not supported when a local host address is specified, so the [LocalHostName](../windows.networking/endpointpair_localhostname.md) property passed in the *endpointPair* parameter must be null. For more detailed information, see the remarks on *Support for proxies* in the [StreamSocket](streamsocket.md) class reference.

In a Windows Phone 8.x app, the [StreamSocket](streamsocket.md) class does not provide automatic support for proxies.

## -examples

## -see-also
[How to set timeouts on socket operations ](/previous-versions/windows/apps/jj710177(v=win.10)), [How to set timeouts on socket operations ](/previous-versions/windows/apps/jj710176(v=win.10)), [ConnectAsync(HostName, String)](streamsocket_connectasync_1841953676.md), [ConnectAsync(EndpointPair, SocketProtectionLevel)](streamsocket_connectasync_706428084.md), [ConnectAsync(HostName, String, SocketProtectionLevel)](streamsocket_connectasync_945708620.md), [ConnectAsync(HostName, String, SocketProtectionLevel, NetworkAdapter)](streamsocket_connectasync_238604852.md), [EndpointPair](../windows.networking/endpointpair.md)

## -capabilities
internetClientServer, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone]
