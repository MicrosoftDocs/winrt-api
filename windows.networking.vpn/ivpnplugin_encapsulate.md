---
-api-id: M:Windows.Networking.Vpn.IVpnPlugIn.Encapsulate(Windows.Networking.Vpn.VpnChannel,Windows.Networking.Vpn.VpnPacketBufferList,Windows.Networking.Vpn.VpnPacketBufferList)
-api-type: winrt method
---

<!-- Method syntax
public void Encapsulate(Windows.Networking.Vpn.VpnChannel channel, Windows.Networking.Vpn.VpnPacketBufferList packets, Windows.Networking.Vpn.VpnPacketBufferList encapulatedPackets)
-->

# Windows.Networking.Vpn.IVpnPlugIn.Encapsulate

## -description
This method instructs the VPN plug-in to prepare the indicated L3 IP packet for transmission to the VPN server. The process might include any encapsulation specific to the VPN protocol.

## -parameters
### -param channel
The VPN channel object representing the instance VPN connection of the VPN plug-in to the VPN server.

### -param packets
An L3 IP packets originated by the client machine TCP/IP stack and that needs to be processed to be sent to the corporate network.

### -param encapulatedPackets
An buffer containing an encapsulated IP packet (framed in a specific VPN protocol message and or potentially encrypted) that is ready to be sent to the VPN server through the **outerTunnelTransport.**

## -remarks
If an error occurs the packet will be simply dropped. Once the method returns the ownership of any **IVpnPacketBuffer** objects returned in *encapulatedPackets* and the original IP packet is transferred to the VPN framework. The VPN framework will send the returned **IVpnPacketBuffer *** encapulatedPackets* directly into the **outerTunnelTransport**.

## -examples

## -see-also


## -capabilities
networkingVpnProvider