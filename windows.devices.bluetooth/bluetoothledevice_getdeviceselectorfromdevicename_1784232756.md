---
-api-id: M:Windows.Devices.Bluetooth.BluetoothLEDevice.GetDeviceSelectorFromDeviceName(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelectorFromDeviceName(System.String deviceName)
-->

# Windows.Devices.Bluetooth.BluetoothLEDevice.GetDeviceSelectorFromDeviceName

## -description
Creates an Advanced Query Syntax (AQS) filter string that contains a query for the Bluetooth LE device name. The AQS string is passed into the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method to return a collection of [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects containing the specified Bluetooth LE device name.

## -parameters
### -param deviceName
The Bluetooth LE device name used for constructing the AQS string.

## -returns
An AQS string that is passed as a parameter to the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method.

## -remarks

## -examples

## -see-also
