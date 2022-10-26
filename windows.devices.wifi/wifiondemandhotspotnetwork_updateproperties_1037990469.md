---
-api-id: M:Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork.UpdateProperties(Windows.Devices.WiFi.WiFiOnDemandHotspotNetworkProperties)
-api-type: winrt method
---

# Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork.UpdateProperties(Windows.Devices.WiFi.WiFiOnDemandHotspotNetworkProperties)

<!--
public void UpdateProperties (Windows.Devices.WiFi.WiFiOnDemandHotspotNetworkProperties newProperties);
-->


## -description

Sets on a [WiFiOnDemandHotspotNetwork](wifiondemandhotspotnetwork.md) object various properties of the hotspot network, such as battery percentage, display name, availability, and SSID/password. If any property is invalid, **UpdateProperties** throws an invalid argument exception.

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.onDemandHotspotControl_8wekyb3d8bbwe** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -parameters

### -param newProperties

An object representing the properties to set.

## -remarks

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
