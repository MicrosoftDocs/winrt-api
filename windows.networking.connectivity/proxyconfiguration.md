---
-api-id: T:Windows.Networking.Connectivity.ProxyConfiguration
-api-type: winrt class
---

<!-- Class syntax.
public class ProxyConfiguration : Windows.Networking.Connectivity.IProxyConfiguration
-->

# Windows.Networking.Connectivity.ProxyConfiguration

## -description
Represents the proxy configuration for the current user. 

> [!NOTE]
> This class is not supported on Windows Phone.

## -remarks
A [ProxyConfiguration](proxyconfiguration.md) object is returned by calling the [GetProxyConfigurationAsync](networkinformation_getproxyconfigurationasync.md) method on the [NetworkInformation](networkinformation.md) object. If the [GetProxyConfigurationAsync](networkinformation_getproxyconfigurationasync.md) method is successful, the [IAsyncOperation(ProxyConfiguration)](../windows.foundation/iasyncoperation_1.md) handler for the method is passed a [ProxyConfiguration](proxyconfiguration.md) object.

The proxy configuration returned is for the *uri* parameter passed to the [GetProxyConfigurationAsync](networkinformation_getproxyconfigurationasync.md) method. The *uri* parameter contains a hostname or IP address for the target endpoint and a service name, port number, or protocol scheme.

In a UWP app, the [StreamSocket](../windows.networking.sockets/streamsocket.md) class supports connecting to a remote endpoint when proxies are required to plumb the connection. This support for proxies is automatic and transparent to the app. For more detailed information, see the remarks on *Support for proxies* in the [StreamSocket](../windows.networking.sockets/streamsocket.md) class reference.

## -examples

## -see-also
[GetProxyConfigurationAsync](networkinformation_getproxyconfigurationasync.md), [StreamSocket](../windows.networking.sockets/streamsocket.md)

## -capabilities
internetClient, privateNetworkClientServer
