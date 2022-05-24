---
-api-id: T:Windows.Devices.Bluetooth.BluetoothLEDevice
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class BluetoothLEDevice : Windows.Devices.Bluetooth.IBluetoothLEDevice, Windows.Devices.Bluetooth.IBluetoothLEDevice2, Windows.Devices.Bluetooth.IBluetoothLEDevice3, Windows.Foundation.IClosable
-->

# Windows.Devices.Bluetooth.BluetoothLEDevice

## -description
Represents a Bluetooth LE device.

For code examples, see [Bluetooth Low Energy sample](/samples/microsoft/windows-universal-samples/bluetoothle/) and [Device enumeration and pairing sample](/samples/microsoft/windows-universal-samples/deviceenumerationandpairing/).

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | Appearance |
| 1511 | 10586 | BluetoothAddressType |
| 1511 | 10586 | DeviceInformation |
| 1511 | 10586 | FromBluetoothAddressAsync(UInt64,BluetoothAddressType) |
| 1511 | 10586 | GetDeviceSelectorFromAppearance |
| 1511 | 10586 | GetDeviceSelectorFromBluetoothAddress(UInt64) |
| 1511 | 10586 | GetDeviceSelectorFromBluetoothAddress(UInt64,BluetoothAddressType) |
| 1511 | 10586 | GetDeviceSelectorFromConnectionStatus |
| 1511 | 10586 | GetDeviceSelectorFromDeviceName |
| 1511 | 10586 | GetDeviceSelectorFromPairingState |
| 1703 | 15063 | DeviceAccessInformation |
| 1703 | 15063 | GetGattServicesAsync |
| 1703 | 15063 | GetGattServicesAsync(BluetoothCacheMode) |
| 1703 | 15063 | GetGattServicesForUuidAsync(Guid) |
| 1703 | 15063 | GetGattServicesForUuidAsync(Guid,BluetoothCacheMode) |
| 1703 | 15063 | RequestAccessAsync |
| 1709 | 16299 | BluetoothDeviceId |
| 1803 | 17134 | WasSecureConnectionUsedForPairing |

## -examples

## -see-also
[GattDeviceService](../windows.devices.bluetooth.genericattributeprofile/gattdeviceservice.md), [GattDeviceService.Device](../windows.devices.bluetooth.genericattributeprofile/gattdeviceservice_device.md), [Bluetooth Low Energy sample](/samples/microsoft/windows-universal-samples/bluetoothle/), [Device enumeration and pairing sample](/samples/microsoft/windows-universal-samples/deviceenumerationandpairing/)

## -capabilities
bluetooth
