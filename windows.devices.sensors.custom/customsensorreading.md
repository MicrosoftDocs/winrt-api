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

Each key is a string that represents a [PROPERTYKEY](https://docs.microsoft.com/windows/desktop/api/wtypes/ns-wtypes-_tagpropertykey). Each value can be an integer, Boolean, float, or double.

## -remarks
This object is accessed when you call the [GetCurrentReading](customsensor_getcurrentreading_1416488181.md) method; and, it is accessed when you retrieve the [Reading](customsensorreadingchangedeventargs_reading.md) property of the [CustomSensorReadingChangedEventArgs](customsensorreadingchangedeventargs.md) object in the event callback method.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | PerformanceCount |

## -examples

## -see-also
