---
-api-id: M:Windows.Networking.Vpn.VpnChannel.Start(Windows.Foundation.Collections.IVectorView{Windows.Networking.HostName},Windows.Foundation.Collections.IVectorView{Windows.Networking.HostName},Windows.Networking.Vpn.VpnInterfaceId,Windows.Networking.Vpn.VpnRouteAssignment,Windows.Networking.Vpn.VpnNamespaceAssignment,System.UInt32,System.UInt32,System.Boolean,System.Object,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void Start(Windows.Foundation.Collections.IVectorView<Windows.Networking.HostName> assignedClientIPv4list, Windows.Foundation.Collections.IVectorView<Windows.Networking.HostName> assignedClientIPv6list, Windows.Networking.Vpn.VpnInterfaceId vpnInterfaceId, Windows.Networking.Vpn.VpnRouteAssignment routeScope, Windows.Networking.Vpn.VpnNamespaceAssignment namespaceScope, System.UInt32 mtuSize, System.UInt32 maxFrameSize, System.Boolean optimizeForLowCostNetwork, System.Object mainOuterTunnelTransport, System.Object optionalOuterTunnelTransport)
-->

# Windows.Networking.Vpn.VpnChannel.Start

## -description
Creates the VPN channel to be used by the VPN plug-in. It also creates an L3 network interface for applications in the client machine to be able to see the corporate network.

## -parameters
### -param assignedClientIPv4list
A pointer to an IVectorView&lt; Windows.Networking.HostName *&gt; vector specifying the IPv4 address assigned by the VPN server to the VPN client. The address should be set on the VPN L3 interface. If **null**, DHCPv4 is used.

### -param assignedClientIPv6list
A pointer to a [Windows.Networking.HostName](../windows.networking/hostname.md) structure specifying the IPv6 address assigned by the VPN server to the VPN client, and which should be set on the VPN L3 interface. If **null**, DHCPv6 or RD is used.

### -param vpnInterfaceId
A pointer to a VpnInterfaceId.

### -param routeScope
A pointer to Windows.Networking.VpnRouteAssignment class that represents the routes which should be associated / not associated with the VPN interface

### -param namespaceScope
A pointer to Windows.Networking.DomainNameAssignment class that represents the list of name prefixes that are associated to the VPN channel, including its DNS and proxy servers.

### -param mtuSize
A UINT16 value specifying the MTU size of the VPN L3 network interface. This is also the size of the IVpnPacketBuffers in the Receive pool. This value should be configured to be at most 1400.

### -param maxFrameSize
A UINT16 value specifying the max size of the frame defined by the VPN protocol encapsulation without counting the *outerTunnelTransport*. This is also the size of the **IVpnPacketBuffers** in the Send pool. This value should be configured as mtuSize + [size of encapsulation headers], and should be <=1500. If it would be greater than 1500 either mtuSize or encapsulation header size should be reduced as the platform limits the framesize to 1500.

### -param optimizeForLowCostNetwork
A **Boolean** specifying whether the VPN framework should monitor and use low cost networks as they are available. If **TRUE** the VPN framework will invoke the connect() callback to the VPN plug-in to reconnect it whenever the old network was costed and a new low cost network becomes available.

### -param mainOuterTunnelTransport
An *IInspectable* object for socket transport. This object can be a [Windows.Networking.Sockets.DatagramSocket](/uwp/api/windows.networking.sockets.datagramsocket) or a [Windows.Networking.Sockets.StreamSocket](/uwp/api/windows.networking.sockets.streamsocket). This socket controls the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data.

### -param optionalOuterTunnelTransport
An optional *IInspectable* object for socket transport. This object can be a [Windows.Networking.Sockets.DatagramSocket](/uwp/api/windows.networking.sockets.datagramsocket) or a [Windows.Networking.Sockets.StreamSocket](/uwp/api/windows.networking.sockets.streamsocket). This socket controls the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data.

## -remarks
If the function succeeds, the return value is **S_OK**, otherwise the function will return an error hresult value describing the specific failure. If the plug-in is not connected, the error will be **E_ACCESSDENIED**.

> [!NOTE]
> Any call to this API outside of a connected VPN plug-in will fail, as activity and interactions between the VPN plug-in and the system are controlled by the VPN profile. There can only be one VPN profile per process because the VPN plug-in only has one VPN profile mapped to it, and if a caller were to create more than one profile object, they would all refer to the same settings.

On success the ownership of *outertTunnelTransport* is transferred by the VPN framework. Calling this method multiple times with the same parameters will have no effect. Calling this method multiple times with variations in parameter values will make sure the channel is updated with the latest values without any disruptions to other properties.

There can only be one VPN channel per process and hence a VPN plug-in can only have one VPN channel assigned to it. The *mtuSize* must always be smaller than the *maxFrameSize.*

## -examples

## -see-also


## -capabilities
networkingVpnProvider
