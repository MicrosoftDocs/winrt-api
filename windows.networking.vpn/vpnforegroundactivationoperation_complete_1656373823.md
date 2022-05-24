---
-api-id: M:Windows.Networking.Vpn.VpnForegroundActivationOperation.Complete(Windows.Foundation.Collections.ValueSet)
-api-type: winrt method
---

# Windows.Networking.Vpn.VpnForegroundActivationOperation.Complete(Windows.Foundation.Collections.ValueSet)

<!--
public void Complete (Windows.Foundation.Collections.ValueSet result);
-->

## -description

Represents a VPN foreground operation. When you're done handling a foreground operation, you must call **Complete** from your foreground app to mark that the activation is done. Doing so will resume the control flow in the plugin. See [VpnChannel.ActivateForeground](vpnchannel_activateforeground_291551645.md).

## -parameters

### -param result

A [ValueSet](/uwp/api/windows.foundation.collections.valueset) of values that you want to be returned to the [IVpnPlugin.Connect](/uwp/api/windows.networking.vpn.ivpnplugin.connect) call. The **ValueSet** will be returned to the plugin, allowing you to pass information from the foreground app to the plugin task.

## -remarks

## -see-also

## -examples

## -capabilities
networkingVpnProvider
