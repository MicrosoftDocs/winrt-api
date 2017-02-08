---
-api-id: P:Windows.Networking.Vpn.VpnChannel.Id
-api-type: winrt property
---

<!-- Property syntax
public uint Id { get; }
-->

# Windows.Networking.Vpn.VpnChannel.Id

## -description
Gets the unique instance ID of a VPN channel. This can be used to simplify demuxing operations between two VPN connection instances.

## -property-value
A number representing the unique ID of the VPN channel.

## -remarks
> [!NOTE]
> Any call to this API outside of a connected VPN plug-in will fail, as activity and interactions between the VPN plug-in and the system are controlled by the VPN profile. There can only be one VPN profile per process because the VPN plug-in only has one VPN profile mapped to it, and if a caller were to create more than one profile object, they would all refer to the same settings.

## -examples

## -see-also


## -capabilities
networkingVpnProvider