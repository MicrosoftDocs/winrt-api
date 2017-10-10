---
-api-id: M:Windows.Devices.Bluetooth.BluetoothLEDevice.GetDeviceSelectorFromAppearance(Windows.Devices.Bluetooth.BluetoothLEAppearance)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelectorFromAppearance(Windows.Devices.Bluetooth.BluetoothLEAppearance appearance)
-->

# Windows.Devices.Bluetooth.BluetoothLEDevice.GetDeviceSelectorFromAppearance

## -description
Creates an Advanced Query Syntax (AQS) filter string from a [BluetoothLEAppearance](bluetoothleappearance.md) object. The AQS string is passed into the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method to return a collection of [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects with the specified appearance.

## -parameters
### -param appearance
The Bluetooth LE appearance used for constructing the AQS string.

## -returns
An AQS string that can be passed as a parameter to the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method.

## -remarks

## -examples

## -see-also

## -capabilities
bluetooth
