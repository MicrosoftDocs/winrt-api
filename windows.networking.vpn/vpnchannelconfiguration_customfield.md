---
-api-id: P:Windows.Networking.Vpn.VpnChannelConfiguration.CustomField
-api-type: winrt property
---

<!-- Property syntax
public string CustomField { get; }
-->

# Windows.Networking.Vpn.VpnChannelConfiguration.CustomField

## -description
Gets the custom configuration as a string which the VPN plug-in parses to configure VPN vendor specific settings. The field is a string to allow XML as the data format of the configuration.

## -property-value
The custom configuration string data which the VPN plug-in parses to configure VPN vendor specific settings.

## -remarks
> [!NOTE]
> Any call to this API outside of a connected VPN plug-in will fail, as activity and interactions between the VPN plug-in and the system are controlled by the VPN profile. There can only be one VPN profile per process because the VPN plug-in only has one VPN profile mapped to it, and if a caller were to create more than one profile object, they would all refer to the same settings.

## -examples

## -see-also


## -capabilities
networkingVpnProvider
