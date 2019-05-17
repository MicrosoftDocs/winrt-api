---
-api-id: T:Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class GattDeviceService : Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceService, Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceService2, Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceService3, Windows.Foundation.IClosable
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService

## -description
Represents a GATT Primary Service on a Bluetooth device. The GattDeviceService class represents a GATT service on a Bluetooth LE device. It is instantiated by using a device service instance path, obtained by finding a device using the [Windows.Devices.Enumeration](../windows.devices.enumeration/windows_devices_enumeration.md) API.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | DeviceAccessInformation |
| 1703 | 15063 | FromIdAsync(String,GattSharingMode) |
| 1703 | 15063 | GetCharacteristicsAsync |
| 1703 | 15063 | GetCharacteristicsAsync(BluetoothCacheMode) |
| 1703 | 15063 | GetCharacteristicsForUuidAsync(Guid) |
| 1703 | 15063 | GetCharacteristicsForUuidAsync(Guid,BluetoothCacheMode) |
| 1703 | 15063 | GetDeviceSelectorForBluetoothDeviceId(BluetoothDeviceId) |
| 1703 | 15063 | GetDeviceSelectorForBluetoothDeviceId(BluetoothDeviceId,BluetoothCacheMode) |
| 1703 | 15063 | GetDeviceSelectorForBluetoothDeviceIdAndUuid(BluetoothDeviceId,Guid) |
| 1703 | 15063 | GetDeviceSelectorForBluetoothDeviceIdAndUuid(BluetoothDeviceId,Guid,BluetoothCacheMode) |
| 1703 | 15063 | GetIncludedServicesAsync |
| 1703 | 15063 | GetIncludedServicesAsync(BluetoothCacheMode) |
| 1703 | 15063 | GetIncludedServicesForUuidAsync(Guid) |
| 1703 | 15063 | GetIncludedServicesForUuidAsync(Guid,BluetoothCacheMode) |
| 1703 | 15063 | OpenAsync |
| 1703 | 15063 | RequestAccessAsync |
| 1703 | 15063 | Session |
| 1703 | 15063 | SharingMode |

## -examples

## -see-also
[BluetoothLEDevice](../windows.devices.bluetooth/bluetoothledevice.md), [IClosable](../windows.foundation/iclosable.md)
## -capabilities
bluetooth
