---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic.GetDescriptors(System.Guid)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Devices.Bluetooth.GenericAttributeProfile.GattDescriptor> GetDescriptors(System.Guid descriptorUuid)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic.GetDescriptors

## -description
Returns a vector of descriptors, that are identified by the specified UUID, and belong to this GattCharacteristic instance.

> [!IMPORTANT]
> The **GetDescriptors** API is deprecated, and it may not be available in future versions of Windows. Instead, use [GetDescriptorsForUuidAsync](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattcharacteristic.getdescriptorsforuuidasync).

## -parameters
### -param descriptorUuid
The UUID for the descriptors to be retrieved.

## -returns
A vector of descriptors whose UUIDs match descriptorUuid.

## -remarks

## -examples

## -see-also

## -capabilities
bluetooth