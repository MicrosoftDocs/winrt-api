---
-api-id: M:Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork.GetOrCreateById(System.Guid)
-api-type: winrt method
---

# Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork.GetOrCreateById(System.Guid)

<!--
public static Windows.Devices.WiFi.WiFiOnDemandHotspotNetwork GetOrCreateById (Guid networkId);
-->


## -description

If the operating system (OS) is already configured with a hotspot from the calling app, then **GetOrCreateById** retrieves the [WiFiOnDemandHotspotNetwork](wifiondemandhotspotnetwork.md) object that corresponds to the given *networkId*. Otherwise, the method creates a new network for that id.

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **onDemandHotspotControl** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -parameters

### -param networkId

The globally-unique identifier (GUID) that identifies a [WiFiOnDemandHotspotNetwork](wifiondemandhotspotnetwork.md) object.

## -returns

The object that was created or retrieved.

## -remarks

The id is unique per calling app, but it might be the same between apps.

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
