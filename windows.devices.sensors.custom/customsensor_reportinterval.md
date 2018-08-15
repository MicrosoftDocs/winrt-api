---
-api-id: P:Windows.Devices.Sensors.Custom.CustomSensor.ReportInterval
-api-type: winrt property
---

<!-- Property syntax
public uint ReportInterval { get;  set; }
-->

# Windows.Devices.Sensors.Custom.CustomSensor.ReportInterval

## -description
Gets or sets the current report interval for the sensor.

## -property-value
The current report interval for the sensor.

## -remarks
The report interval is specified in milliseconds.

The report interval will be set to a default value that will vary based on the sensor driver’s implementation. If your app doesn't want to use this default value, set the report interval to a non-zero value prior to registering an event handler or calling [GetCurrentReading](customsensor_getcurrentreading_1416488181.md). The sensor will then attempt to allocate resources to satisfy the app’s requirements but the sensor also has to balance the needs of other apps using the sensor.

Changes to the report interval after an event handler has been registered or [GetCurrentReading](customsensor_getcurrentreading_1416488181.md) has been called may apply to the delivery of subsequent sensor readings.

Conversely, when an app is finished with the sensor, we recommend that it explicitly return the sensor to its default report interval by setting it to zero. This is important for power conservation, especially when using a language that may keep the sensor object active for an indefinite period prior to garbage collection.

We recommend that the app consult the [MinimumReportInterval](customsensor_minimumreportinterval.md) property prior to setting the report interval to ensure that the sensor can honor the requested report interval. Setting a value below the minimum supported interval will either trigger an exception or have undefined results.

Although the app can set this value to request a particular report interval, the driver will determine the actual report interval, based on internal logic. For example, the driver might use the shortest report interval that is requested by any caller.

Setting a value of zero requests the driver to use its default report interval. As with requesting a specific interval, the driver may choose a different interval based on other client requests and internal logic.

The custom sensor platform automatically sets the change sensitivity for custom sensors based on the current report interval. This table specifies the change sensitivity values for given intervals.

<table>
   <tr><th>Current report interval (specified in milliseconds)</th><th>Change sensitivity (specified as G force)</th></tr>
   <tr><td>1 ms – 16 ms</td><td>0.01 G</td></tr>
   <tr><td>17 ms – 32 ms</td><td>0.02 G</td></tr>
   <tr><td>&gt;= 33 ms</td><td>0.05 G</td></tr>
</table>

## -examples

## -see-also
