---
-api-id: M:Windows.Networking.Vpn.VpnDomainNameInfo.#ctor(System.String,Windows.Networking.Vpn.VpnDomainNameType,Windows.Foundation.Collections.IIterable{Windows.Networking.HostName},Windows.Foundation.Collections.IIterable{Windows.Networking.HostName})
-api-type: winrt method
---

<!-- Method syntax
public VpnDomainNameInfo(System.String name, Windows.Networking.Vpn.VpnDomainNameType nameType, Windows.Foundation.Collections.IIterable<Windows.Networking.HostName> dnsServerList, Windows.Foundation.Collections.IIterable<Windows.Networking.HostName> proxyServerList)
-->

# Windows.Networking.Vpn.VpnDomainNameInfo.VpnDomainNameInfo

## -description
Allows the VPN plug-in to construct this object to be added to a [VpnDomainNameAssignment](vpndomainnameassignment.md) object.

## -parameters
### -param name
The domain name. This could be an FQDN, or a DNS suffix.

### -param nameType
An enum value indicating whether the namespace in question is a FQDN, or a DNS suffix.

### -param dnsServerList
A list of DNS servers to perform DNS resolution against when resolving a name in the namespace.

### -param proxyServerList
A list of web proxy servers to be used when connecting to a resource in the specified namespace.

## -remarks

## -examples

## -see-also


## -capabilities
networkingVpnProvider
