---
-api-id: E:Windows.Devices.Sensors.OrientationSensor.ReadingChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReadingChanged<Windows.Devices.Sensors.OrientationSensor,  Windows.Devices.Sensors.OrientationSensorReadingChangedEventArgs>
-->

# Windows.Devices.Sensors.OrientationSensor.ReadingChanged

## -description
Occurs each time the orientation sensor reports a new sensor reading.

## -remarks
An application may register this event handler to obtain sensor readings. The application must establish a desired [ReportInterval](orientationsensor_reportinterval.md). This informs the sensor driver that resources should be allocated to satisfy the requirements of the application.

The [OrientationSensor](orientationsensor.md) returns a quaternion and a rotation matrix.

## -examples

The following example demonstrates how a UWP app built with C# and XAML registers its **ReadingChanged** event handler.

[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/orientation/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the [ReadingChanged](orientationsensorreadingchangedeventargs.md) event handler.

[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/orientation/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]

## -see-also
