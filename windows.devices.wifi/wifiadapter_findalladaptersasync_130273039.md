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
A static method that initiates an asynchronous operation to enumerate all Wi-Fi adapters in the system.

Note that if you do not specify that your app has the [wiFiControl](https://msdn.microsoft.com/library/25b18ba5-e584-4537-9f19-bb2c8c52dfe1) capability in your app manifest, this method fails.

## -returns
An asynchronous enumeration operation. On successful completion, returns a list of available Wi-Fi adapters.

If you do not specify that your app has the [wiFiControl](https://msdn.microsoft.com/library/25b18ba5-e584-4537-9f19-bb2c8c52dfe1) capability in your app manifest, this method fails.

## -remarks

## -examples

## -see-also


## -capabilities
wiFiControl
