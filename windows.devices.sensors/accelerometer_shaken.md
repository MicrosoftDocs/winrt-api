---
-api-id: E:Windows.Devices.Sensors.Accelerometer.Shaken
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Shaken<Windows.Devices.Sensors.Accelerometer,  Windows.Devices.Sensors.AccelerometerShakenEventArgs>
-->

# Windows.Devices.Sensors.Accelerometer.Shaken

## -description
Occurs when the accelerometer detects that the PC has been shaken.

## -remarks
Use this event to receive notification that the device containing the accelerometer has been shaken. The app is not required to set a report interval prior to registering for Shaken events.

Support for the Shaken event is dependent upon hardware and driver support. In practice, very few accelerometers support the Shaken event. If the accelerometer does not support the Shaken event and you add an event handler for the Shaken event, no error is raised, but the code in the event handler won't run.

## -examples

The following example demonstrates how a UWP app built with C# and XAML registers its **Shaken** event handler.

[!code-csharp[EnableShakenCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario2.xaml.cs#SnippetEnableShakenCS)]

The following example shows the Shaken event handler.

[!code-csharp[ShakenCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario2.xaml.cs#SnippetShakenCS)]

## -see-also
