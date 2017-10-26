---
-api-id: M:Windows.Devices.Sensors.Accelerometer.GetCurrentReading
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.AccelerometerReading GetCurrentReading()
-->

# Windows.Devices.Sensors.Accelerometer.GetCurrentReading

## -description
Gets the current accelerometer reading.

## -returns
This method has no parameters.

## -remarks
An application may use this method to poll the sensor for the current reading as an alternative to registering a [ReadingChanged](accelerometer_readingchanged.md) event handler. This would be the preferred alternative for an application that updates its user interface at a specific frame rate. Whether polling once or many times, the application must establish a desired [ReportInterval](accelerometer_reportinterval.md). This informs the sensor driver that resources should be allocated to satisfy subsequent polling requests

If the sensor is configured to support batch delivery, this method flushes the current batch and starts a new latency period. For more information about sensor batching, see [Sensors](http://msdn.microsoft.com/library/415f4107-0612-4235-9722-0f5e4e26f957).

Before using the return value from this method, the application must first check that the value is not null. (If the value is null and you attempt to retrieve it, Windows will generate an exception.)

The following example demonstrates how a UWP app built with XAML and C# retrieves the current reading for the three axes of the default accelerometer.



[!code-csharp[GetCurrentReadingCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario3.xaml.cs#SnippetGetCurrentReadingCS)]

The following example demonstrates how a UWP app built for Windows using JavaScript retrieves the current reading for the three axes of the default accelerometer.



[!code-js[GetReadingJS](../windows.devices.sensors/code/Accelerometer/javascript/scenario3.js#SnippetGetReadingJS)]

## -examples

## -see-also
[Sensor data and display orientation](http://msdn.microsoft.com/library/f90937f1-edaf-469c-b360-2ed67cb4fad0), [Accelerometer sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620477)
