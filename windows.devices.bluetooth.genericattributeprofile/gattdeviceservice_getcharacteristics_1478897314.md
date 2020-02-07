---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.GetCharacteristics(System.Guid)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic> GetCharacteristics(System.Guid characteristicUuid)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.GetCharacteristics

## -description
Returns a vector of characteristics, that are identified by the specified UUID and belong to this GattDeviceService instance.

> [!IMPORTANT]
> The **GetCharacteristics** API is deprecated, and it may not be available in future versions of Windows. Instead, use [GetCharacteristicsForUuidAsync](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattdeviceservice.getcharacteristicsforuuidasync).

## -parameters
### -param characteristicUuid
The UUID for the characteristics to be retrieved.

## -returns
A vector of GattCharacteristic objects whose UUIDs match characteristicUuid.

## -remarks
Only a single app can access a single service. If one app has registered a GATT notification trigger, this method will throw an exception for all other apps that sub subsequently call this API.

## -examples

## -see-also

## -capabilities
bluetooth
