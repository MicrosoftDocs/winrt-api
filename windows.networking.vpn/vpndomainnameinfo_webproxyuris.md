---
-api-id: P:Windows.Networking.Vpn.VpnDomainNameInfo.WebProxyUris
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Foundation.Uri> WebProxyUris { get; }
-->

# Windows.Networking.Vpn.VpnDomainNameInfo.WebProxyUris

## -description
Gets a web proxy URI to be used when connecting to a resource in the specified namespace. This value differs from [WebProxyServers](vpndomainnameinfo_webproxyservers.md) in that the URI can be specify a custom port number, while the [WebProxyServers](vpndomainnameinfo_webproxyservers.md) value assumes port 80.

Note that even though the property name is plural, the returned list of URIs never has more than one element.

## -property-value
A list of web proxy server URIs to be used when connecting to a resource in the specified namespace.

## -remarks
To specify a custom port number, use URI syntax. For example, to use port 56789 at example.com, specify `http://example.com:56789` to the URI constructor.

## -examples

## -see-also
