---
-api-id: P:Windows.Networking.Vpn.VpnDomainNameInfo.DnsServers
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Networking.HostName> DnsServers { get; }
-->

# Windows.Networking.Vpn.VpnDomainNameInfo.DnsServers

## -description
Gets a list of DNS servers to perform DNS resolution against when resolving a name in the namespace.

## -property-value
A list of DNS servers to perform DNS resolution against when resolving a name in the namespace. Windows has a limit of 50 DNS suffixes that can be set. Windows name resolution will apply each suffix in order. Long DNS suffix lists may impact performance.

## -remarks

## -examples

## -see-also


## -capabilities
networkingVpnProvider
