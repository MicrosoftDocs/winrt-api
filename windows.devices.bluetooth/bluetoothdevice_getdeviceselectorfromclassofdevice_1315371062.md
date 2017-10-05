---
-api-id: M:Windows.Devices.Bluetooth.BluetoothDevice.GetDeviceSelectorFromClassOfDevice(Windows.Devices.Bluetooth.BluetoothClassOfDevice)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelectorFromClassOfDevice(Windows.Devices.Bluetooth.BluetoothClassOfDevice classOfDevice)
-->

# Windows.Devices.Bluetooth.BluetoothDevice.GetDeviceSelectorFromClassOfDevice

## -description
Creates an Advanced Query Syntax (AQS) filter string from a [BluetoothClassOfDevice](bluetoothclassofdevice.md) object. The AQS string is passed into the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method to return a collection of [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects.

## -parameters
### -param classOfDevice
The class of device used for constructing the AQS string.

## -returns
An AQS string that can be passed as a parameter to the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method.

## -remarks
Each section of the classOfDevice parameter is optional. However, if the minor class of device is set, then the major class of device must also be set. The following are behaviors related what is set.

+ If no major/minor class of device is set, all devices matching the supplied service capabilities will be returned.
+ If no minor class of device is set, all devices matching the major class of devices AND the supplied service capabilities will be returned.
+ If service capabilities are set, all devices that match at LEAST the supplied service capabilities AND the major/minor class of device will be returned.
+ If no service capabilities are set, all devices that match the major/minor class of device will be returned.
+ If no major/minor class of device is set AND no service capabilities are set, all devices will be returned. This AQS Filter string will request an inquiry to be issued.


## -examples

## -see-also

## -capabilities
bluetooth
