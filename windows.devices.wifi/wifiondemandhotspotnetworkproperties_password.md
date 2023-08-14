---
-api-id: P:Windows.Devices.WiFi.WiFiOnDemandHotspotNetworkProperties.Password
-api-type: winrt property
---

# Windows.Devices.WiFi.WiFiOnDemandHotspotNetworkProperties.Password

<!--
public Windows.Security.Credentials.PasswordCredential Password { get; set; }
-->


## -description

Gets or sets a value containing the password of the hotspot network.

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.onDemandHotspotControl_8wekyb3d8bbwe** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -property-value

A value containing the password of the hotspot network.

## -remarks

Hotspot networks must be secured with a password - enterprise networks and open networks are not supported.

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
