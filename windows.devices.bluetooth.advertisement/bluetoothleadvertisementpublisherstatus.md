---
-api-id: T:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisherStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisherStatus : int
-->

# BluetoothLEAdvertisementPublisherStatus

## -description
Represents the possible states of the [BluetoothLEAdvertisementPublisher](bluetoothleadvertisementpublisher.md).

## -enum-fields
### -field Created:0
The initial status of the publisher.

### -field Waiting:1
The publisher is waiting to get service time.

### -field Started:2
The publisher is being serviced and has started advertising.

### -field Stopping:3
The publisher was issued a stop command.

### -field Stopped:4
The publisher has stopped advertising.

### -field Aborted:5
The publisher is aborted due to an error.


## -remarks

## -examples

## -see-also
[BluetoothLEAdvertisementPublisher](bluetoothleadvertisementpublisher.md), [BluetoothLEAdvertisementPublisher.Start](bluetoothleadvertisementpublisher_start.md), [BluetoothLEAdvertisementPublisher.Stop](bluetoothleadvertisementpublisher_stop.md)