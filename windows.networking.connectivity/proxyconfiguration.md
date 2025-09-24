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

## -remarks
A [ProxyConfiguration](proxyconfiguration.md) object is returned by calling the 
[GetProxyConfigurationAsync](networkinformation_getproxyconfigurationasync_1451648549.md) method on the 
[NetworkInformation](networkinformation.md) object. If the 
[GetProxyConfigurationAsync](networkinformation_getproxyconfigurationasync_1451648549.md) method is successful, the 
[IAsyncOperation(ProxyConfiguration)](../windows.foundation/iasyncoperation_1.md) handler for the method is passed a 
[ProxyConfiguration](proxyconfiguration.md) object.

The proxy configuration returned is for the *uri* parameter passed to the 
[GetProxyConfigurationAsync](networkinformation_getproxyconfigurationasync_1451648549.md) method. The *uri* parameter contains 
a hostname or IP address for the target endpoint and a service name, port number, or protocol scheme.

[!NOTE]
In UWP applications, the [StreamSocket](../windows.networking.sockets/streamsocket.md) class supports connecting to remote 
endpoints when proxies are required to establish the connection. This support for proxies is automatic and transparent to the 
application, eliminating the need for manual proxy configuration in most scenarios.

### Proxy configuration properties

The [ProxyConfiguration](proxyconfiguration.md) class provides the following properties:

- [ProxyUris](proxyconfiguration_proxyuris.md): A collection of proxy server URIs that should be used for the target endpoint
- [CanConnectDirectly](proxyconfiguration_canconnectdirectly.md): Indicates whether a direct connection to the target endpoint 
  is possible without using a proxy

### When to use proxy configuration

Most applications do not need to manually handle proxy configuration because higher-level networking APIs handle proxy 
resolution automatically. However, proxy configuration information may be useful for:

- Custom network implementations that need proxy awareness
- Network diagnostic and troubleshooting tools
- Applications that need to display proxy information to users
- Low-level networking scenarios where automatic proxy handling is not available

For detailed information about automatic proxy support, see the remarks section of the 
[StreamSocket](../windows.networking.sockets/streamsocket.md) class reference.

## -examples

## -see-also
[NetworkInformation.GetProxyConfigurationAsync](networkinformation_getproxyconfigurationasync_1451648549.md),
[NetworkInformation](networkinformation.md),
[StreamSocket](../windows.networking.sockets/streamsocket.md),
[ConnectionProfile](connectionprofile.md)

## -capabilities
internetClient, privateNetworkClientServer
