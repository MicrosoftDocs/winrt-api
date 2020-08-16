---
-api-id: M:Windows.Networking.Vpn.VpnChannel.StartWithTrafficFilter(Windows.Foundation.Collections.IVectorView{Windows.Networking.HostName},Windows.Foundation.Collections.IVectorView{Windows.Networking.HostName},Windows.Networking.Vpn.VpnInterfaceId,Windows.Networking.Vpn.VpnRouteAssignment,Windows.Networking.Vpn.VpnDomainNameAssignment,System.UInt32,System.UInt32,System.Boolean,System.Object,System.Object,Windows.Networking.Vpn.VpnTrafficFilterAssignment)
-api-type: winrt method
---

<!-- Method syntax
public void StartWithTrafficFilter(Windows.Foundation.Collections.IVectorView<Windows.Networking.HostName> assignedClientIpv4List, Windows.Foundation.Collections.IVectorView<Windows.Networking.HostName> assignedClientIpv6List, Windows.Networking.Vpn.VpnInterfaceId vpnInterfaceId, Windows.Networking.Vpn.VpnRouteAssignment assignedRoutes, Windows.Networking.Vpn.VpnDomainNameAssignment assignedNamespace, System.UInt32 mtuSize, System.UInt32 maxFrameSize, System.Boolean reserved, System.Object mainOuterTunnelTransport, System.Object optionalOuterTunnelTransport, Windows.Networking.Vpn.VpnTrafficFilterAssignment assignedTrafficFilters)
-->

# Windows.Networking.Vpn.VpnChannel.StartWithTrafficFilter

## -description
Creates the VPN channel to be used by the VPN plug-in. It also creates an L3 network interface for applications in the client machine to be able to see the corporate network. It allows the specification of traffic filters to use in per-app VPN scenarios.

## -parameters
### -param assignedClientIpv4List
A list of **Windows.Networking.HostName** objects specifying the IPv4 address(es) assigned by the VPN server to the VPN client, and which should be set on the VPN L3 interface. If null, DHCPv4 is used.

### -param assignedClientIpv6List
A list of **Windows.Networking.HostName** objects specifying the IPv6 address(es) assigned by the VPN server to the VPN client, and which should be set on the VPN L3 interface. If null, DHCPv6 or RD is used.

### -param vpnInterfaceId
A **VpnInterfaceId** object.

### -param assignedRoutes
A **Windows.Networking.VpnRouteAssignment** object that represents the routes that should be associated / not associated with the VPN interface.

### -param assignedNamespace
A **Windows.Networking.DomainNameAssignment** object that represents the list of name prefixes that are associated with the VPN channel, including its DNS and proxy servers.

### -param mtuSize
A UINT16 value specifying the MTU size of the VPN L3 network interface. This is also the size of the **IVpnPacketBuffers** in the Receive pool.

### -param maxFrameSize
A UINT16 value specifying the max size of the frame defined by the VPN protocol encapsulation without counting the outerTunnelTransport. This is also the size of the **IVpnPacketBuffers** in the Send pool.

### -param reserved
Reserved.

### -param mainOuterTunnelTransport
An **IInspectable** object for socket transport. This object can be a [Windows.Networking.Sockets.DatagramSocket](/uwp/api/windows.networking.sockets.datagramsocket), a [Windows.Networking.Sockets.StreamSocket](/uwp/api/windows.networking.sockets.streamsocket), or a [Windows.Networking.Sockets.StreamWebSocket](/uwp/api/windows.networking.sockets.streamwebsocket). This socket will control the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data. The socket must be unconnected at the point of the call.

### -param optionalOuterTunnelTransport
An optional **IInspectable** object for socket transport. This object can be a [Windows.Networking.Sockets.DatagramSocket](/uwp/api/windows.networking.sockets.datagramsocket), a [Windows.Networking.Sockets.StreamSocket](/uwp/api/windows.networking.sockets.streamsocket), or a [Windows.Networking.Sockets.StreamWebSocket](/uwp/api/windows.networking.sockets.streamwebsocket). This socket will control the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data.

### -param assignedTrafficFilters
A **VpnTrafficFilterAssignment** object, which allows the specification of traffic filters to a VPN channel.

## -remarks

## -examples

## -see-also

## -capabilities
networkingVpnProvider
