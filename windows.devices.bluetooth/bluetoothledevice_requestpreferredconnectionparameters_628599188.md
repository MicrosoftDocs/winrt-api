---
-api-id: M:Windows.Devices.Bluetooth.BluetoothLEDevice.RequestPreferredConnectionParameters(Windows.Devices.Bluetooth.BluetoothLEPreferredConnectionParameters)
-api-type: winrt method
---

# Windows.Devices.Bluetooth.BluetoothLEDevice.RequestPreferredConnectionParameters(Windows.Devices.Bluetooth.BluetoothLEPreferredConnectionParameters)

<!--
public Windows.Devices.Bluetooth.BluetoothLEPreferredConnectionParametersRequest RequestPreferredConnectionParameters (Windows.Devices.Bluetooth.BluetoothLEPreferredConnectionParameters preferredConnectionParameters);
-->

## -description

Retrieves a Bluetooth LE preferred connection parameters request object for the specified Bluetooth LE preferred connection parameters object.

## -parameters

### -param preferredConnectionParameters

A [BluetoothLEPreferredConnectionParameters](bluetoothlepreferredconnectionparameters.md) object representing the Bluetooth LE preferred connection parameters.

## -returns

A [BluetoothLEPreferredConnectionParametersRequest](bluetoothlepreferredconnectionparametersrequest.md) object representing the Bluetooth LE preferred connection parameters request.

## -remarks

When performing firmware updates, higher throughput is necessary to complete the operation swiftly for the user. In those scenarios, you should request [ThroughputOptimized](bluetoothlepreferredconnectionparameters_throughputoptimized.md) connection parameters for the duration of the firmware update. That will reduce the number of concurrent connections to other Bluetooth peripherals, and should be used sparingly. Once the firmware update is completed, you should restore the connection parameters to their defaults, either by disposing of the **BluetoothLEDevice**, or by requested new connection parameters.

Conversely, when connecting to multiple LE devices concurrently, you should use [PowerOptimized](bluetoothlepreferredconnectionparameters_poweroptimized.md). That will increase the acceptable peripheral latency for the connection, reducing the interval at which the LE device must respond to the host OS. That allows the local Bluetooth radio to schedule more connections concurrently, and reduces power usage on both the host OS and on the peripheral device.

## -see-also

## -examples

## -capabilities
bluetooth
