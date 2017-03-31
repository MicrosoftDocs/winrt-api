---
-api-id: M:Windows.Devices.Bluetooth.BluetoothLEDevice.GetDeviceSelectorFromBluetoothAddress(System.UInt64,Windows.Devices.Bluetooth.BluetoothAddressType)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelectorFromBluetoothAddress(System.UInt64 bluetoothAddress, Windows.Devices.Bluetooth.BluetoothAddressType bluetoothAddressType)
-->

# Windows.Devices.Bluetooth.BluetoothLEDevice.GetDeviceSelectorFromBluetoothAddress

## -description
Creates an Advanced Query Syntax (AQS) filter string from a 64-bit address and address type that represents a Bluetooth LE device. The AQS string is passed into the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method.

## -parameters
### -param bluetoothAddress
A 64-bit Bluetooth LE device address used for constructing the AQS string.

### -param bluetoothAddressType
The Bluetooth LE device address type.

## -returns
An AQS string that can be passed as a parameter to the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method.

## -remarks

## -examples

## -see-also
[GetDeviceSelectorFromBluetoothAddress(UInt64)](bluetoothledevice_getdeviceselectorfrombluetoothaddress_1273508324.md)