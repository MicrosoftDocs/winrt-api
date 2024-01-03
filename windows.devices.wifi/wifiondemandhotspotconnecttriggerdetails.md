---
-api-id: T:Windows.Devices.WiFi.WiFiOnDemandHotspotConnectTriggerDetails
-api-type: winrt class
---

# Windows.Devices.WiFi.WiFiOnDemandHotspotConnectTriggerDetails

<!--
public sealed class WiFiOnDemandHotspotConnectTriggerDetails
-->


## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).


Represents details of a [WiFiOnDemandHotspotConnectTrigger](/uwp/api/windows.applicationmodel.background.wifiondemandhotspotconnecttrigger), which is used to notify the app that the user wishes to connect to a specific on-demand hotspot network.

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.onDemandHotspotControl_8wekyb3d8bbwe** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -remarks

When run as a result of a [WiFiOnDemandHotspotConnectTrigger](/uwp/api/windows.applicationmodel.background.wifiondemandhotspotconnecttrigger), your background task code is passed an instance of this class in the [IBackgroundTaskInstance.TriggerDetails](/uwp/api/Windows.ApplicationModel.Background.IBackgroundTaskInstance.TriggerDetails) property.

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
