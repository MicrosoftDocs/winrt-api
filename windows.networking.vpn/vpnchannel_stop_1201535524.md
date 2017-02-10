---
-api-id: M:Windows.Networking.Vpn.VpnChannel.Stop
-api-type: winrt method
---

<!-- Method syntax
public void Stop()
-->

# Windows.Networking.Vpn.VpnChannel.Stop

## -description
Destroys a previously established VPN channel object. Disassociates and closes the *outerTunnelTransport* connection to the VPN server.

## -remarks
> [!NOTE]
> Any call to this API outside of a connected VPN plug-in will fail, as activity and interactions between the VPN plug-in and the system are controlled by the VPN profile. There can only be one VPN profile per process because the VPN plug-in only has one VPN profile mapped to it, and if a caller were to create more than one profile object, they would all refer to the same settings.

## -examples

## -see-also


## -capabilities
networkingVpnProvider