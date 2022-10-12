---
-api-id: M:Windows.Networking.Vpn.VpnChannel.ActivateForeground(System.String,Windows.Foundation.Collections.ValueSet)
-api-type: winrt method
---

# Windows.Networking.Vpn.VpnChannel.ActivateForeground(System.String,Windows.Foundation.Collections.ValueSet)

<!--
public Windows.Foundation.Collections.ValueSet ActivateForeground (string packageRelativeAppId, Windows.Foundation.Collections.ValueSet sharedContext);
-->

## -description

Activates the VPN app in the foreground. This is often used to let the user enter credentials. You can call **ActivateForeground** only from your implementation of [IVpnPlugin.Connect](/uwp/api/windows.networking.vpn.ivpnplugin.connect). While the app is in the foreground, the regular **Connect** timeout is paused.

The **ActivateForeground** call will be cancelled if there's a long pause (about 10 minutes). If unable to launch, then the plugin should ideally support an authentication method that doesn't need user interface (UI).

Intended to support web-based authentication schemes such as Security Assertion Markup Language (SAML) and Azure Active Directory (AAD) authentication.

## -parameters

### -param packageRelativeAppId

A string containing the package-relative application identifier (PRAID) of the foreground app to launch.

### -param sharedContext

A **ValueSet** object used to pass information to the foreground app. The foreground app can access these from the activation event arguments.

## -returns

A **ValueSet** object containing a Windows Runtime object of your choosing that's passed back from the foreground app to the VPN plugin, indicating the result of the foreground request.

## -remarks

> [!NOTE]
> Calling this API outside of the [IVpnPlugin.Connect](/uwp/api/windows.networking.vpn.ivpnplugin.connect) method implementation in a VPN plug-in will fail.

Using the foreground activation mechanism requires handling the activation in several places.

In your [IVpnPlugin.Connect](/uwp/api/windows.networking.vpn.ivpnplugin.connect) method, you'll call **ActivateForeground** with the correct package-relative application identifier (PRAID), and a **ValueSet** that contains all of the values that you want to send to your foreground app.

In the foreground app, you need to catch the activation. The foreground app will be activated with a [Windows.ApplicationModel.ActivationKind](/uwp/api/windows.applicationmodel.activation.activationkind) value of **VpnForeground**. The activation arguments will be of type [Windows.Networking.Vpn.VpnForegroundActivatedEventArgs](vpnforegroundactivatedeventargs.md), and will include three fields.

1. *[ProfileName](vpnforegroundactivatedeventargs_profilename.md)* (**String**).
2. *[SharedContext](vpnforegroundactivatedeventargs_sharedcontext.md)* ([ValueSet](/uwp/api/windows.foundation.collections.valueset)).
3. *[ActivationOperation](vpnforegroundactivatedeventargs_activationoperation.md)* ([Windows.Networking.Vpn.VpnForegroundActivationOperation](vpnforegroundactivationoperation.md).

The foreground app can then set up your app's user interface (UI) to handle the needed authorization (or whatever data is needed). When done, you must call the [Complete](vpnforegroundactivationoperation_complete_1656373823.md) method of the **ActivationOperation**, passing in a [ValueSet](/uwp/api/windows.foundation.collections.valueset) of values that you want to be returned to the [IVpnPlugin.Connect](/uwp/api/windows.networking.vpn.ivpnplugin.connect) call.

Back in the [IVpnPlugin.Connect](/uwp/api/windows.networking.vpn.ivpnplugin.connect) call, use the **ValueSet** returned from **ActivateForeground** to decide whether the authentication was successful, and handle any errors.

## -see-also

## -examples

## -capabilities
networkingVpnProvider
