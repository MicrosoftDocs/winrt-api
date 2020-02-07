---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.GetDeviceSelectorFromShortId(System.UInt16)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelectorFromShortId(System.UInt16 serviceShortId)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.GetDeviceSelectorFromShortId

## -description
Creates a suitable AQS Filter string for use with the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method, from a 16-bit Bluetooth GATT Service UUID.

> [!IMPORTANT]
> The **GetDeviceSelectorFromShortId** API is deprecated, and it may not be available in future versions of Windows. Instead, use [GetDeviceSelectorFromUuid](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattdeviceservice.getdeviceselectorfromuuid).

## -parameters
### -param serviceShortId
A 16-bit Bluetooth GATT Service UUID.

## -returns
A suitable AQS Selector String which can be passed as a parameter to the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method, in order to retrieve a GATT service instance path

## -remarks

## -examples

## -see-also

## -capabilities
bluetooth
