---
-api-id: M:Windows.Networking.Vpn.IVpnPlugIn.Encapsulate(Windows.Networking.Vpn.VpnChannel,Windows.Networking.Vpn.VpnPacketBufferList,Windows.Networking.Vpn.VpnPacketBufferList)
-api-type: winrt method
---

# Windows.Networking.Vpn.IVpnPlugIn.Encapsulate(Windows.Networking.Vpn.VpnChannel,Windows.Networking.Vpn.VpnPacketBufferList,Windows.Networking.Vpn.VpnPacketBufferList)

<!--
public void Encapsulate (Windows.Networking.Vpn.VpnChannel channel, Windows.Networking.Vpn.VpnPacketBufferList packets, Windows.Networking.Vpn.VpnPacketBufferList encapulatedPackets);
-->

## -description
This method instructs the VPN plug-in to prepare the indicated L3 IP packet for transmission to the VPN server. The process might include any encapsulation specific to the VPN protocol.

## -parameters
### -param channel
The VPN channel object representing the instance VPN connection of the VPN plug-in to the VPN server.

### -param packets
An L3 IP packets originated by the client machine TCP/IP stack and that needs to be processed to be sent to the corporate network.

### -param encapsulatedPackets
An buffer containing an encapsulated IP packet (framed in a specific VPN protocol message and or potentially encrypted) that is ready to be sent to the VPN server through the **outerTunnelTransport.**

## -remarks
If an error occurs the packets will simply be dropped. It is required that any **IVpnPacketBuffer** object, either passed to the method in the *packets* parameter or requested by the plugin, be returned to the VPN framework. The VPN framework will then send the **IVpnPacketBuffer** objects in *encapsulatedPackets* via one of the transports specified during Connect and will clean up the remaining **IVpnPacketBuffer** objects in *packets*.

## -examples

## -see-also

## -capabilities
networkingVpnProvider
