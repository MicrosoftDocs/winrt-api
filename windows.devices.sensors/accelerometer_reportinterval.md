---
-api-id: P:Windows.Devices.Sensors.Accelerometer.ReportInterval
-api-type: winrt property
---

<!-- Property syntax
public uint ReportInterval { get;  set; }
-->

# Windows.Devices.Sensors.Accelerometer.ReportInterval

## -description

Gets or sets the current report interval for the accelerometer.

## -property-value

The current report interval, in milliseconds.

## -remarks

The report interval is set to a default value that varies based on the sensor driver’s implementation. If your app does not want to use this default value, you should set the report interval to a non-zero value prior to registering an event handler or calling [GetCurrentReading](accelerometer_getcurrentreading_1416488181.md). The sensor then attempts to allocate resources to satisfy the application’s requirements while balancing the needs of other apps using the sensor.

Changes to the report interval after an event handler has been registered, or [GetCurrentReading](accelerometer_getcurrentreading_1416488181.md) has been called, might apply to the delivery of subsequent sensor readings.

Conversely, when an application is finished with the sensor, it should explicitly return the sensor to its default report interval by setting it to zero. This is important for power conservation, especially when using a language that might keep the sensor object active for an indefinite period prior to garbage collection.

The application should consult the [MinimumReportInterval](accelerometer_minimumreportinterval.md) property prior to setting the report interval to ensure that the sensor can honor the requested report interval. Setting a value below the minimum supported interval either triggers an exception or has undefined results.

Although the application can set this value to request a particular report interval, the driver determines the actual report interval, based on internal logic. For example, the driver might use the shortest report interval that is requested by any caller.

If the value is set to zero, the driver uses its default report interval. As with requesting a specific interval, the driver might choose a different interval based on other client requests and internal logic.

<!-- Removing this piece based on MS VSO item 1118657. The sensor no longer adjusts change sensitivity based on the current report interval
    <p>The Sensor platform automatically sets the change sensitivity for accelerometers based on the current report interval. This table specifies the change sensitivity values for given intervals.</p>
        <table>
          <tr>
            <th>Current report interval (specified in milliseconds)</th>
            <th>Change sensitivity (specified as G force)</th>
          </tr>
          <tr>
            <td>1 ms <entity type="ndash"/> 16 ms</td>
            <td>0.01 G
</td>
          </tr>
          <tr>
            <td>17 ms <entity type="ndash"/> 32 ms</td>
            <td>0.02 G
</td>
          </tr>
          <tr>
            <td>&gt;= 33 ms</td>
            <td>0.05 G
</td>
          </tr>
        </table>
    -->

## -examples

## -see-also
