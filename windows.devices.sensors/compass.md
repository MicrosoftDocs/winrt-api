---
-api-id: T:Windows.Devices.Sensors.Compass
-api-type: winrt class
---

<!-- Class syntax.
public class Compass : Windows.Devices.Sensors.ICompass, Windows.Devices.Sensors.ICompass2, Windows.Devices.Sensors.ICompassDeviceId
-->

# Windows.Devices.Sensors.Compass

## -description
Represents a compass sensor.

This sensor returns a heading with respect to Magnetic North and, possibly, True North. (The latter is dependent on the system capabilities.)

For an example implementation, see the [compass sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Compass).

## -remarks
Sensor data is provided relative to the device's fixed sensor coordinate system, and is independent of display orientation. For applications that rely on sensor data for input control or to manipulate elements on the screen, the developer must take current display orientation into account and compensate the data appropriately. For more info about the sensor coordinate system, see [Sensor data and display orientation](http://msdn.microsoft.com/library/f90937f1-edaf-469c-b360-2ed67cb4fad0).

The following example demonstrates how a UWP app built with XAML and C# uses the [GetDefault](compass_getdefault_846721868.md) method to establish a connection to a compass. If no integrated compass is found, the method will return a null value.



[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/compass/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

The following example demonstrates how a UWP app built with XAML registers a [ReadingChanged](compass_readingchanged.md) event handler.



[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/compass/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the [ReadingChanged](compass_readingchanged.md) event handler.



[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/compass/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]

## -examples

## -see-also
[Compass Sample](http://go.microsoft.com/fwlink/p/?linkid=241378), [Sensor data and display orientation](http://msdn.microsoft.com/library/f90937f1-edaf-469c-b360-2ed67cb4fad0), [Compass sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620521)
