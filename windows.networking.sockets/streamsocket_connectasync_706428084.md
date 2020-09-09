---
-api-id: M:Windows.Networking.Sockets.StreamSocket.ConnectAsync(Windows.Networking.EndpointPair,Windows.Networking.Sockets.SocketProtectionLevel)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ConnectAsync(Windows.Networking.EndpointPair endpointPair, Windows.Networking.Sockets.SocketProtectionLevel protectionLevel)
-->

# Windows.Networking.Sockets.StreamSocket.ConnectAsync

## -description
Starts an asynchronous operation on a [StreamSocket](streamsocket.md) object to connect to a remote network destination specified as an [EndpointPair](../windows.networking/endpointpair.md) object and a [SocketProtectionLevel](socketprotectionlevel.md) enumeration. This method is not callable from JavaScript.

## -parameters
### -param endpointPair
An [EndpointPair](../windows.networking/endpointpair.md) object that specifies local hostname or IP address, local service name or TCP port, the remote hostname or remote IP address, and the remote service name or remote TCP port for the remote network destination.

### -param protectionLevel
The protection level that represents the integrity and encryption for a [StreamSocket](streamsocket.md) object.

## -returns
An asynchronous connect operation on a [StreamSocket](streamsocket.md) object.

## -remarks
If the [EndpointPair](../windows.networking/endpointpair.md) object passed in the *endpointPair* parameter contains null for the [LocalHostName](../windows.networking/endpointpair_localhostname.md) property, then the system will supply the local IP address that will be used. If the [EndpointPair](../windows.networking/endpointpair.md) object passed in the *endpointPair* parameter contains an empty string for the [LocalServiceName](../windows.networking/endpointpair_localservicename.md) property, then the system will supply the local TCP port that will be used.

If the [EndpointPair](../windows.networking/endpointpair.md) object passed in the *endpointPair* parameter contains null for the [LocalServiceName](../windows.networking/endpointpair_localservicename.md) property, then an error will occur.

The [ConnectAsync(EndpointPair, SocketProtectionLevel) method is not exposed in JavaScript. This method can't be called from JavaScript since it has the same number of arguments as the [ConnectAsync(HostName, String)](streamsocket_connectasync_1841953676.md) method.

Apps written in JavaScript can't connect a [StreamSocket](streamsocket.md) using an [EndpointPair](../windows.networking/endpointpair.md) using SSL directly. In order to connect an [EndpointPair](../windows.networking/endpointpair.md) using SSL, JavaScript apps can use the following code instead.



```javascript

var clientSocket = new Windows.Networking.Sockets.StreamSocket();
var remoteName = new Windows.Networking.HostName("www.contoso.com");
var myEndpointPair = EndpointPair();

// Set properties needed on the EndpointPair
// We only set remote properties and the localServiceName,
// But the localHostName could also be set

myEndpointPair.localServiceName = "12345";
myEndpointPair.remoteHostName = remoteName;
myEndpointPair.remoteServiceName = "http";

// First connect the socket without SSL
clientSocket.connectAsync(myEendpointPair>).then(function () {
    // Now upgrade the connection to SSL
    clientSocket.upgradeToSslAsync(SocketProtectionLevel.Ssl).then(function () {
        // now connected using SSL
    }
}   

```

When the *protectionLevel* parameter is set to a value that requires SSL or TLS, the socket connect operation may not timeout if the remote endpoint does not support SSL or TLS. This can occur if initial connect operation succeeds but the remote endpoint does not terminate the connection during the SSL handshake. To protect against this situation, an app should set a timeout on the connect operation when requesting SSL/TLS and abort the operation if the timeout expires. For more information on setting a timeout using JavaScript on socket operations, see [How to set timeouts on socket operations ](/previous-versions/windows/apps/jj710177(v=win.10)). For more information on setting a timeout using VB, C#, or C++ on socket operations, see [How to set timeouts on socket operations ](/previous-versions/windows/apps/jj710176(v=win.10)).

In a UWP app, the [StreamSocket](streamsocket.md) class supports connecting to a remote endpoint when proxies are required to complete the connection. This support for proxies is automatic and transparent to the app. Connecting through proxies is not supported when a local host address is specified, so the [LocalHostName](../windows.networking/endpointpair_localhostname.md) property passed in the *endpointPair* parameter must be null. For more detailed information, see the remarks on *Support for proxies* in the [StreamSocket](streamsocket.md) class reference.

In a Windows Phone 8.x app, the [StreamSocket](streamsocket.md) class does not provide automatic support for proxies.

## -examples

## -see-also
[How to set timeouts on socket operations ](/previous-versions/windows/apps/jj710177(v=win.10)), [How to set timeouts on socket operations ](/previous-versions/windows/apps/jj710176(v=win.10)), [ConnectAsync(EndpointPair)](streamsocket_connectasync_13692504.md), [ConnectAsync(HostName, String)](streamsocket_connectasync_1841953676.md), [ConnectAsync(HostName, String, SocketProtectionLevel)](streamsocket_connectasync_945708620.md), [ConnectAsync(HostName, String, SocketProtectionLevel, NetworkAdapter)](streamsocket_connectasync_238604852.md), [EndpointPair](../windows.networking/endpointpair.md), [SocketProtectionLevel](socketprotectionlevel.md)

## -capabilities
internetClientServer, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone]
