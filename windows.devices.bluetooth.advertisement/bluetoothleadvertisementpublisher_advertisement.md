---
-api-id: P:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher.Advertisement
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement Advertisement { get; }
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher.Advertisement

## -description
Gets a copy of the Bluetooth LE advertisement to publish.

When configuring the publisher object, you can't add restricted section types ([BluetoothLEAdvertisementPublisher.Advertisement.Flags](/uwp/api/windows.devices.bluetooth.advertisement.bluetoothleadvertisement.flags) and [BluetoothLEAdvertisementPublisher.Advertisement.LocalName](/uwp/api/windows.devices.bluetooth.advertisement.bluetoothleadvertisement.localname)). Trying to set those property values results in a runtime exception. You can still set the manufacturer data section, or any other sections not defined by the list of restrictions.

## -property-value
A copy of the Bluetooth LE advertisement to publish.

## -remarks

## -examples

## -see-also
[BluetoothLEAdvertisement](bluetoothleadvertisement.md)
## -capabilities
bluetooth
