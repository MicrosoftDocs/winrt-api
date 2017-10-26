---
-api-id: P:Windows.Networking.Connectivity.ProxyConfiguration.CanConnectDirectly
-api-type: winrt property
---

<!-- Property syntax
public bool CanConnectDirectly { get; }
-->

# Windows.Networking.Connectivity.ProxyConfiguration.CanConnectDirectly

## -description
Gets a value that indicates if this configuration can connect directly. 

> [!NOTE]
> This class property is not supported on Windows Phone.

## -property-value
TRUE if this configuration can connect directly; otherwise, FALSE.

## -remarks
There may be cases where [CanConnectDirectly](proxyconfiguration_canconnectdirectly.md) returns **false**, yet it does not mean you cannot access the resource directly. A local network could be configured to have support for both a proxy and network address translation (NAT). The WPAD script used to supply proxy information to a web browser or [HttpClient](../windows.web.http/httpclient.md) tells Windows that it should use the proxy. But if you disregard the policy you can still go directly through NAT. This can cause problems when the remote endpoint is not expecting a connection from a proxy.

In a UWP app, the [StreamSocket](../windows.networking.sockets/streamsocket.md) class supports connecting to a remote endpoint when proxies are required to complete the connection. This support for proxies is automatic and transparent to the app. For more detailed information, see the remarks on *Support for proxies* in the [StreamSocket](../windows.networking.sockets/streamsocket.md) class reference.

## -examples

## -see-also
[StreamSocket](../windows.networking.sockets/streamsocket.md)