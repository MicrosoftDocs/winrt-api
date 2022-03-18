---
-api-id: P:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisherStatusChangedEventArgs.SelectedTransmitPowerLevelInDBm
-api-type: winrt property
---

<!-- Property syntax.
public IReference<short> SelectedTransmitPowerLevelInDBm { get; }
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisherStatusChangedEventArgs.SelectedTransmitPowerLevelInDBm

## -description
Represents the current transmit power selected by the Bluetooth adapter for the advertisement.

## -property-value
The current transmit power selected. If the Extended Advertisement format is not supported by the adapter, this instead represents the adapter's default transmit power level.

## -remarks
This property is only valid when the advertisement publisher is in the Started state.

## -see-also

## -examples
