---
-api-id: M:Windows.Networking.Vpn.VpnManagementAgent.UpdateProfileFromObjectAsync(Windows.Networking.Vpn.IVpnProfile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.Vpn.VpnManagementErrorStatus> UpdateProfileFromObjectAsync(Windows.Networking.Vpn.IVpnProfile profile)
-->

# Windows.Networking.Vpn.VpnManagementAgent.UpdateProfileFromObjectAsync

## -description
Updates a VPN profile based on an input object.

## -remarks
A UWP VPN app can only update per-app profiles; it cannot update any other VPN profile. Apps that attempt to modify a per-user profile may instead create or modify a per-app profile; the new per-app profile will have the same name as the per-user profile.

## -parameters
### -param profile
A **VpnProfile** object.

## -returns
An enum value indicating the error status.

## -remarks

## -examples

## -see-also


## -capabilities
networkingVpnProvider
