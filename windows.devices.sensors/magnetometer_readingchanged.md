---
-api-id: E:Windows.Devices.Sensors.Magnetometer.ReadingChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReadingChanged<Windows.Devices.Sensors.Magnetometer,  Windows.Devices.Sensors.MagnetometerReadingChangedEventArgs>
-->

# Windows.Devices.Sensors.Magnetometer.ReadingChanged

## -description
Occurs each time the compass reports a new sensor reading.

## -remarks
An application may register this event handler to obtain sensor readings. The application must establish a desired [ReportInterval](magnetometer_reportinterval.md). This informs the sensor driver that resources should be allocated to satisfy the requirements of the application.

Applications can set the frequency of this event by setting the **ReportInterval** property.

## -examples

## -see-also
