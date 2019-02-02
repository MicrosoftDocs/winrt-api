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
A static method that initiates an asynchronous operation to get a [WiFiAdapter](wifiadapter.md) object.

Note that if you do not specify that your app has the [wiFiControl](https://msdn.microsoft.com/library/25b18ba5-e584-4537-9f19-bb2c8c52dfe1) capability in your app manifest, this method fails.

## -parameters
### -param deviceId
The Device ID of the Wi-Fi adapter to be retrieved. Obtain a Device ID through the [Windows.Devices.Enumeration](../windows.devices.enumeration/windows_devices_enumeration.md) namespace.

## -returns
An asynchronous get operation. On successful completion, returns a [WiFiAdapter](wifiadapter.md) object specific to the requested Device ID.

If you do not specify that your app has the [wiFiControl](https://msdn.microsoft.com/library/25b18ba5-e584-4537-9f19-bb2c8c52dfe1) capability in your app manifest, this method fails.

## -remarks

## -examples

## -see-also


## -capabilities
wiFiControl
