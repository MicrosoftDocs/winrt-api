---
-api-id: M:Windows.Devices.Sensors.Inclinometer.GetCurrentReading
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.InclinometerReading GetCurrentReading()
-->

# Windows.Devices.Sensors.Inclinometer.GetCurrentReading

## -description
Gets the current inclinometer reading.

## -returns
The current inclinometer reading.

## -remarks
An application may use this method to poll the sensor for the current reading as an alternative to registering a [ReadingChanged](inclinometer_readingchanged.md) event handler. This would be the preferred alternative for an application that updates its user interface at a specific frame rate. Whether polling once or many times, the application must establish a desired [ReportInterval](inclinometer_reportinterval.md). This informs the sensor driver that resources should be allocated to satisfy subsequent polling requests

Before using the return value from this method, the application must first check that the value is not null. (If the value is null and you attempt to retrieve it, Windows will generate an exception.)

## -examples

The following example demonstrates how a UWP app built with XAML and C# retrieves the current reading for the default inclinometer.

[!code-csharp[GetCurrentReadingCS](../windows.devices.sensors/code/inclinometer/csharp/Scenario2.xaml.cs#SnippetGetCurrentReadingCS)]

## -see-also
