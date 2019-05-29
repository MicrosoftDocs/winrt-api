---
-api-id: M:Windows.Devices.WiFi.WiFiAdapter.RequestAccessAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.WiFi.WiFiAccessStatus> RequestAccessAsync()
-->

# Windows.Devices.WiFi.WiFiAdapter.RequestAccessAsync

## -description
A static method for determining whether the current user can access any of the Wi-Fi adapters on this device.

Note that if you do not specify that your app has the [wiFiControl](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations) capability in your app manifest, this method always returns DeniedBySystem.

Always returns **DeniedBySystem** on Xbox.

## -returns
An asynchronous access operation. On successful completion, returns a status enumeration value describing whether the current user can access any Wi-Fi adapter.

Note that if you do not specify that your app has the [wiFiControl](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations) capability in your app manifest, this method always returns **DeniedBySystem**.

Always returns **DeniedBySystem** on Xbox.

## -remarks

## -examples

## -see-also
