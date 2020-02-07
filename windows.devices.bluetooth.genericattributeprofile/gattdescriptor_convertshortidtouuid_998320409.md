---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattDescriptor.ConvertShortIdToUuid(System.UInt16)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public System.Guid ConvertShortIdToUuid(System.UInt16 shortId)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattDescriptor.ConvertShortIdToUuid

## -description
Converts a Bluetooth SIG defined short Id to a full GATT UUID.

> [!IMPORTANT]
> The **ConvertShortIdToUuid** API is deprecated, and it may not be available in future versions of Windows. Instead, use [BluetoothUuidHelper.FromShortId](/uwp/api/windows.devices.bluetooth.bluetoothuuidhelper.fromshortid).

## -parameters
### -param shortId
A 16-bit Bluetooth GATT Descriptor UUID.

## -returns
The corresponding 128-bit GATT Descriptor UUID, that uniquely identifies this descriptor.

## -remarks

## -examples

## -see-also

## -capabilities
bluetooth
