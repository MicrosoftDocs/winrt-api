---
-api-id: P:Windows.Networking.Vpn.VpnPlugInProfile.VpnPluginPackageFamilyName
-api-type: winrt property
---

<!-- Property syntax
public string VpnPluginPackageFamilyName { get;  set; }
-->

# Windows.Networking.Vpn.VpnPlugInProfile.VpnPluginPackageFamilyName

## -description
Gets or sets the package family name of the VPN plug-in to be used for this VPN plug-in profile. This field is required for VpnPlugInProfile to be valid.

## -property-value
The package family name of the VPN plug-in to be used for this VPN plug-in profile.

## -remarks
If creating or modifying a VPN plug-in profile from the App that is the VPN plug-in, [Package.Current.Id.FamilyName](../windows.applicationmodel/package_current.md) can be used to easily obtain the current package family name at run time.

## -examples

## -see-also


## -capabilities
networkingVpnProvider
