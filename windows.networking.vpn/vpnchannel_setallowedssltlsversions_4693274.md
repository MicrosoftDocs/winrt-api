---
-api-id: M:Windows.Networking.Vpn.VpnChannel.SetAllowedSslTlsVersions(System.Object,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void SetAllowedSslTlsVersions(System.Object tunnelTransport, System.Boolean useTls12)
-->

# Windows.Networking.Vpn.VpnChannel.SetAllowedSslTlsVersions

## -description
Not supported.

## -parameters
### -param tunnelTransport
An optional **IInspectable** object for socket transport. This object can be a [Windows.Networking.Sockets.DatagramSocket](/uwp/api/windows.networking.sockets.datagramsocket) or a [Windows.Networking.Sockets.StreamSocket](/uwp/api/windows.networking.sockets.streamsocket). This socket controls the connection to the VPN server and will be used to send encapsulated IP packets and receive encapsulated data.

### -param useTls12
If Transport Security Layer 1.2 should be used, it is TRUE; otherwise, it is FALSE.

## -remarks

## -examples

## -see-also


## -capabilities
networkingVpnProvider
