---
-api-id: P:Windows.Devices.Sensors.OrientationSensor.ReportInterval
-api-type: winrt property
---

<!-- Property syntax
public uint ReportInterval { get;  set; }
-->

# Windows.Devices.Sensors.OrientationSensor.ReportInterval

## -description

Gets or sets the report interval supported by the sensor.

## -property-value

The report interval supported by the sensor, in milliseconds.

## -remarks

The report interval is set to a default value that varies based on the sensor driver’s implementation. If your app does not want to use this default value, you should set the report interval to a non-zero value prior to registering an event handler or calling [GetCurrentReading](orientationsensor_getcurrentreading_1416488181.md). The sensor then attempts to allocate resources to satisfy the application’s requirements while balancing the needs of other apps using the sensor.

Changes to the report interval after an event handler has been registered, or [GetCurrentReading](orientationsensor_getcurrentreading_1416488181.md) has been called, might apply to the delivery of subsequent sensor readings.

Conversely, when an application is finished with the sensor, it should explicitly return the sensor to its default report interval by setting it to zero. This is important for power conservation, especially when using a language that might keep the sensor object active for an indefinite period prior to garbage collection.

The application should consult the [MinimumReportInterval](orientationsensor_minimumreportinterval.md) property prior to setting the report interval to ensure that the sensor can honor the requested report interval. Setting a value below the minimum supported interval either triggers an exception or has undefined results.

Although the application can set this value to request a particular report interval, the driver determines the actual report interval, based on internal logic. For example, the driver might use the shortest report interval that is requested by any caller.

If the value is set to zero, the driver uses its default report interval. As with requesting a specific interval, the driver might choose a different interval based on other client requests and internal logic.

The sensor platform automatically sets the change sensitivity for orientation sensors based on the current report interval. This table specifies the change sensitivity values for given intervals.

| Current report interval | Change sensitivity |
| --- | --- |
| 1 ms – 16 ms | 0.01 degrees |
| 17 ms – 32 ms | 0.5 degrees |
| >= 33 ms | 2 degrees |

## -examples

## -see-also
