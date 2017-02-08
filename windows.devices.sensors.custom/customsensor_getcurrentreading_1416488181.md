---
-api-id: M:Windows.Devices.Sensors.Custom.CustomSensor.GetCurrentReading
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.Custom.CustomSensorReading GetCurrentReading()
-->

# Windows.Devices.Sensors.Custom.CustomSensor.GetCurrentReading

## -description
Gets the current sensor reading.

## -returns
The current sensor reading.

## -remarks
An app may use this method to poll the sensor for the current reading as an alternative to registering a [ReadingChanged](customsensor_readingchanged.md) event handler. This would be the preferred alternative for an app that updates its user interface at a specific frame rate. Whether polling once or many times, the app must establish a desired [ReportInterval](customsensor_reportinterval.md). This informs the sensor driver to allocate resources to satisfy subsequent polling requests.

Before using the return value from this method, the app must first check that the value is not null. (If the value is null and you attempt to retrieve it, Windows will generate an exception.)

## -examples

## -see-also
