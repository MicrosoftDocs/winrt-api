---
-api-id: P:Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter.OutOfRangeTimeout
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.TimeSpan> OutOfRangeTimeout { get;  set; }
-->

# Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter.OutOfRangeTimeout

## -description
The timeout for a received signal strength indicator (RSSI) event to be considered out of range.

## -property-value
The timeout for an RSSI event to be considered out of range.

## -remarks
The valid range for this property is equal or greater than 1 second.

If the RSSI events are currently considered in range, this is the timeout period during which if the received RSSI events have RSSI values less than or equal to [OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md) or no RSSI events are received, further RSSI events will be considered out of range. This timer is reset if received RSSI values are greater than [OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md). If the events are currently out of range, this property has no effect.

When applied to LE advertisements, an advertisement with the minimum RSSI value (-127) will be generated to indicate that the advertisement went out of range.

## -examples

## -see-also
[OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md)

## -capabilities
bluetooth
