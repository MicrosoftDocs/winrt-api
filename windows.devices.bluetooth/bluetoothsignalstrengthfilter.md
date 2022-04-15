---
-api-id: T:Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class BluetoothSignalStrengthFilter : Windows.Devices.Bluetooth.IBluetoothSignalStrengthFilter
-->

# Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter

## -description
Groups parameters used to configure received signal strength indicator (RSSI)-based filtering.

## -remarks
The BluetoothSignalStrengthFilter class only accepts a limited range for its properties. However, depending on how this class is used by an app, additional restrictions may apply. For example, the valid range for RSSI values differs between Bluetooth LE and Bluetooth BR/EDR devices.

The valid range for these properties are as follows:


+ [InRangeThresholdInDBm](bluetoothsignalstrengthfilter_inrangethresholdindbm.md) - The minimum threshold for an RSSI event to be considered in range. The valid range is -128 to 127.
+ [OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md) - The minimum threshold for an RSSI event to be considered out of range. The valid range is -128 to 127.
+ [OutOfRangeTimeout](bluetoothsignalstrengthfilter_outofrangetimeout.md) - Timeout for an RSSI event to be considered out of range. The valid range is equal or greater than 1 second.
+ [SamplingInterval](bluetoothsignalstrengthfilter_samplinginterval.md) - The interval at which RSSI events are sampled. The valid range is equal or greater than 0. Any sampling interval greater or equal to 25.5 seconds will disable sampling entirely. In that special case, the filtering is trigger-based.
There are two possible states for filtering RSSI values for any device:
+ In range.
+ Out of range.
 Any RSSI events are propagated if they are considered in range. This includes events with RSSI values lower or equal than [OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md) as long as [OutOfRangeTimeout](bluetoothsignalstrengthfilter_outofrangetimeout.md) has not expired.

This class has additional limitations on its properties when used by the [BluetoothLEAdvertisementWatcher](../windows.devices.bluetooth.advertisement/bluetoothleadvertisementwatcher.md) class. An exception will be thrown when the [BluetoothLEAdvertisementWatcher](../windows.devices.bluetooth.advertisement/bluetoothleadvertisementwatcher.md) is started with parameters outside of the valid range for [BluetoothLEAdvertisementWatcher](../windows.devices.bluetooth.advertisement/bluetoothleadvertisementwatcher.md).

In general, there are three main use cases for this API:

| [InRangeThresholdInDBm](bluetoothsignalstrengthfilter_inrangethresholdindbm.md) | [OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md) | [OutOfRangeTimeout](bluetoothsignalstrengthfilter_outofrangetimeout.md) | [SamplingInterval](bluetoothsignalstrengthfilter_samplinginterval.md) | Behavior |
|---|---|---|---|---|
| Any | &lt;= [InRangeThresholdInDBm](bluetoothsignalstrengthfilter_inrangethresholdindbm.md) | &gt;= 1 | 0 | Will receive all RSSI events as they arrive as long as they are considered "in range". The events are considered "out of range" if [OutOfRangeTimeout](bluetoothsignalstrengthfilter_outofrangetimeout.md) expires without any events or without any events with RSSI values greater than [OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md). No additional events are generated when [OutOfRangeTimeout](bluetoothsignalstrengthfilter_outofrangetimeout.md) expires. |
| Any | &lt;= [InRangeThresholdInDBm](bluetoothsignalstrengthfilter_inrangethresholdindbm.md) | &gt;= 1 | (0, 25.5) | Will receive RSSI events on a regular interval defined by [SamplingInterval](bluetoothsignalstrengthfilter_samplinginterval.md) as long as they are considered "in range". The RSSI value will be an average of the values of events received within a [SamplingInterval](bluetoothsignalstrengthfilter_samplinginterval.md). If no events are received within [SamplingInterval](bluetoothsignalstrengthfilter_samplinginterval.md), no event will be propagated. If [OutOfRangeTimeout](bluetoothsignalstrengthfilter_outofrangetimeout.md) expires without any events or without any events with RSSI values greater than [OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md), the events are considered "out of range" and an event with the last RSSI value received will be generated. If the last RSSI value was above [OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md), it is set to -127 dBm. |
| Any | &lt;= [InRangeThresholdInDBm](bluetoothsignalstrengthfilter_inrangethresholdindbm.md) | &gt;= 1 | &gt;=25.5 (disabled) | Will receive a RSSI event when the RSSI events are transitioning to "in range" from "out of range". If [OutOfRangeTimeout](bluetoothsignalstrengthfilter_outofrangetimeout.md) expires without any events or without any events with RSSI values greater than [OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md), the events are considered "out of range" and an event with the last RSSI value received will be generated. If the last RSSI value was above [OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md), it is set to [OutOfRangeThresholdInDBm](bluetoothsignalstrengthfilter_outofrangethresholdindbm.md). |


## -examples

## -see-also
[BluetoothLEAdvertisementWatcher](../windows.devices.bluetooth.advertisement/bluetoothleadvertisementwatcher.md), [BluetoothLEAdvertisementWatcher.SignalStrengthFilter](../windows.devices.bluetooth.advertisement/bluetoothleadvertisementwatcher_signalstrengthfilter.md)

## -capabilities
bluetooth
