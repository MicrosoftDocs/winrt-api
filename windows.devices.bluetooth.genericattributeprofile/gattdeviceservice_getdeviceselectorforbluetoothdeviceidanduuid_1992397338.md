---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.GetDeviceSelectorForBluetoothDeviceIdAndUuid(Windows.Devices.Bluetooth.BluetoothDeviceId,System.Guid)
-api-type: winrt method
---

<!-- Method syntax.
public string GattDeviceService.GetDeviceSelectorForBluetoothDeviceIdAndUuid(BluetoothDeviceId bluetoothDeviceId, Guid serviceUuid)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.GetDeviceSelectorForBluetoothDeviceIdAndUuid

## -description
Creates a suitable AQS Filter string for use with the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method, from a BluetoothDeviceId and serviceUuid.

## -parameters

### -param bluetoothDeviceId
The bluetooth device ID.

### -param serviceUuid
The GATT service ID.

## -returns
A suitable AQS Selector String which can be passed as a parameter to the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method, in order to retrieve a GATT service instance path

## -remarks

## -see-also

## -examples


## -capabilities
bluetooth
