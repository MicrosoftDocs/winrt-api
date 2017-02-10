---
-api-id: T:Windows.Devices.Sensors.Custom.CustomSensorReading
-api-type: winrt class
---

<!-- Class syntax.
public class CustomSensorReading : Windows.Devices.Sensors.Custom.ICustomSensorReading
-->

# Windows.Devices.Sensors.Custom.CustomSensorReading

## -description
Represents a property set of key/value pairs that contain the custom data sent from the sensor’s driver to the app.

Each key is a string that represents a [PROPERTYKEY](http://msdn.microsoft.com/library/3f5f31af-f040-443b-9045-9761055381ea). Each value can be an integer, Boolean, float, or double.

## -remarks
This object is accessed when you call the [GetCurrentReading](customsensor_getcurrentreading.md) method; and, it is accessed when you retrieve the [Reading](customsensorreadingchangedeventargs_reading.md) property of the [CustomSensorReadingChangedEventArgs](customsensorreadingchangedeventargs.md) object in the event callback method.

## -examples

## -see-also
