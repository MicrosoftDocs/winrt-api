---
-api-id: T:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementFilter
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class BluetoothLEAdvertisementFilter : Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementFilter
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementFilter

## -description
Groups parameters used to configure payload-based filtering of received Bluetooth LE advertisements.

## -remarks
A Bluetooth LE advertisement filter is applied to an advertisement event packet, and not to the device/source of the advertisement as a whole. The same device can broadcast advertisement packets with different payloads at the same time. For example, it's common for the local name to be in a different advertisement packet from the packet containing the service UUID. So, with a filter set to service UUID, the packet with local name won't be available (only packets with both service UUID and local name will be available in that case).

## -examples

## -see-also
[BluetoothLEAdvertisement](bluetoothleadvertisement.md)

## -capabilities
bluetooth
