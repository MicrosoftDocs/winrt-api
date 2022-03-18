---
-api-id: P:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementReceivedEventArgs.TransmitPowerLevelInDBm
-api-type: winrt property
---

<!-- Property syntax.
public IReference<short> TransmitPowerLevelInDBm { get; }
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementReceivedEventArgs.TransmitPowerLevelInDBm

## -description
Represents the received transmit power of the advertisement.

## -property-value
The received transmit power of the advertisement. Ranges from -127 dBm to 20dBM.

## -remarks
The transmit power may be present in the advertisement data, or it may be included using the Extended Advertising format.

## -see-also

[BluetoothLEAdvertisementPublisher.IncludeTransmitPowerLevel](bluetoothleadvertisementpublisher_includetransmitpowerlevel.md)

## -examples
