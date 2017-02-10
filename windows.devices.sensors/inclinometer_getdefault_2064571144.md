---
-api-id: M:Windows.Devices.Sensors.Inclinometer.GetDefault(Windows.Devices.Sensors.SensorReadingType)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.Inclinometer GetDefault(Windows.Devices.Sensors.SensorReadingType sensorReadingtype)
-->

# Windows.Devices.Sensors.Inclinometer.GetDefault

## -description
Returns the default inclinometer based on the [SensorReadingType](sensorreadingtype.md).

## -parameters
### -param sensorReadingtype
The type of sensor to retrieve.

## -returns
The default inclinometer or **null** if no inclinometers are found.

## -remarks
This method only returns values for hardware that has been integrated into the computer by the manufacturer. (The inclinometer readings are derived from multiple sensors.) A **null** value will be returned if the specified sensor is not available in the system.

When a system is in Connected Standby, a call to the [GetDefault](inclinometer_getdefault.md) method will return immediately with a **null** result.

## -examples

## -see-also
[GetDefault](inclinometer_getdefault_846721868.md)