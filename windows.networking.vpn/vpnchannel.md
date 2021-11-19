---
-api-id: T:Windows.Networking.Vpn.VpnChannel
-api-type: winrt class
---

<!-- Class syntax.
public class VpnChannel : Windows.Networking.Vpn.IVpnChannel, Windows.Networking.Vpn.IVpnChannel2
-->

# Windows.Networking.Vpn.VpnChannel

## -description
Provides methods to create and destroy a VPN channel, and methods to perform buffer management. A VPN channel is the object in the system that links the network traffic data flow between the VPN plug-in's VPN server socket and the client machine network stack.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | AddAndAssociateTransport |
| 1803 | 17134 | CurrentRequestTransportContext |
| 1803 | 17134 | GetSlotTypeForTransportContext |
| 1803 | 17134 | ReplaceAndAssociateTransport |
| 1803 | 17134 | StartReconnectingTransport |
| 1803 | 17134 | StartWithTrafficFilter(IEnumerable&lt;HostName&gt;,IEnumerable&lt;HostName&gt;,VpnInterfaceId,VpnRouteAssignment,VpnDomainNameAssignment,UInt32,UInt32,Boolean,IEnumerableIEnumerable&lt;Object&gt;,VpnTrafficFilterAssignment) |

## -examples

## -see-also


## -capabilities
networkingVpnProvider
