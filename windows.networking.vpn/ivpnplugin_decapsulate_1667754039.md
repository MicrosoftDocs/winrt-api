---
-api-id: M:Windows.Networking.Vpn.IVpnPlugIn.Decapsulate(Windows.Networking.Vpn.VpnChannel,Windows.Networking.Vpn.VpnPacketBuffer,Windows.Networking.Vpn.VpnPacketBufferList,Windows.Networking.Vpn.VpnPacketBufferList)
-api-type: winrt method
---

<!-- Method syntax
public void Decapsulate(Windows.Networking.Vpn.VpnChannel channel, Windows.Networking.Vpn.VpnPacketBuffer encapBuffer, Windows.Networking.Vpn.VpnPacketBufferList decapsulatedPackets, Windows.Networking.Vpn.VpnPacketBufferList controlPacketsToSend)
-->

# Windows.Networking.Vpn.IVpnPlugIn.Decapsulate

## -description
This method instructs the VPN plug-in to prepare receive a buffer from the VPN server **outerTunnelTransport**, extract any number of IP packets encapsulated in the buffer, and return the IP packets together with any other reply buffers that are needed to be sent back through the **outerTunnelTransport** to the VPN server.

## -parameters
### -param channel
The VPN channel object representing the instance VPN connection of the VPN plug-in to the VPN server.

### -param encapBuffer
A buffer originated from the VPN server and received through the **outerTunnelTransport.**

### -param decapsulatedPackets
An **IVpnPacketBuffer** chain representing any L3 IP packets extracted and decapsulated from the buffer and which need to be injected through the VPN interface to be received by the client machine's TCP/IP stack.

### -param controlPacketsToSend
An **IVpnPacketBuffer** chain representing any control messages that VPN plug-in is required by its protocol specification to reply back to the VPN server.

## -remarks
If an error occurs the packets will simply be dropped. It is required that any **IVpnPacketBuffer** objects requested by the plugin be returned to the VPN framework via either the *decapsulatedPackets* chain, to inject into the client TCP/IP stack, or the *controlPacketsToSend* chain, to reply back to the VPN server. The VPN framework will send all the [VpnPacketBufferList](vpnpacketbufferlist.md) chained on *decapsulatedPackets* as unique IP packets to the VPN interface.


## -examples

## -see-also


## -capabilities
networkingVpnProvider
