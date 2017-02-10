---
-api-id: E:Windows.Devices.Sensors.Custom.CustomSensor.ReadingChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReadingChanged<Windows.Devices.Sensors.Custom.CustomSensor,  Windows.Devices.Sensors.Custom.CustomSensorReadingChangedEventArgs>
-->

# Windows.Devices.Sensors.Custom.CustomSensor.ReadingChanged

## -description
Occurs each time the sensor reports a new sensor reading.

## -remarks
An app may register this event handler to obtain sensor readings. The app must establish a desired [ReportInterval](customsensor_reportinterval.md). This informs the sensor driver to allocate resources to satisfy the requirements of the app.

## -examples

## -see-also
