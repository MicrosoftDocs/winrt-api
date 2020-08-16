---
-api-id: M:Windows.Networking.Vpn.VpnManagementAgent.UpdateProfileFromObjectAsync(Windows.Networking.Vpn.IVpnProfile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.Vpn.VpnManagementErrorStatus> UpdateProfileFromObjectAsync(Windows.Networking.Vpn.IVpnProfile profile)
-->

# Windows.Networking.Vpn.VpnManagementAgent.UpdateProfileFromObjectAsync

## -description

Updates a virtual private network (VPN) profile based on an input object.

## -remarks

A Universal Windows Platform (UWP) VPN app can update only per-app profiles; it can't update any other VPN profile. An app that attempts to modify a per-user profile can instead create or modify a per-app profile; the new per-app profile will have the same name as the per-user profile.

## -parameters

### -param profile

A VPN profile object&mdash;an object that implements the [IVpnProfile](/uwp/api/windows.networking.vpn.ivpnprofile) interface, such as [VpnNativeProfile](/uwp/api/windows.networking.vpn.vpnnativeprofile) or [VpnPlugInProfile](/uwp/api/windows.networking.vpn.vpnpluginprofile).

## -returns

An enum value indicating the error status.

## -remarks

## -examples

## -see-also

## -capabilities

networkingVpnProvider
