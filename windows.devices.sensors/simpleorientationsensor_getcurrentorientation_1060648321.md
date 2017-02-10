---
-api-id: M:Windows.Devices.Sensors.SimpleOrientationSensor.GetCurrentOrientation
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.SimpleOrientation GetCurrentOrientation()
-->

# Windows.Devices.Sensors.SimpleOrientationSensor.GetCurrentOrientation

## -description
Gets the default simple orientation sensor.

## -returns
The default simple orientation sensor.

## -remarks
An application may use this method to poll the sensor for the current reading as an alternative to registering a [OrientationChanged](simpleorientationsensor_orientationchanged.md) event handler. This would be the preferred alternative for an application that updates its user interface at a specific frame rate.

The following example demonstrates how a Windows Store app built for Windows using JavaScript retrieved the current device orientation by using the simple orientation sensor.



[!code-js[GetReadingJS](../windows.devices.sensors/code/simpleorientation/javascript/scenario2.js#SnippetGetReadingJS)]

## -examples

## -see-also
