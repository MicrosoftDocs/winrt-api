---
-api-id: T:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementReceivedEventArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class BluetoothLEAdvertisementReceivedEventArgs : Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementReceivedEventArgs
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementReceivedEventArgs

## -description
Provides data for a [Received](bluetoothleadvertisementwatcher_received.md) event on a [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md). A BluetoothLEAdvertisementReceivedEventArgs instance is created when the [Received](bluetoothleadvertisementwatcher_received.md) event occurs on a [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md) object.

## -remarks
Per [BluetoothSignalStrengthFilter](../windows.devices.bluetooth/bluetoothsignalstrengthfilter.md), when the device signal goes out of range, an "out of range" event will be sent, containing the advertisement data last seen, with the [RawSignalStrengthInDBm](bluetoothleadvertisementreceivedeventargs_rawsignalstrengthindbm.md) value set to -127. 
### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 2004 | 19041 | BluetoothAddressType |
| 2004 | 19041 | IsAnonymous |
| 2004 | 19041 | IsConnectable |
| 2004 | 19041 | IsDirected |
| 2004 | 19041 | IsScannable |
| 2004 | 19041 | IsScanResponse |
| 2004 | 19041 | TransmitPowerLevelInDBm |

## -examples

## -see-also
[BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md), [BluetoothLEAdvertisementWatcher.Received](bluetoothleadvertisementwatcher_received.md), [BluetoothSignalStrengthFilter](../windows.devices.bluetooth/bluetoothsignalstrengthfilter.md)
## -capabilities
bluetooth
