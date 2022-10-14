---
-api-id: P:Windows.Devices.WiFi.WiFiOnDemandHotspotNetworkProperties.Availability
-api-type: winrt property
---

# Windows.Devices.WiFi.WiFiOnDemandHotspotNetworkProperties.Availability

<!--
public Windows.Devices.WiFi.WiFiOnDemandHotspotAvailability Availability { get; set; }
-->


## -description

Gets or sets a value indicating whether the hotspot is in (or out of) range. You can use this info to determine whether the hotspot should be injected into (or removed from) the network list.

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **onDemandHotspotControl** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -property-value

## -remarks

Windows may hide stale networks before the operating system (OS) removes the network from the list, at which point **Availability** would return [WiFiOnDemandHotspotAvailability.Unavailable](wifiondemandhotspotavailability.md).

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
