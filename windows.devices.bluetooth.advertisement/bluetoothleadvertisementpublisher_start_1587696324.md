---
-api-id: M:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher.Start
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Start()
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher.Start

## -description
Start advertising a Bluetooth LE advertisement payload.

## -remarks
The status of the [BluetoothLEAdvertisementPublisher](bluetoothleadvertisementpublisher.md) will transition to **Started** or **Waiting** depending on whether the advertisement can be serviced or to the **Aborted** state if the request failed immediately due to error.

If the [Start](bluetoothleadvertisementpublisher_start.md) method is called in the **Stopping** state, the request will be pended and the state will remain in the **Stopping** state until the request completes, at which time a new request will be sent and the state will transition into **Started**.

The [BluetoothLEAdvertisementPublisher](bluetoothleadvertisementpublisher.md) will be automatically stopped when an app is suspended.

## -examples

## -see-also
[BluetoothLEAdvertisementPublisher.Stop](bluetoothleadvertisementpublisher_stop.md), [BluetoothLEAdvertisementPublisher.StatusChanged](bluetoothleadvertisementpublisher_statuschanged.md), [BluetoothLEAdvertisementPublisherStatus](bluetoothleadvertisementpublisherstatus.md), [BluetoothLEAdvertisementPublisherStatusChangedEventArgs](bluetoothleadvertisementpublisherstatuschangedeventargs.md)
## -capabilities
bluetooth
