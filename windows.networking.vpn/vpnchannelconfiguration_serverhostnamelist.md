---
-api-id: P:Windows.Networking.Vpn.VpnChannelConfiguration.ServerHostNameList
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Networking.HostName> ServerHostNameList { get; }
-->

# Windows.Networking.Vpn.VpnChannelConfiguration.ServerHostNameList

## -description
Gets the server hostname of the VPN server to which the VPN plug-in should connect.

## -property-value
The server hostname of the VPN server to which the VPN plug-in should connect.

## -remarks
> [!NOTE]
> Any call to this API outside of a connected VPN plug-in will fail, as activity and interactions between the VPN plug-in and the system are controlled by the VPN profile. There can only be one VPN profile per process because the VPN plug-in only has one VPN profile mapped to it, and if a caller were to create more than one profile object, they would all refer to the same settings.

## -examples

## -see-also


## -capabilities
networkingVpnProvider
