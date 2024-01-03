---
-api-id: M:Windows.Devices.WiFi.WiFiAdapter.FromIdAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.WiFi.WiFiAdapter> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.WiFi.WiFiAdapter.FromIdAsync

## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

A static method that initiates an asynchronous operation to get a [WiFiAdapter](wifiadapter.md) object.

Note that if you do not specify that your app has the [wiFiControl](/windows/uwp/packaging/app-capability-declarations) capability in your app manifest, this method fails.

## -parameters
### -param deviceId
The Device ID of the Wi-Fi adapter to be retrieved. Obtain a Device ID through the [Windows.Devices.Enumeration](../windows.devices.enumeration/windows_devices_enumeration.md) namespace.

## -returns
An asynchronous get operation. On successful completion, returns a [WiFiAdapter](wifiadapter.md) object specific to the requested Device ID.

If you do not specify that your app has the [wiFiControl](/windows/uwp/packaging/app-capability-declarations) capability in your app manifest, this method fails.

## -remarks

## -examples

## -see-also


## -capabilities
wiFiControl
