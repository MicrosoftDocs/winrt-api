---
-api-id: P:Windows.Devices.Sensors.Custom.CustomSensor.MaxBatchSize
-api-type: winrt property
---

<!-- Property syntax.
public uint MaxBatchSize { get; }
-->

# Windows.Devices.Sensors.Custom.CustomSensor.MaxBatchSize

## -description
Gets the maximum number of events that can be batched by the sensor.

## -property-value
The maximum number of batched events.

## -remarks
A sensor may not support batched data collection. In that case, this property will be 0. Otherwise, this determines the maximum number of events the sensor can gather before submitting them. This in turn will determine the maximum supported [ReportLatency](customsensor_reportlatency.md). The maximum latency equals the [ReportInterval](customsensor_reportinterval.md) times the MaxBatchSize. For more information about sensor batching, see [Sensors](/windows/uwp/devices-sensors/sensors).
## -see-also

## -examples

