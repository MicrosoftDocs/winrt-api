---
-api-id: P:Windows.Networking.Vpn.VpnChannel.Configuration
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Vpn.VpnChannelConfiguration Configuration { get; }
-->

# Windows.Networking.Vpn.VpnChannel.Configuration

## -description
Gets or sets a **VpnChannelConfiguration** object corresponding to the configuration of the [VpnChannel](vpnchannel.md) and which dictates how to establish the communication with the VPN server.

## -property-value
A **VpnChannelConfiguration** object containing the configuration pertaining the [VpnChannel](vpnchannel.md) object.

## -remarks
> [!NOTE]
> Any call to this API outside of a connected VPN plug-in will fail, as activity and interactions between the VPN plug-in and the system are controlled by the VPN profile. There can only be one VPN profile per process because the VPN plug-in only has one VPN profile mapped to it, and if a caller were to create more than one profile object, they would all refer to the same settings.

## -examples

## -see-also

## -capabilities
networkingVpnProvider
