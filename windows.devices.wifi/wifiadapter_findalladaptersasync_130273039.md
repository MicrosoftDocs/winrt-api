---
-api-id: M:Windows.Devices.WiFi.WiFiAdapter.FindAllAdaptersAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Devices.WiFi.WiFiAdapter>> FindAllAdaptersAsync()
-->

# Windows.Devices.WiFi.WiFiAdapter.FindAllAdaptersAsync

## -description

> [!IMPORTANT]
> Location consent is now required for Wi-Fi BSSID access. For details on how this affects apps using Wi-Fi or location APIs,
> see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

A static method that initiates an asynchronous operation to enumerate all Wi-Fi adapters in the system.

Note that if you do not specify that your app has the [wiFiControl](/windows/uwp/packaging/app-capability-declarations) capability in your app manifest, this method fails.

## -returns
An asynchronous enumeration operation. On successful completion, returns a list of available Wi-Fi adapters.

If you do not specify that your app has the [wiFiControl](/windows/uwp/packaging/app-capability-declarations) capability in your app manifest, this method fails.

## -remarks

## -examples

## -see-also


## -capabilities
wiFiControl
