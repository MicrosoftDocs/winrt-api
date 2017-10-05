---
-api-id: M:Windows.Devices.Bluetooth.BluetoothDevice.GetDeviceSelectorFromBluetoothAddress(System.UInt64)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelectorFromBluetoothAddress(System.UInt64 bluetoothAddress)
-->

# Windows.Devices.Bluetooth.BluetoothDevice.GetDeviceSelectorFromBluetoothAddress

## -description
Creates an Advanced Query Syntax (AQS) filter string from a 64-bit address that represents a Bluetooth device. The AQS string is passed into the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method to return a collection of [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects.

## -parameters
### -param bluetoothAddress
A 64-bit Bluetooth device address used for constructing the AQS string.

## -returns
An AQS string that can be passed as a parameter to the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method.

## -remarks

## -examples

## -see-also

## -capabilities
bluetooth
