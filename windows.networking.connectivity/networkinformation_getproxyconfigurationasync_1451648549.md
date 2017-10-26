---
-api-id: M:Windows.Networking.Connectivity.NetworkInformation.GetProxyConfigurationAsync(Windows.Foundation.Uri)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.Connectivity.ProxyConfiguration> GetProxyConfigurationAsync(Windows.Foundation.Uri uri)
-->

# Windows.Networking.Connectivity.NetworkInformation.GetProxyConfigurationAsync

## -description
Gets proxy configuration for a connection using the specified URI.

> [!NOTE]
> This class method is not supported on Windows Phone.

## -parameters
### -param uri
The proxy configuration URI.

## -returns
Information about the connection proxy.

## -remarks
The *uri* parameter passed to the [GetProxyConfigurationAsync](networkinformation_getproxyconfigurationasync.md) method should contain a hostname or IP address for the target endpoint and service name, port number, or protocol scheme.

If the [GetProxyConfigurationAsync](networkinformation_getproxyconfigurationasync.md) method is successful, a [ProxyConfiguration](proxyconfiguration.md) object for the specified *uri* parameter is returned by the [IAsyncOperation(ProxyConfiguration)](../windows.foundation/iasyncoperation_1.md) handler.

In a UWP app, the [StreamSocket](../windows.networking.sockets/streamsocket.md) class supports connecting to a remote endpoint when proxies are required to complete the connection. This support for proxies is automatic and transparent to the app. For more detailed information, see the remarks on *Support for proxies* in the [StreamSocket](../windows.networking.sockets/streamsocket.md) class reference.

## -examples

## -see-also
[ProxyConfiguration](proxyconfiguration.md), [StreamSocket](../windows.networking.sockets/streamsocket.md)