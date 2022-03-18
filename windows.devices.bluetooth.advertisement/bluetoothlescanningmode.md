---
-api-id: T:Windows.Devices.Bluetooth.Advertisement.BluetoothLEScanningMode
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Bluetooth.Advertisement.BluetoothLEScanningMode : int
-->

# BluetoothLEScanningMode

## -description

Defines constants that specify a Bluetooth LE scanning mode.

## -enum-fields

### -field Passive:0

Specifies a passive scanning mode. This is the default scanning mode.

### -field Active:1

Specifies an active scanning mode. This indicates that scan request packets will be sent from the platform to actively query for more advertisement data of type [BluetoothLEAdvertisementType.ScanResponse](bluetoothleadvertisementtype.md).

### -field None:2

Specifies no scanning mode. The watcher will provide advertisements as the system receives them, but will not initiate its own scanning.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 2004 | 19041 | None |

## -examples

## -see-also

## -capabilities
bluetooth
