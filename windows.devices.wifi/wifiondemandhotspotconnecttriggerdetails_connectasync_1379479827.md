---
-api-id: M:Windows.Devices.WiFi.WiFiOnDemandHotspotConnectTriggerDetails.ConnectAsync
-api-type: winrt method
---

# Windows.Devices.WiFi.WiFiOnDemandHotspotConnectTriggerDetails.ConnectAsync

<!--
public Windows.Foundation.IAsyncOperation<Windows.Devices.WiFi.WiFiOnDemandHotspotConnectionResult> ConnectAsync ();
-->


## -description

Asynchronously notifies the operating system (OS) connection flow to connect to the given hotspot network (a specific SSID/password).

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.onDemandHotspotControl_8wekyb3d8bbwe** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -returns

An asynchronous operation object which, when it completes, contains the result of the connection.

## -remarks

Internally, should the app fail to call this method, the connection flow will time out once the background task process has been ended.

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
