---
-api-id: E:Windows.Devices.Sensors.SimpleOrientationSensor.OrientationChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler OrientationChanged<Windows.Devices.Sensors.SimpleOrientationSensor,  Windows.Devices.Sensors.SimpleOrientationSensorOrientationChangedEventArgs>
-->

# Windows.Devices.Sensors.SimpleOrientationSensor.OrientationChanged

## -description
Occurs each time the simple orientation sensor reports a new sensor reading

## -remarks
The following example demonstrates how a UWP app built with C# and XAML registers its OrientationChanged event handler.



[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/simpleorientation/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example demonstrates how a UWP app built with XAML registers an OrientationChanged event handler.



[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/simpleorientation/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]



[!code-csharp[ReadingChanged2CS](../windows.devices.sensors/code/simpleorientation/csharp/Scenario1.xaml.cs#SnippetReadingChanged2CS)]

The following example demonstrates how a UWP app built with JavaScript registers its OrientationChanged event handler.



[!code-js[EnableReadingChangedJS](../windows.devices.sensors/code/simpleorientation/javascript/scenario1.js#SnippetEnableReadingChangedJS)]

The following example shows the OrientationChanged event handler.



[!code-js[onDataChangedJS](../windows.devices.sensors/code/simpleorientation/javascript/scenario1.js#SnippetonDataChangedJS)]

## -examples

## -see-also
