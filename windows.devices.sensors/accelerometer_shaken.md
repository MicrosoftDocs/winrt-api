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
Use this event to receive notification that the device containing the accelerometer has been shaken. The app is not required to set a report interval prior to registering for [Shaken](accelerometer_shaken.md) events.

The following example demonstrates how a Windows Store app built with C# and XAML registers its **Shaken** event handler.



[!code-cs[EnableShakenCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario2.xaml.cs#SnippetEnableShakenCS)]

The following example shows the [Shaken](accelerometer_shaken.md) event handler.



[!code-cs[ShakenCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario2.xaml.cs#SnippetShakenCS)]

The following example demonstrates how a Windows Store app built with JavaScript registers its **Shaken** event handler.



[!code-js[EnableShakenJS](../windows.devices.sensors/code/Accelerometer/javascript/scenario2.js#SnippetEnableShakenJS)]

The following example shows the [Shaken](accelerometer_shaken.md) event handler.



[!code-js[onShakenJS](../windows.devices.sensors/code/Accelerometer/javascript/scenario2.js#SnippetonShakenJS)]



> **Windows Phone 8**
> The accelerometer sensor does not raise the Shaken event on the Windows Phone 8 platform. If you add an event handler for the Shaken event in your Windows Phone 8 app, no error is raised, but the code in the event handler won’t run.

## -examples

## -see-also
