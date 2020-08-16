---
-api-id: T:Windows.Networking.Vpn.VpnNativeProfile
-api-type: winrt class
---

<!-- Class syntax.
public class VpnNativeProfile : Windows.Networking.Vpn.IVpnNativeProfile, Windows.Networking.Vpn.IVpnNativeProfile2, Windows.Networking.Vpn.IVpnProfile
-->

# Windows.Networking.Vpn.VpnNativeProfile

## -description
Represents a profile for an OS Native/Inbox VPN protocol.

## -remarks
Using **VpnNativeProfile** is approximately equivalent to using the **Add a VPN connection** dialog, in that you can specify a server, sign-in information, and other info, and then Windows takes care of the VPN connection from there. Consequently, you can't use **VpnNativeProfile** to capture received packets, nor to trigger a background task.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ConnectionStatus |
| 1607 | 14393 | RequireVpnClientAppUI |

## -examples

## -see-also
[IVpnProfile](ivpnprofile.md)

## -capabilities
networkingVpnProvider
