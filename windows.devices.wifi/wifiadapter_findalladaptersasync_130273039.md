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

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

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
