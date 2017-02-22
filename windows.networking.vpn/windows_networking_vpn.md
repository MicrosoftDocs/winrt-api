---
-api-id: N:Windows.Networking.Vpn
-api-type: winrt namespace
---

# Windows.Networking.Vpn

## -description
This API enables you to create, edit and manage Virtual Private Network (VPN) connections, and to write plugins for controlling a VPN connection using the Windows VPN Platform.

To use this API, you must specify the **networkingVpnProvider** capability in your application manifest. To manually add this capability, copy the following line into your manifest, inside the `<Capabilities>` tag.

```xml

<rescap:Capability Name="networkingVpnProvider" />
```

If your app is using this API and you wish to publish your app to the Microsoft Store, special permissions must be provisioned for your Microsoft developer account, or the VPN calls will fail at runtime. This permission is not needed if the application is side-loaded or installed through a different method.

To request permission to release your VPN app through the Microsoft Store,  go to the [Windows Developer Support](https://developer.microsoft.com/windows/support) page and choose **Submit an Incident**. Indicate your request to publish your VPN Plug-In through the Microsoft Store.

If you have any questions about the VPN API, contact [msftvpnapi@microsoft.com](mailto:msftvpnapi@microsoft.com).

## -remarks

## -examples

## -see-also


## -capabilities
networkingVpnProvider