---
-api-id: M:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher.Start
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Start()
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher.Start

## -description
Start the [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md) to scan for Bluetooth LE advertisements.

## -remarks
This method will transition the [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md) to the **Started** state immediately with a pending scan request or to the **Aborted** state if the request failed immediately due to error.

If this method is called in the **Stopping** state, the request will be pended and the state will remain in the **Stopping** state until the request completes, at which time a new request will be sent and the state will transition to the **Started** state.

The [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md) will be automatically stopped when an app is suspended.

## -examples

## -see-also
[BluetoothLEAdvertisementWatcherStatus](bluetoothleadvertisementwatcherstatus.md)
## -capabilities
bluetooth
