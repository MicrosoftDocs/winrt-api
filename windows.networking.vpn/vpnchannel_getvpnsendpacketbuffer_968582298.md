---
-api-id: M:Windows.Networking.Vpn.VpnChannel.GetVpnSendPacketBuffer
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.Vpn.VpnPacketBuffer GetVpnSendPacketBuffer()
-->

# Windows.Networking.Vpn.VpnChannel.GetVpnSendPacketBuffer

## -description
Retrieves a [VpnPacketBuffer](vpnpacketbuffer.md) object from the send packet buffer pool to use in encapsulation and transmission of a data packet from the client network stack to the VPN server.

## -returns
The requested packet buffer object.

## -remarks
Any **IVpnPacketBuffer** object requested by the plugin must eventually be returned to the VPN platform (i.e. via [IVpnPlugIn.Encapsulate](ivpnplugin_encapsulate_494498240.md) or [IVpnPlugin.Decapsulate](ivpnplugin_decapsulate_1667754039.md)). Otherwise the plugin may be unable to request new buffers until the outstanding buffers have been returned.

## -examples

## -see-also


## -capabilities
networkingVpnProvider
