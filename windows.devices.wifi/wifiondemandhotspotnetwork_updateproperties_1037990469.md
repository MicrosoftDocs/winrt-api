---
-api-id: M:Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork.UpdateProperties(Windows.Devices.WiFi.WiFiOnDemandHotspotNetworkProperties)
-api-type: winrt method
---

# Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork.UpdateProperties(Windows.Devices.WiFi.WiFiOnDemandHotspotNetworkProperties)

<!--
public void UpdateProperties (Windows.Devices.WiFi.WiFiOnDemandHotspotNetworkProperties newProperties);
-->


## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).


Sets on a [WiFiOnDemandHotspotNetwork](wifiondemandhotspotnetwork.md) object various properties of the hotspot network, such as battery percentage, display name, availability, and SSID/password. If any property is invalid, **UpdateProperties** throws an invalid argument exception.

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.onDemandHotspotControl_8wekyb3d8bbwe** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -parameters

### -param newProperties

An object representing the properties to set.

## -remarks

`UpdateMetadata` should be called regularly by the app, even if no properties have changed. This is to ensure that Windows will show the network in the Wi-Fi available networks list (in other words, so Windows doesn't hide it for being stale). We recommend registering for the [WiFiOnDemandHotspotUpdateMetadataTrigger](/uwp/api/windows.applicationmodel.background.wifiondemandhotspotupdatemetadatatrigger) background task and calling `UpdateMetadata` there.

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
