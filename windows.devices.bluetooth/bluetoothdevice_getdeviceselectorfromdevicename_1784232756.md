---
-api-id: M:Windows.Devices.Bluetooth.BluetoothDevice.GetDeviceSelectorFromDeviceName(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelectorFromDeviceName(System.String deviceName)
-->

# Windows.Devices.Bluetooth.BluetoothDevice.GetDeviceSelectorFromDeviceName

## -description
Creates an Advanced Query Syntax (AQS) filter string that contains a query for the Bluetooth device name. The AQS string is passed into the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method to return a collection of [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects containing the specified Bluetooth device name.

## -parameters
### -param deviceName
The Bluetooth device name used for constructing the AQS string.

## -returns
An AQS string that is passed as a parameter to the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method.

## -remarks

## -examples

## -see-also
