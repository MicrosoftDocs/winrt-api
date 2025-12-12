---
-api-id: P:Windows.Networking.Connectivity.ProxyConfiguration.CanConnectDirectly
-api-type: winrt property
---

<!-- Property syntax
public bool CanConnectDirectly { get; }
-->

# Windows.Networking.Connectivity.ProxyConfiguration.CanConnectDirectly

## -description
Gets a value that indicates whether this configuration can connect directly.

## -property-value
Returns `true` when this configuration can connect directly; otherwise, `false`.

## -remarks
There may be cases where `CanConnectDirectly` returns `false`, yet the resource remains reachable directly. A local
network can support both a proxy and network address translation (NAT). The WPAD script used to supply proxy
information to a web browser or [HttpClient](../windows.web.http/httpclient.md) tells Windows to use the proxy.
Disregarding that policy and going directly through NAT can cause problems when the remote endpoint is not expecting a
proxy-less connection.

In a UWP app, the [StreamSocket](../windows.networking.sockets/streamsocket.md) class supports connecting to a remote
endpoint when proxies are required to complete the connection. This proxy support is automatic and transparent to the
app. For more detailed information, see the remarks on *Support for proxies* in the
[StreamSocket](../windows.networking.sockets/streamsocket.md) class reference.

## -examples

## -see-also

