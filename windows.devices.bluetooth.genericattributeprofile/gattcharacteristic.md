---
-api-id: T:Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class GattCharacteristic : Windows.Devices.Bluetooth.GenericAttributeProfile.IGattCharacteristic, Windows.Devices.Bluetooth.GenericAttributeProfile.IGattCharacteristic2, Windows.Devices.Bluetooth.GenericAttributeProfile.IGattCharacteristic3
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic

## -description
Represents a Characteristic of a GATT service. The GattCharacteristic object represents a GATT Characteristic of a particular service, and is obtained from the Characteristics property of the GattDeviceService object.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | GetDescriptorsAsync |
| 1703 | 15063 | GetDescriptorsAsync(BluetoothCacheMode) |
| 1703 | 15063 | GetDescriptorsForUuidAsync(Guid) |
| 1703 | 15063 | GetDescriptorsForUuidAsync(Guid,BluetoothCacheMode) |
| 1703 | 15063 | WriteClientCharacteristicConfigurationDescriptorWithResultAsync |
| 1703 | 15063 | WriteValueWithResultAsync(IBuffer) |
| 1703 | 15063 | WriteValueWithResultAsync(IBuffer,GattWriteOption) |

## -examples

## -see-also

## -capabilities
bluetooth
