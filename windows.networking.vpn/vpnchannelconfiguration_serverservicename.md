---
-api-id: P:Windows.Networking.Vpn.VpnChannelConfiguration.ServerServiceName
-api-type: winrt property
---

<!-- Property syntax
public string ServerServiceName { get; }
-->

# Windows.Networking.Vpn.VpnChannelConfiguration.ServerServiceName

## -description
Gets the service name of the VPN server listening for remote access connections.

## -property-value
The service name of the VPN server listening for remote access connections. Also known as the VPN server port.

## -remarks
> [!NOTE]
> Any call to this API outside of a connected VPN plug-in will fail, as activity and interactions between the VPN plug-in and the system are controlled by the VPN profile. There can only be one VPN profile per process because the VPN plug-in only has one VPN profile mapped to it, and if a caller were to create more than one profile object, they would all refer to the same settings.

## -examples

## -see-also


## -capabilities
networkingVpnProvider