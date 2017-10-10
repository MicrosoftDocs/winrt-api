---
-api-id: M:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement.GetSectionsByType(System.Byte)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementDataSection> GetSectionsByType(System.Byte type)
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement.GetSectionsByType

## -description
Return a list of advertisement data sections that matches a given advertisement section type in a [BluetoothLEAdvertisement](bluetoothleadvertisement.md).

## -parameters
### -param type
The advertisement section type

## -returns
A vector of all the [BluetoothLEAdvertisementDataSection](bluetoothleadvertisementdatasection.md) matching the given advertisement type. This method returns an empty list if no such sections are found in the payload.

## -remarks

## -examples

## -see-also
[BluetoothLEAdvertisementDataSection](bluetoothleadvertisementdatasection.md)
## -capabilities
bluetooth
