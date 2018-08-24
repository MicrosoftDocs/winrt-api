---
-api-id: T:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcherStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcherStatus : int
-->

# BluetoothLEAdvertisementWatcherStatus

## -description
Represents the possible states of the [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md).

## -enum-fields
### -field Created:0
The initial status of the watcher.

### -field Started:1
The watcher is started.

### -field Stopping:2
The watcher stop command was issued.

### -field Stopped:3
The watcher is stopped.

### -field Aborted:4
An error occurred during transition or scanning that stopped the watcher due to an error.


## -remarks

## -examples

## -see-also
[BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md), [BluetoothLEAdvertisementWatcher.Start](bluetoothleadvertisementwatcher_start_1587696324.md), [BluetoothLEAdvertisementWatcher.Stop](bluetoothleadvertisementwatcher_stop_1201535524.md)
## -capabilities
bluetooth
