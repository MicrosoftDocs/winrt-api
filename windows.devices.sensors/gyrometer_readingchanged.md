---
-api-id: E:Windows.Devices.Sensors.Gyrometer.ReadingChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReadingChanged<Windows.Devices.Sensors.Gyrometer,  Windows.Devices.Sensors.GyrometerReadingChangedEventArgs>
-->

# Windows.Devices.Sensors.Gyrometer.ReadingChanged

## -description
Occurs each time the gyrometer reports the current sensor reading.

## -remarks
An application may register this event handler to obtain sensor readings. The application must establish a desired [ReportInterval](gyrometer_reportinterval.md). This informs the sensor driver that resources should be allocated to satisfy the requirements of the application.

Applications can set the frequency of this event by setting the **ReportInterval** property.

## -examples

The following example demonstrates how a UWP app built with C# and XAML registers its **ReadingChanged** event handler.

[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/gyrometer/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the ReadingChanged event handler.

[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/gyrometer/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]

## -see-also
