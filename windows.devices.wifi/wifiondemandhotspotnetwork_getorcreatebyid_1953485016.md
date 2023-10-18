---
-api-id: M:Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork.GetOrCreateById(System.Guid)
-api-type: winrt method
---

# Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork.GetOrCreateById(System.Guid)

<!--
public static Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork GetOrCreateById (Guid networkId);
-->


## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).


If the operating system (OS) is already configured with a hotspot from the calling app, then **GetOrCreateById** retrieves the [WiFiOnDemandHotspotNetwork](wifiondemandhotspotnetwork.md) object that corresponds to the given *networkId*. Otherwise, the method creates a new network for that id.

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.onDemandHotspotControl_8wekyb3d8bbwe** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -parameters

### -param networkId

The globally-unique identifier (GUID) that identifies a [WiFiOnDemandHotspotNetwork](wifiondemandhotspotnetwork.md) object.

## -returns

The object that was created or retrieved.

## -remarks

* The Id can be any value the app chooses to use to distinguish multiple on-demand hotspots. However, for best performance with ephemeral connections, we recommend reusing the same Id and updating the SSID and Password instead of creating new networks for each one.
* The Id need only be unique within an app.
* The calling app must have package identity.

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
