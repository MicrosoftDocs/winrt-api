---
-api-id: T:Windows.Devices.Sensors.SimpleOrientationSensor
-api-type: winrt class
---

<!-- Class syntax.
public class SimpleOrientationSensor : Windows.Devices.Sensors.ISimpleOrientationSensor, Windows.Devices.Sensors.ISimpleOrientationSensor2, Windows.Devices.Sensors.ISimpleOrientationSensorDeviceId
-->

# Windows.Devices.Sensors.SimpleOrientationSensor

## -description
Represents a simple orientation sensor.

This sensor detects the current quadrant orientation of the specified device as well as its face-up or face-down status.

## -remarks
The following example demonstrates how a Windows Store app built with XAML and C# uses the [GetDefault](simpleorientationsensor_getdefault.md) method to establish a connection to a simple orientation sensor. If no simple orientation sensor is found, the method will return a null value.



[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/simpleorientation/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

The following example demonstrates how a Windows Store app built with XAML registers a [OrientationChanged](simpleorientationsensor_orientationchanged.md) event handler.



[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/simpleorientation/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example contains the XAML code for the event handler which writes the orientation readings to the application's form.



[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/simpleorientation/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]



[!code-csharp[ReadingChanged2CS](../windows.devices.sensors/code/simpleorientation/csharp/Scenario1.xaml.cs#SnippetReadingChanged2CS)]

## -examples

## -see-also
[SimpleOrientation Sensor Sample](http://go.microsoft.com/fwlink/p/?linkid=241383), [Camera preview frame sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620516), [Basic camera app sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619479), [Camera face detection sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619486), [Video stabilization sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620519), [Manual camera controls sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=627611), [High dynamic range sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620517)
