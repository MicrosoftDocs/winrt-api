---
-api-id: T:Windows.ApplicationModel.Background.WiFiOnDemandHotspotConnectTrigger
-api-type: winrt class
---

# Windows.ApplicationModel.Background.WiFiOnDemandHotspotConnectTrigger

<!--
public sealed class WiFiOnDemandHotspotConnectTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger
-->


## -description

Represents an event that causes a background task to run when the user wishes to connect to a specific on-demand hotspot network.

Your background task code should cast the value of the [IBackgroundTaskInstance.TriggerDetails](/uwp/api/Windows.ApplicationModel.Background.IBackgroundTaskInstance.TriggerDetails) property to [WiFiOnDemandHotspotConnectTriggerDetails](/uwp/api/windows.devices.wifi.wifiondemandhotspotconnecttriggerdetails).

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.onDemandHotspotControl_8wekyb3d8bbwe** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.
    
## -remarks

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
