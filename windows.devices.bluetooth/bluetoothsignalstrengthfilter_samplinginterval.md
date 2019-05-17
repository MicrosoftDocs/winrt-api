---
-api-id: P:Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter.SamplingInterval
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.TimeSpan> SamplingInterval { get;  set; }
-->

# Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter.SamplingInterval

## -description
The interval at which received signal strength indicator (RSSI) events are sampled.

## -property-value
The interval at which RSSI events are sampled.

## -remarks
The valid range for this property is equal or greater than zero.

If the SamplingInterval is zero, every received RSSI event that satisfies the conditions configured through the other [BluetoothSignalStrengthFilter](bluetoothsignalstrengthfilter.md) properties will be propagated. If the sampling interval is greater than or equal to a maximum limit value (currently 25.5 seconds), sampling will be disabled and RSSI events will only be propagated on a triggered basis when they transition between in range and out of range. Otherwise, an aggregated RSSI value (average in most cases) of the RSSI events received within SamplingInterval will be propagated. If no RSSI events have been received within SamplingInterval, no RSSI events are propagated.

## -examples

## -see-also


## -capabilities
bluetooth
