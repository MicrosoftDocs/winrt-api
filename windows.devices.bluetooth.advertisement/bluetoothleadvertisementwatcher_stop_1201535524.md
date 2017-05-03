---
-api-id: M:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher.Stop
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Stop()
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher.Stop

## -description
Stop the [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md) and disable the scanning for Bluetooth LE advertisements.

## -remarks
This method will transition the [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md) to the **Stopping** state until the scan is cancelled in which the state will transition to the **Stopped** state. Calling this method in the **Stopped** or **Aborted** state has no effect. Calling this method in the **Stopping** state will overwrite any advertisements received in the last [Start](bluetoothleadvertisementwatcher_start.md) method call during that state.

The [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md) will be automatically stopped when an app is suspended.

> [!NOTE]
> Stopping the scan for the [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md) will not actually stop the Bluetooth radio from scanning if another app or the system still requires the radio to remain in a scanning state.

## -examples

## -see-also
[BluetoothLEAdvertisementWatcherStatus](bluetoothleadvertisementwatcherstatus.md)