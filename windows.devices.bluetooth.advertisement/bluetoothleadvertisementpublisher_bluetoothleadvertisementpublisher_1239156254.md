---
-api-id: M:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher.#ctor(Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public BluetoothLEAdvertisementPublisher(Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement advertisement)
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher.BluetoothLEAdvertisementPublisher

## -description
Creates a new [BluetoothLEAdvertisementPublisher](bluetoothleadvertisementpublisher.md) object with the Bluetooth LE advertisement to publish.

## -parameters
### -param advertisement
The Bluetooth LE advertisement to publish.

## -remarks
There are additional policy restrictions on certain system-reserved data types that cannot be advertised through using the [BluetoothLEAdvertisementPublisher](bluetoothleadvertisementpublisher.md). Advertisement containing these data types will be rejected and an exception will be thrown when the [Start](/uwp/api/Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher.Start) method is called.

## -examples

## -see-also
[BluetoothLEAdvertisement](bluetoothleadvertisement.md)
## -capabilities
bluetooth
