---
-api-id: E:Windows.Devices.Sensors.Accelerometer.ReadingChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReadingChanged<Windows.Devices.Sensors.Accelerometer,  Windows.Devices.Sensors.AccelerometerReadingChangedEventArgs>
-->

# Windows.Devices.Sensors.Accelerometer.ReadingChanged

## -description
Occurs each time the accelerometer reports a new sensor reading.

## -remarks
An application may register this event handler to obtain sensor readings. The application must establish a desired [ReportInterval](accelerometer_reportinterval.md). This informs the sensor driver that resources should be allocated to satisfy the requirements of the application.

The following example demonstrates how a UWP app built with C# and XAML registers its **ReadingChanged** event handler.



[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the ReadingChanged event handler.



[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario1.xaml.cs#SnippetReadingChangedCS)]

The following example demonstrates how a UWP app built with JavaScript registers its **ReadingChanged** event handler.



[!code-js[EnableDataChangedJS](../windows.devices.sensors/code/Accelerometer/javascript/scenario1.js#SnippetEnableDataChangedJS)]

The following example shows the ReadingChanged event handler.



[!code-js[onDataChangedJS](../windows.devices.sensors/code/Accelerometer/javascript/scenario1.js#SnippetonDataChangedJS)]

## -examples

## -see-also
[Accelerometer sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Accelerometer)
