---
-api-id: P:Windows.Devices.Sensors.Accelerometer.ReadingTransform
-api-type: winrt property
---

<!-- Property syntax
public Windows.Graphics.Display.DisplayOrientations ReadingTransform { get;  set; }
-->

# Windows.Devices.Sensors.Accelerometer.ReadingTransform

## -description
Gets or sets the transformation that needs to be applied to sensor data. Transformations to be applied are tied to the display orientation with which to align the sensor data.

## -property-value
A [DisplayOrientations](../windows.graphics.display/displayorientations.md)-typed value that specifies the display orientation with which to align the sensor data.

## -remarks

This property provides these improvements:

+ Differences in the sensor data on landscape-first devices versus portrait-first devices are no longer important.
+ Easily port existing sensor-based apps that were written for landscape-first devices to portrait-first devices and vice-versa.
+ Allows handling of display orientation changes. You can align the sensor data with the current orientation by updating the sensor’s ReadingTransform to match the current display orientation.
+ Allows aligning sensor data with a display orientation that is different from the current display orientation.


## -examples

## -see-also
