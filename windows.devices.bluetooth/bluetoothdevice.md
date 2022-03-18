---
-api-id: T:Windows.Devices.Bluetooth.BluetoothDevice
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class BluetoothDevice : Windows.Devices.Bluetooth.IBluetoothDevice, Windows.Devices.Bluetooth.IBluetoothDevice2, Windows.Devices.Bluetooth.IBluetoothDevice3, Windows.Foundation.IClosable
-->

# Windows.Devices.Bluetooth.BluetoothDevice

## -description
Represents a Bluetooth device.

Sample applications that use this class include [Device enumeration and pairing sample](/samples/microsoft/windows-universal-samples/deviceenumerationandpairing/) and [Bluetooth RFCOMM chat sample](/samples/microsoft/windows-universal-samples/bluetoothrfcommchat/).

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | DeviceInformation |
| 1511 | 10586 | GetDeviceSelectorFromBluetoothAddress |
| 1511 | 10586 | GetDeviceSelectorFromClassOfDevice |
| 1511 | 10586 | GetDeviceSelectorFromConnectionStatus |
| 1511 | 10586 | GetDeviceSelectorFromDeviceName |
| 1511 | 10586 | GetDeviceSelectorFromPairingState |
| 1607 | 14393 | DeviceAccessInformation |
| 1607 | 14393 | GetRfcommServicesAsync |
| 1607 | 14393 | GetRfcommServicesAsync(BluetoothCacheMode) |
| 1607 | 14393 | GetRfcommServicesForIdAsync(RfcommServiceId) |
| 1607 | 14393 | GetRfcommServicesForIdAsync(RfcommServiceId,BluetoothCacheMode) |
| 1607 | 14393 | RequestAccessAsync |
| 1709 | 16299 | BluetoothDeviceId |
| 1803 | 17134 | WasSecureConnectionUsedForPairing |

## -examples

## -see-also

[Device enumeration and pairing sample](/samples/microsoft/windows-universal-samples/deviceenumerationandpairing/), [Bluetooth RFCOMM chat sample](/samples/microsoft/windows-universal-samples/bluetoothrfcommchat/)

## -capabilities
bluetooth
