---
-api-id: M:Windows.Networking.Vpn.IVpnPlugIn.GetKeepAlivePayload(Windows.Networking.Vpn.VpnChannel,Windows.Networking.Vpn.VpnPacketBuffer@)
-api-type: winrt method
---

<!-- Method syntax
public void GetKeepAlivePayload(Windows.Networking.Vpn.VpnChannel channel, Windows.Networking.Vpn.VpnPacketBuffer keepAlivePacket)
-->

# Windows.Networking.Vpn.IVpnPlugIn.GetKeepAlivePayload

## -description
This method instructs the VPN plug-in to compute and return a Keep alive payload ready to be sent to the VPN server.

## -parameters
### -param channel
The VPN channel object representing the instance VPN connection of the VPN plug-in to the VPN server.

### -param keepAlivePacket
An VPN protocol specific message payload used by the VPN Plug-in to indicate to the server that the client and its VPN connection are still alive.

## -remarks
This method is only called at a time determined by the VPN infrastructure to be the optimal for the network in which the client machine is connected. If an error occurs the VPN infrastructure will skip sending the keep alive payload.

## -examples

## -see-also


## -capabilities
networkingVpnProvider