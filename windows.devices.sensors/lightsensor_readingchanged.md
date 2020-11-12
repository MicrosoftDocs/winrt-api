---
-api-id: E:Windows.Devices.Sensors.LightSensor.ReadingChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReadingChanged<Windows.Devices.Sensors.LightSensor,  Windows.Devices.Sensors.LightSensorReadingChangedEventArgs>
-->

# Windows.Devices.Sensors.LightSensor.ReadingChanged

## -description
Occurs each time the ambient-light sensor reports a new sensor reading.

## -remarks
An application may register this event handler to obtain sensor readings. The application must establish a desired [ReportInterval](lightsensor_reportinterval.md). This informs the sensor driver that resources should be allocated to satisfy the requirements of the application.

Applications can set the frequency of this event by setting the **ReportInterval** property.

## -examples

The following example demonstrates how a UWP app built with C# and XAML registers its **ReadingChanged** event handler.

[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/lightsensor/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the ReadingChanged event handler.

[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/lightsensor/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]

## -see-also
