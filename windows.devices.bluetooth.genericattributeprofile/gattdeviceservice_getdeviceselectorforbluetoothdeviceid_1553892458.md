---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.GetDeviceSelectorForBluetoothDeviceId(Windows.Devices.Bluetooth.BluetoothDeviceId,Windows.Devices.Bluetooth.BluetoothCacheMode)
-api-type: winrt method
---

<!-- Method syntax.
public string GattDeviceService.GetDeviceSelectorForBluetoothDeviceId(BluetoothDeviceId bluetoothDeviceId, BluetoothCacheMode cacheMode)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.GetDeviceSelectorForBluetoothDeviceId

## -description
Creates a suitable AQS Filter string for use with the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method, from a BluetoothDeviceId.

## -parameters

### -param bluetoothDeviceId
The bluetooth device ID.

### -param cacheMode
The cache mode.

## -returns
A suitable AQS Selector String which can be passed as a parameter to the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method, in order to retrieve a GATT service instance path

## -remarks

## -see-also

## -examples

