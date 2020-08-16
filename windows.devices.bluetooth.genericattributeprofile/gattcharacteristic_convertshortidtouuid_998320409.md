---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic.ConvertShortIdToUuid(System.UInt16)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public System.Guid ConvertShortIdToUuid(System.UInt16 shortId)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic.ConvertShortIdToUuid

## -description
Converts a Bluetooth SIG defined short Id to a full GATT UUID.

> [!IMPORTANT]
> The **ConvertShortIdToUuid** API is deprecated, and it may not be available in future versions of Windows. Instead, use [BluetoothUuidHelper.FromShortId](/uwp/api/windows.devices.bluetooth.bluetoothuuidhelper.fromshortid).

## -parameters
### -param shortId
A 16-bit Bluetooth GATT Service UUID.

## -returns
The corresponding 128-bit GATT Characteristic UUID, that uniquely identifies this characteristic.

## -remarks

## -examples

## -see-also

## -capabilities
bluetooth
