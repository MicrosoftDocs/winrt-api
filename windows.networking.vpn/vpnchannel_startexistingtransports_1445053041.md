---
-api-id: M:Windows.Networking.Vpn.VpnChannel.StartExistingTransports(Windows.Foundation.Collections.IVectorView{Windows.Networking.HostName},Windows.Foundation.Collections.IVectorView{Windows.Networking.HostName},Windows.Networking.Vpn.VpnInterfaceId,Windows.Networking.Vpn.VpnRouteAssignment,Windows.Networking.Vpn.VpnDomainNameAssignment,System.UInt32,System.UInt32,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void StartExistingTransports(Windows.Foundation.Collections.IVectorView<Windows.Networking.HostName> assignedClientIPv4list, Windows.Foundation.Collections.IVectorView<Windows.Networking.HostName> assignedClientIPv6list, Windows.Networking.Vpn.VpnInterfaceId vpnInterfaceId, Windows.Networking.Vpn.VpnRouteAssignment assignedRoutes, Windows.Networking.Vpn.VpnDomainNameAssignment assignedDomainName, System.UInt32 mtuSize, System.UInt32 maxFrameSize, System.Boolean Reserved)
-->

# Windows.Networking.Vpn.VpnChannel.StartExistingTransports

## -description
Creates the VPN channel to be used by the VPN plug-in. It also creates an L3 network interface for applications in the client machine to be able to see the corporate network.

## -parameters
### -param assignedClientIPv4list
A pointer to a**Windows.Networking.HostName** structure specifying the IPv4 address assigned by the VPN server to the VPN client. The address should be set on the VPN L3 interface. If null, DHCPv4 is used.

### -param assignedClientIPv6list
A pointer to a **Windows.Networking.HostName** structure specifying the IPv6 address assigned by the VPN server to the VPN client, and which should be set on the VPN L3 interface. If null, DHCPv6 or RD is used.

### -param vpnInterfaceId
A pointer to a **VpnInterfaceId** object.

### -param assignedRoutes
A pointer to a **Windows.Networking.VpnRouteAssignment** class that represents the routes which should be associated / not associated with the VPN interface.

### -param assignedDomainName
A pointer to a **Windows.Networking.DomainNameAssignment** class that represents the list of name prefixes that are associated to the VPN channel, including its DNS and proxy servers.

### -param mtuSize
A UINT16 value specifying the MTU size of the VPN L3 network interface. This is also the size of the **IVpnPacketBuffers** in the Receive pool. This value should be configured to be at most 1400.

### -param maxFrameSize
A UINT16 value specifying the max size of the frame defined by the VPN protocol encapsulation without counting the outerTunnelTransport. This is also the size of the **IVpnPacketBuffers** in the Send pool. This value should be configured as mtuSize + [size of encapsulation headers], and should be <=1500. If it would be greater than 1500 either mtuSize or encapsulation header size should be reduced as the platform limits the framesize to 1500.

### -param Reserved
Reserved.

## -remarks

## -examples

## -see-also


## -capabilities
networkingVpnProvider
