---
-api-id: P:Windows.Networking.Vpn.VpnPlugInProfile.AlwaysOn
-api-type: winrt property
---

<!-- Property syntax
public bool AlwaysOn { get;  set; }
-->

# Windows.Networking.Vpn.VpnPlugInProfile.AlwaysOn

## -description
Gets or sets a value that indicates whether the VPN profile is for [Always-On VPN](/windows-server/remote/remote-access/vpn/always-on-vpn/); that is, whether the profile is *capable* of being always connected.

## -property-value
`true` if the VPN profile is *capable* of being always connected, otherwise `false`.

## -remarks
When this property value has the value `true`, the profile is *capable* of being always-on; when the user also click the **always connected** setting, the profile *actually is* always-on.

## -examples

## -see-also
[Remote Access Always-On VPN](/windows-server/remote/remote-access/vpn/always-on-vpn/)

## -capabilities
networkingVpnProvider
