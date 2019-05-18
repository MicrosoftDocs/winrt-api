---
-api-id: P:Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger.SignalStrengthFilter
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter SignalStrengthFilter { get;  set; }
-->

# Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger.SignalStrengthFilter

## -description
Gets or sets the configuration of Bluetooth LE advertisement filtering that uses signal strength-based filtering.

## -property-value
The configuration of Bluetooth LE advertisement filtering that uses signal strength-based filtering.

## -remarks
The SignalStrengthFilter has additional limitations on its properties when used by the [BluetoothLEAdvertisementWatcherTrigger](bluetoothleadvertisementwatchertrigger.md) class. The trigger will fail to register if it contains parameters outside of the valid range. If the properties are left as `NULL`, a default value is selected.


The additional restrictions and default values are as follows:

+ **InRangeThresholdInDBm**: The maximum value for RSSI for Bluetooth LE is +20. The minimum value for RSSI for Bluetooth LE is -127 (default when NULL is -127).
+ **OutOfRangeThresholdInDBm**: The maximum value for RSSI for Bluetooth LE is +20. The maximim value for RSSI for Bluetooth LE is -127 (default when NULL is -127).
+ **OutOfRangeTimeout**: Equal or greater than 1 second and less than or equal to 60 seconds (default when NULL is 60 seconds).
+ **SamplingInterval**: Equal or greater than 1 second. Any sampling interval greater or equal to 25.5 seconds will disable sampling entirely. In that special case, the filtering is trigger-based. For more information about the behavior of the RSSI filtering, refer to [BluetoothSignalStrengthFilter](../windows.devices.bluetooth/bluetoothsignalstrengthfilter.md).


Additional restrictions are in place such that a filter with **OutOfRangeThresholdInDBm** higher than **InRangeThresholdInDBm** will be rejected for example. Some of these limits are obtainable programmatically through the [MinSamplingInterval](bluetoothleadvertisementwatchertrigger_minsamplinginterval.md), [MaxSamplingInterval](bluetoothleadvertisementwatchertrigger_maxsamplinginterval.md), [MinOutOfRangeTimeout](bluetoothleadvertisementwatchertrigger_minoutofrangetimeout.md) and [MaxOutOfRangeTimeout](bluetoothleadvertisementwatchertrigger_maxoutofrangetimeout.md) properties.

## -examples

## -see-also
