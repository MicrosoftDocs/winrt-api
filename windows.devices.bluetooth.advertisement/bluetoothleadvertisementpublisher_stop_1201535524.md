---
-api-id: M:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher.Stop
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Stop()
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher.Stop

## -description
Stop the publisher and stop advertising a Bluetooth LE advertisement payload.

## -remarks
The status of the [BluetoothLEAdvertisementPublisher](bluetoothleadvertisementpublisher.md) will transition to the **Stopping** state until the advertising is cancelled in which the state will transition to **Stopped** state. Calling the [Stop](bluetoothleadvertisementpublisher_stop.md) method in the **Stopped** or **Aborted** state has no effect. Calling the [Stop](bluetoothleadvertisementpublisher_stop.md) method in the **Stopping** state will overwrite any advertisements in the last [Start](bluetoothleadvertisementpublisher_start.md) method call during that state.

The [BluetoothLEAdvertisementPublisher](bluetoothleadvertisementpublisher.md) will be automatically stopped when an app is suspended.

## -examples

## -see-also
[BluetoothLEAdvertisementPublisher.Start](bluetoothleadvertisementpublisher_start.md), [BluetoothLEAdvertisementPublisher.StatusChanged](bluetoothleadvertisementpublisher_statuschanged.md), [BluetoothLEAdvertisementPublisherStatus](bluetoothleadvertisementpublisherstatus.md), [BluetoothLEAdvertisementPublisherStatusChangedEventArgs](bluetoothleadvertisementpublisherstatuschangedeventargs.md)