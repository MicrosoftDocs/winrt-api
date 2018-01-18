---
-api-id: P:Windows.Networking.Vpn.VpnPacketBuffer.TransportAffinity
-api-type: winrt property
---

<!-- Property syntax
public uint TransportAffinity { get;  set; }
-->

# Windows.Networking.Vpn.VpnPacketBuffer.TransportAffinity

## -description
Gets or sets a number specifying which transport object to use as specified in the VpnChannel:Start* methods. This allows the selection between the main and the optional transports.

## -property-value
A value of 0 sets this packet to be sent over the main transport. A value of 1 sets this packet to be sent over the optional transport.

## -remarks

## -examples

## -see-also

## -capabilities
networkingVpnProvider
