---
-api-id: M:Windows.Devices.WiFiDirect.Services.WiFiDirectService.FromIdAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.WiFiDirect.Services.WiFiDirectService> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.WiFiDirect.Services.WiFiDirectService.FromIdAsync

## -description
Static method that retrieves a WiFiDirectService instance for a Wi-Fi Direct Service offered by the device with a given device ID.

## -parameters
### -param deviceId
Device ID of the device that advertises the desired Wi-Fi Direct Service.

## -returns
An asynchronous retrieval operation. On successful completion, returns an instance of [WiFiDirectService](wifidirectservice.md) specific to the desired service instance, advertised by the indicated device.

## -remarks
Your code retrieves Device IDs for service advertisers by using the search and enumeration methods in the [Windows.Devices.Enumeration](../windows.devices.enumeration/windows_devices_enumeration.md) namespace.

## -examples

## -see-also
