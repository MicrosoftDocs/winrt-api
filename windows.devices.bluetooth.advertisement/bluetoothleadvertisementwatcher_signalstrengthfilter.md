---
-api-id: P:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher.SignalStrengthFilter
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter SignalStrengthFilter { get;  set; }
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher.SignalStrengthFilter

## -description
Gets or sets a [BluetoothSignalStrengthFilter](../windows.devices.bluetooth/bluetoothsignalstrengthfilter.md) object used for configuration of Bluetooth LE advertisement filtering that uses signal strength-based filtering.

## -property-value
Configuration of Bluetooth LE advertisement filtering that uses signal strength-based filtering.

## -remarks
The [SignalStrengthFilter](bluetoothleadvertisementwatcher_signalstrengthfilter.md) has additional limitations on its properties when used by the [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md) class. An exception will be thrown when the watcher is started with parameters outside of the valid range. If the properties are left as **NULL**, a default value is selected.

The additional restrictions and default values are as follows:


+ [InRangeThresholdInDBm](../windows.devices.bluetooth/bluetoothsignalstrengthfilter_inrangethresholdindbm.md) - The maximum value for RSSI for Bluetooth LE is +20. The minimum value for RSSI for BR/EDR is -127 (default when **NULL** is -127.
+ [OutOfRangeThresholdInDBm](../windows.devices.bluetooth/bluetoothsignalstrengthfilter_outofrangethresholdindbm.md) - The maximum value for RSSI for Bluetooth LE is +20. The minimum value for RSSI for BR/EDR is -127 (default when **NULL** is -127).
+ [OutOfRangeTimeout](../windows.devices.bluetooth/bluetoothsignalstrengthfilter_outofrangetimeout.md) - Equal or greater than 1 second and less than or equal to 60 seconds (default when **NULL** is 60 seconds).
+ [SamplingInterval](../windows.devices.bluetooth/bluetoothsignalstrengthfilter_samplinginterval.md) - Equal or greater than 0. Any sampling interval greater or equal to 25.5 seconds will disable sampling entirely. In that special case, the filtering is trigger-based. For more information about the behavior of the RSSI filtering, refer to the [BluetoothSignalStrengthFilter](../windows.devices.bluetooth/bluetoothsignalstrengthfilter.md).


## -examples

## -see-also
[BluetoothLEAdvertisement](bluetoothleadvertisement.md)
## -capabilities
bluetooth
