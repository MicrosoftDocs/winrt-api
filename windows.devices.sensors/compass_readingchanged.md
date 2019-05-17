---
-api-id: E:Windows.Devices.Sensors.Compass.ReadingChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReadingChanged<Windows.Devices.Sensors.Compass,  Windows.Devices.Sensors.CompassReadingChangedEventArgs>
-->

# Windows.Devices.Sensors.Compass.ReadingChanged

## -description
Occurs each time the compass reports a new sensor reading.

## -remarks
An application may register this event handler to obtain sensor readings. The application must establish a desired [ReportInterval](compass_reportinterval.md). This informs the sensor driver that resources should be allocated to satisfy the requirements of the application.

Applications can set the frequency of this event by setting the **ReportInterval** property.

The following example demonstrates how a UWP app built with C# and XAML registers its **ReadingChanged** event handler.



[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/compass/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the ReadingChanged event handler.



[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/compass/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]

The following example demonstrates how a UWP app built with JavaScript registers its **ReadingChanged** event handler.



[!code-js[EnableReadingChangedJS](../windows.devices.sensors/code/compass/javascript/scenario1.js#SnippetEnableReadingChangedJS)]

The following example shows the ReadingChanged event handler.



[!code-js[onDataChangedJS](../windows.devices.sensors/code/compass/javascript/scenario1.js#SnippetonDataChangedJS)]

## -examples

## -see-also
