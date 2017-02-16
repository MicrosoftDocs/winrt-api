---
-api-id: M:Windows.Networking.Vpn.VpnChannel.GetVpnReceivePacketBuffer
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.Vpn.VpnPacketBuffer GetVpnReceivePacketBuffer()
-->

# Windows.Networking.Vpn.VpnChannel.GetVpnReceivePacketBuffer

## -description
Requests a [VpnPacketBuffer](vpnpacketbuffer.md) object from the receive packet buffer pool to be used in the decapsulation or injection of a received packet from the VPN server into the local network stack

## -returns
The requested packet buffer object. 
<!--BUGBUG: Can this return some equivalent of "NULL" or an empty buffer, if there's no data? "Requests" in the abstract implies as much...-->

## -remarks

## -examples

## -see-also


## -capabilities
networkingVpnProvider