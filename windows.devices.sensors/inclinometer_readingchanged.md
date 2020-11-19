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

## -examples

The following example demonstrates how a UWP app built with C# and XAML registered its **ReadingChanged** event handler.

[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/inclinometer/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the ReadingChanged event handler.

[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/inclinometer/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]

## -see-also
