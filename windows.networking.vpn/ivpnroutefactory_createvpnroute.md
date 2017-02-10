---
-api-id: M:Windows.Networking.Vpn.IVpnRouteFactory.CreateVpnRoute(Windows.Networking.HostName,System.Byte)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.Vpn.VpnRoute CreateVpnRoute(Windows.Networking.HostName address, System.Byte prefixSize)
-->

# Windows.Networking.Vpn.IVpnRouteFactory.CreateVpnRoute

## -description
Creates [VpnRoute](vpnroute.md) objects.

## -parameters
### -param address
Represents the ID or the address of the subnet under the route control.

### -param prefixSize
The size (in bits) to be considered by the subnet.

## -returns
Represents a route relative to the VPN channel. It is composed of an address and a prefix size to identify the subnet being routed.

## -remarks

## -examples

## -see-also


## -capabilities
networkingVpnProvider