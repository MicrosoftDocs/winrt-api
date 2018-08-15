---
-api-id: M:Windows.Devices.WiFiDirect.WiFiDirectDevice.FromIdAsync(System.String,Windows.Devices.WiFiDirect.WiFiDirectConnectionParameters)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.WiFiDirect.WiFiDirectDevice> FromIdAsync(System.String deviceId, Windows.Devices.WiFiDirect.WiFiDirectConnectionParameters connectionParameters)
-->

# Windows.Devices.WiFiDirect.WiFiDirectDevice.FromIdAsync

## -description
Creates an instance of the [WiFiDirectDevice](wifidirectdevice.md) class for the specified device interface id with specific connection parameters.

## -parameters
### -param deviceId
The [DeviceInformation Id](../windows.devices.enumeration/deviceinformation_id.md) of a Wi-Fi Direct device.

### -param connectionParameters
Connection parameters for a Wi-Fi Direct connect/pairing operation.

## -returns
An asynchronous operation to retrieve the [WiFiDirectDevice](wifidirectdevice.md) that was created.

## -remarks
You can use the [GetDeviceSelector](wifidirectdevice_getdeviceselector_185243134.md) methods to enumerate Wi-Fi Direct devices to determine their interface ids.

## -examples

## -see-also
[FromIdAsync(String)](wifidirectdevice_fromidasync_1322863552.md)