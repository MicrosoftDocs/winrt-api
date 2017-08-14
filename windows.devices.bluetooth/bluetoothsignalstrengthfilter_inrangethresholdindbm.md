---
-api-id: P:Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter.InRangeThresholdInDBm
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<short> InRangeThresholdInDBm { get;  set; }
-->

# Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter.InRangeThresholdInDBm

## -description
The minimum received signal strength indicator (RSSI) value in dBm on which RSSI events will be propagated or considered in range if the previous events were considered out of range.

## -property-value
The minimum RSSI value in dBm on which RSSI events will be propagated or considered in range.

## -remarks
The valid range for this property is between -128 and 127.

This condition still applies if no events were received since the beginning of the filtering process. The initial assumption for any device is always out of range. An event is considered in range if its RSSI value is greater than or equal to [InRangeThresholdInDBm](bluetoothsignalstrengthfilter_inrangethresholdindbm.md) or if the previous event was considered in range and the [OutOfRangeTimeout](bluetoothsignalstrengthfilter_outofrangetimeout.md) has not expired.

## -examples

## -see-also
[OutOfRangeTimeout](bluetoothsignalstrengthfilter_outofrangetimeout.md)

## -capabilities
bluetooth
