---
-api-id: M:Windows.Networking.Vpn.IVpnDomainNameInfoFactory.CreateVpnDomainNameInfo(System.String,Windows.Networking.Vpn.VpnDomainNameType,Windows.Foundation.Collections.IIterable{Windows.Networking.HostName},Windows.Foundation.Collections.IIterable{Windows.Networking.HostName})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.Vpn.VpnDomainNameInfo CreateVpnDomainNameInfo(System.String name, Windows.Networking.Vpn.VpnDomainNameType nameType, Windows.Foundation.Collections.IIterable<Windows.Networking.HostName> dnsServerList, Windows.Foundation.Collections.IIterable<Windows.Networking.HostName> proxyServerList)
-->

# Windows.Networking.Vpn.IVpnDomainNameInfoFactory.CreateVpnDomainNameInfo

## -description
Creates a [VpnDomainNameInfo](vpndomainnameinfo.md) object.

## -parameters
### -param name
The domain name. This could be an FQDN, or a DNS suffix.

### -param nameType
An enum value indicating whether the namespace in question is a FQDN, or a DNS suffix.

### -param dnsServerList
A list of DNS servers to perform DNS resolution against when resolving a name in the namespace.

### -param proxyServerList
A list of web proxy servers to be used when connecting to a resource in the specified namespace.

## -returns
Specifies the name policy for a specific namespace. It can specify the DNS servers to use for name resolution of the namespace, the web proxies to use when connecting to the namespace, or whether it should be exempted from the policy itself.

## -remarks

## -examples

## -see-also


## -capabilities
networkingVpnProvider
