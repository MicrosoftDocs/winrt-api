---
-api-id: P:Windows.Devices.Sensors.LightSensor.ReportLatency
-api-type: winrt property
---

<!-- Property syntax.
public uint ReportLatency { get;  set; }
-->

# Windows.Devices.Sensors.LightSensor.ReportLatency

## -description
Gets or sets the delay between batches of sensor information.

## -property-value
The delay between batches of sensor information in milliseconds.

## -remarks
This property is in reference to the frequency of [ReadingChanged](LightSensor_readingchanged.md) events.

Not all sensors support [ReportLatency](LightSensor_reportlatency.md). If the sensor does not support this property, it will function the same as if you set this value to 0. Setting this value to 0 will use the default latency for the sensor.

If you set [ReportLatency](LightSensor_reportlatency.md) to a value higher than the maximum supported latency, the sensor will use the maximum supported latency. However, this property will not change in value. The maximum possible [ReportLatency](LightSensor_reportlatency.md) equals the [MaxBatchSize](LightSensor_maxbatchsize.md) times the [ReportInterval](LightSensor_reportinterval.md).

Be aware that multiple applications could be dependent on a single sensor. Each of those applications can set a different value for [ReportLatency](LightSensor_reportlatency.md). In this scenario, the sensor needs to try to accommodate the lowest value for [ReportLatency](LightSensor_reportlatency.md). Because of this, the actual latency may not match the latency defined by this property in your application. This property corresponds to your ideal latency, which may not be the same latency on the sensor.

For more information about sensor batching, see [Sensors](/windows/uwp/devices-sensors/sensors).

## -examples

## -see-also

