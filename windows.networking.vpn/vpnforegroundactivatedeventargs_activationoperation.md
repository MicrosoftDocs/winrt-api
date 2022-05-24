---
-api-id: P:Windows.Networking.Vpn.VpnForegroundActivatedEventArgs.ActivationOperation
-api-type: winrt property
---

# Windows.Networking.Vpn.VpnForegroundActivatedEventArgs.ActivationOperation

<!--
public Windows.Networking.Vpn.VpnForegroundActivationOperation ActivationOperation { get; }
-->

## -description

Gets an object representing a VPN foreground operation.

When you're done handling a foreground operation, you must call the [Complete](vpnforegroundactivationoperation_complete_1656373823.md) method of this [VpnForegroundActivationOperation](vpnforegroundactivationoperation.md) object, passing in a [ValueSet](/uwp/api/windows.foundation.collections.valueset) of values that you want to be returned to the [IVpnPlugin.Connect](/uwp/api/windows.networking.vpn.ivpnplugin.connect) call. See [VpnChannel.ActivateForeground](vpnchannel_activateforeground_291551645.md).

## -property-value

A [VpnForegroundActivationOperation](vpnforegroundactivationoperation.md) object representing a VPN foreground operation.

## -remarks

## -see-also

## -examples

## -capabilities
networkingVpnProvider
