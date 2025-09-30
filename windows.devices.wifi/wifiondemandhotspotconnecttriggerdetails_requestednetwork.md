---
-api-id: P:Windows.Devices.WiFi.WiFiOnDemandHotspotConnectTriggerDetails.RequestedNetwork
-api-type: winrt property
---

# Windows.Devices.WiFi.WiFiOnDemandHotspotConnectTriggerDetails.RequestedNetwork

<!--
public Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork RequestedNetwork { get; }
-->

## -description

> [!IMPORTANT]
> Location consent is now required for Wi-Fi BSSID access. For details on how this affects apps using Wi-Fi or location APIs,
> see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Gets a [WiFiOnDemandHotspotNetwork](wifiondemandhotspotnetwork.md) object representing the hotspot network that the user is requesting to connect to.


> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.onDemandHotspotControl_8wekyb3d8bbwe** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -property-value

An object representing the hotspot network that the user is requesting to connect to.

## -remarks

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
