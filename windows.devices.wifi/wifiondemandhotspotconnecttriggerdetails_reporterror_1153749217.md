---
-api-id: M:Windows.Devices.WiFi.WiFiOnDemandHotspotConnectTriggerDetails.ReportError(Windows.Devices.WiFi.WiFiOnDemandHotspotConnectStatus)
-api-type: winrt method
---

# Windows.Devices.WiFi.WiFiOnDemandHotspotConnectTriggerDetails.ReportError(Windows.Devices.WiFi.WiFiOnDemandHotspotConnectStatus)

<!--
public void ReportError (Windows.Devices.WiFi.WiFiOnDemandHotspotConnectStatus status);
-->


## -description

Notifies the operating system (OS) of an error activating the given hotspot network.

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **onDemandHotspotControl** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -parameters

### -param status

The status to report.

## -remarks

Internally, should the app fail to call this method, the connection flow will time out once the background task process has been ended.

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
