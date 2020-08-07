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

## -remarks
Any **IVpnPacketBuffer** object requested by the plugin must eventually be returned to the VPN platform (i.e. via [IVpnPlugIn.Encapsulate](ivpnplugin_encapsulate_494498240.md) or [IVpnPlugin.Decapsulate](ivpnplugin_decapsulate_1667754039.md)). Otherwise the plugin may be unable to request new buffers until the outstanding buffers have been returned.

## -examples

## -see-also


## -capabilities
networkingVpnProvider
