---
-api-id: M:Windows.Networking.Vpn.VpnChannel.AssociateTransport(System.Object,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void AssociateTransport(System.Object mainOuterTunnelTransport, System.Object optionalOuterTunnelTransport)
-->

# Windows.Networking.Vpn.VpnChannel.AssociateTransport

## -description
Prepares and marks the transport for use by the VPN framework as a transport link communicating the VPN plug-in to the VPN server. This call must be performed before any other operations related to the VPN framework APIs.

## -parameters
### -param mainOuterTunnelTransport
An **IInspectable** object for socket transport. This object can be a [Windows.Networking.Sockets.StreamSocket](/uwp/api/windows.networking.sockets.streamsocket) or a [Windows.Networking.DatagramSocket](../windows.networking.sockets/datagramsocket.md). This socket will control the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data. The socket must be unconnected at the point of the call.

### -param optionalOuterTunnelTransport
An optional **IInspectable** object for socket transport. This object can be a [Windows.Networking.Sockets.StreamSocket](/uwp/api/windows.networking.sockets.streamsocket) or a [Windows.Networking.DatagramSocket](../windows.networking.sockets/datagramsocket.md). This socket will control the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data.

## -remarks
If the function succeeds, the return value is **S_OK**, otherwise the function will return an error hresult value describing the specific failure. If the plug-in is not connected, the error will be **E_ACCESSDENIED**.

> [!NOTE]
> Any call to this API outside of a connected VPN plug-in will fail, as activity and interactions between the VPN plug-in and the system are controlled by the VPN profile. The call will fail if the VPN framework does not support the specified type of transport implemented by the *outerTunnelTransport* object. The socket must have not been connected at the time of this call, otherwise the call will fail with an invalid parameter error.

From this method, a plugin may choose between the following combinations of sockets: 
+ One TCP socket ([StreamSocket](../windows.networking.sockets/streamsocket.md)),
+ One UDP socket ([DatagramSocket](../windows.networking.sockets/datagramsocket.md)),
+ Two TCP sockets, or
+ Two sockets, one TCP and one UDP.

## -examples

## -see-also

## -capabilities
networkingVpnProvider
