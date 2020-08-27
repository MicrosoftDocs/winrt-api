---
-api-id: P:Windows.Networking.Vpn.VpnNativeProfile.AlwaysOn
-api-type: winrt property
---

<!-- Property syntax
public bool AlwaysOn { get;  set; }
-->

# Windows.Networking.Vpn.VpnNativeProfile.AlwaysOn

## -description
Gets or sets a value that indicates whether the profile is for [Always On VPN](https://docs.microsoft.com/windows-server/remote/remote-access/vpn/always-on-vpn/). If true, indicates that the VPN profile is capable of being always connected.

## -property-value
`true` if the VPN profile is always connected, otherwise `false`.

## -remarks
When set, the profile will be capable to being always on. The user must click the 'always connected' setting to make the profile be always-on.

## -examples

## -see-also
[Remote Access Always On VPN](https://docs.microsoft.com/windows-server/remote/remote-access/vpn/always-on-vpn/)

## -capabilities
networkingVpnProvider
