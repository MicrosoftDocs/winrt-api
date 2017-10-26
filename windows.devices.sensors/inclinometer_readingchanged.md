---
-api-id: E:Windows.Devices.Sensors.Inclinometer.ReadingChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReadingChanged<Windows.Devices.Sensors.Inclinometer,  Windows.Devices.Sensors.InclinometerReadingChangedEventArgs>
-->

# Windows.Devices.Sensors.Inclinometer.ReadingChanged

## -description
Occurs each time the inclinometer reports a new sensor reading.

## -remarks
Applications can set the frequency of this event by setting the **ReportInterval** property.

The following example demonstrates how a UWP app built with C# and XAML registered its **ReadingChanged** event handler.



[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/inclinometer/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the [ReadingChanged](inclinometer_readingchanged.md) event handler.



[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/inclinometer/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]

The following example demonstrates how a UWP app built with JavaScript registers its [ReadingChanged](inclinometer_readingchanged.md) event handler.



[!code-js[EnableDataChangedJS](../windows.devices.sensors/code/inclinometer/javascript/scenario1.js#SnippetEnableDataChangedJS)]

The following example shows the [ReadingChanged](inclinometer_readingchanged.md) event handler.



[!code-js[onDataChangedJS](../windows.devices.sensors/code/inclinometer/javascript/scenario1.js#SnippetonDataChangedJS)]

## -examples

## -see-also
