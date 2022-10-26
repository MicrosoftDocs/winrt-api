---
-api-id: T:Windows.ApplicationModel.Background.WiFiOnDemandHotspotUpdateMetadataTrigger
-api-type: winrt class
---

# Windows.ApplicationModel.Background.WiFiOnDemandHotspotUpdateMetadataTrigger

<!--
public sealed class WiFiOnDemandHotspotUpdateMetadataTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger
-->


## -description

Represents an event that causes a background task to run when the user opens the operating system (OS) Wi-Fi network list, as if to connect to a new Wi-Fi network.

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.onDemandHotspotControl_8wekyb3d8bbwe** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -remarks

You should use this as an indication to update the operating system (OS) metadata on the injected network, such as reporting to the OS that the on-demand hotspot should be hidden because the phone is no longer in physical proximity to the Windows device. However, the app is free to report this information at any time, such as when the user unlocks their device.

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
