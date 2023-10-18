---
-api-id: M:Windows.Devices.WiFi.WiFiAdapter.ScanAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ScanAsync()
-->

# Windows.Devices.WiFi.WiFiAdapter.ScanAsync

## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Directs this adapter to initiate an asynchronous network scan.

## -returns
An asynchronous scan operation. On successful completion, returns a list of networks scanned by this adapter.

## -remarks
You should call this API from a foreground app. If it is called from a background task, you will see an "Access Denied" error message or a similar message.

## -examples

## -see-also
