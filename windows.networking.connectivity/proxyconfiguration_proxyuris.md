---
-api-id: P:Windows.Networking.Connectivity.ProxyConfiguration.ProxyUris
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Foundation.Uri> ProxyUris { get; }
-->

# Windows.Networking.Connectivity.ProxyConfiguration.ProxyUris

## -description
Gets a list of URIs for the proxies from the proxy configuration. 

> [!NOTE]
> This class property is not supported on Windows Phone.

## -property-value
A list of URIs for the proxy configuration.

## -remarks
The Web Proxy Auto-Discovery Protocol (WPAD) is used by web browsers and other apps to locate a proxy configuration file. This proxy auto-config (PAC) file defines the proxy server that should be used to retrieve a specific URI or whether to bypass the proxy for certain URIs. The PAC allows different proxies to be defined for different URIs.

The [ProxyUris](proxyconfiguration_proxyuris.md) property contains a list of URIs that an app should connect directly to and bypass the proxy.

In a UWP app, the [StreamSocket](../windows.networking.sockets/streamsocket.md) class supports connecting to a remote endpoint when proxies are required to complete the connection. This support for proxies is automatic and transparent to the app. For more detailed information, see the remarks on *Support for proxies* in the [StreamSocket](../windows.networking.sockets/streamsocket.md) class reference.

## -examples

## -see-also
