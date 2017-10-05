---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.GetDeviceSelectorFromUuid(System.Guid)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelectorFromUuid(System.Guid serviceUuid)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.GetDeviceSelectorFromUuid

## -description
Creates a suitable AQS Filter string for use with the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method, from a Bluetooth service UUID.

## -parameters
### -param serviceUuid
A 128-bit Bluetooth GATT Service UUID, represented as a standard GUID object.

## -returns
A suitable AQS Selector String which can be passed as a parameter to the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method, in order to retrieve a GATT service instance path.

## -remarks

## -examples

## -see-also

## -capabilities
bluetooth
