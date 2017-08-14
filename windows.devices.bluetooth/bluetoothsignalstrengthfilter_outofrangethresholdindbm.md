---
-api-id: P:Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter.OutOfRangeThresholdInDBm
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<short> OutOfRangeThresholdInDBm { get;  set; }
-->

# Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter.OutOfRangeThresholdInDBm

## -description
The minimum received signal strength indicator (RSSI) value in dBm on which RSSI events will be considered out of range.

## -property-value
The minimum RSSI value in dBm on which RSSI events will be considered out of range.

## -remarks
The valid range for this property is between -128 and 127.

RSSI events are considered out of range after their RSSI values are kept lower than or equal to [OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md) within [OutOfRangeTimeout](bluetoothsignalstrengthfilter_outofrangetimeout.md). RSSI events are also considered out of range if no events are received within [OutOfRangeTimeout](bluetoothsignalstrengthfilter_outofrangetimeout.md).

## -examples

## -see-also
[OutOfRangeTimeout](bluetoothsignalstrengthfilter_outofrangetimeout.md)

## -capabilities
bluetooth
