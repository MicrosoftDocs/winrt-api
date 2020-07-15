---
-api-id: M:Windows.Devices.WiFiDirect.WiFiDirectDevice.FromIdAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.WiFiDirect.WiFiDirectDevice> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.WiFiDirect.WiFiDirectDevice.FromIdAsync

## -description
Creates an instance of the [WiFiDirectDevice](wifidirectdevice.md) class for the specified device interface id.

## -parameters
### -param deviceId
The [DeviceInformation Id](../windows.devices.enumeration/deviceinformation_id.md) of a Wi-Fi Direct device.

## -returns
An asynchronous operation to retrieve the [WiFiDirectDevice](wifidirectdevice.md) that was created.

## -remarks
You can use the [GetDeviceSelector](wifidirectdevice_getdeviceselector_185243134.md) methods to enumerate Wi-Fi Direct devices to determine their interface ids.

## -examples

## -see-also
[FromIdAsync(String, WiFiDirectConnectionParameters)](wifidirectdevice_fromidasync_1400638850.md), [GetDeviceSelector](wifidirectdevice_getdeviceselector_185243134.md), [WiFiDirectDevice sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/WiFiDirectDevice%20sample)
