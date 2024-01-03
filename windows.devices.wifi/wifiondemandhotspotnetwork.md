---
-api-id: T:Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork
-api-type: winrt class
---

# Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork

<!--
public sealed class WiFiOnDemandHotspotNetwork
-->


## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).


Represents a device that supports *on-demand hotspot*. The app registers that device with the operating system (OS), where the app can remotely enable the mobile hotspot. By updating properties on this object, the app can signal to the OS to update the user interface (UI). The object is keyed on a caller-chosen globally-unique identifier (GUID) that is intended to identify the device (the [Id](wifiondemandhotspotnetwork_id.md) property).

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.onDemandHotspotControl_8wekyb3d8bbwe** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -remarks

*On-demand hotspot* is the feature in Windows that allows a the Windows client device to view and remotely enable the mobile hotspot/internet sharing access point on a host Windows device (either a PC or a phone), and connect to it. That allows the client device to share the internet connection of the host device. This functionality is exposed to the user by injecting a Wi-Fi network into the client's network list when the user opens the Wi-Fi Quick Settings or Wi-Fi System Settings available networks (Windows 11).

The app is responsible for determining how to communicate with the hotspot to get the metadata, outside of this API.

## -see-also

There are two background task triggers associated with an *on-demand hotspot*:

- [WiFiOnDemandHotspotUpdateMetadataTrigger](/uwp/api/windows.applicationmodel.background.wifiondemandhotspotupdatemetadatatrigger)
- [WiFiOnDemandHotspotConnectTrigger](/uwp/api/windows.applicationmodel.background.wifiondemandhotspotconnecttrigger)

## -examples

[On-Demand Hotspot Sample](/samples/microsoft/windows-universal-samples/ondemandhotspot)

## -capabilities
onDemandHotspotControl
