---
-api-id: T:Windows.Devices.Sensors.SensorReadingType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Sensors.SensorReadingType : int
-->

# SensorReadingType

## -description
Specifies the sensor reading type.

## -enum-fields
### -field Absolute:0
The sensor reading type is absolute. **Absolute** sensors provide a reading that uses all of the sensors available.

### -field Relative:1
The sensor reading type is relative. **Relative** sensors provide a reading that is accurate under most conditions, but might not be as accurate as it attempts to not use all sensors available. See the Remarks for more information.


## -remarks
To understand the difference between an **Absolute** and a **Relative** sensor, consider the [OrientationSensor](orientationsensor.md). In order to provide an absolute reading, an Absolute [OrientationSensor](orientationsensor.md) will use an accelerometer, a gyrometer, and a magnetometer to determine its orientation with respect to magnetic North. In contrast, a relative [OrientationSensor](orientationsensor.md) will only use an accelerometer and gyrometer (no magnetometer), measuring its orientation relative to where the sensor is first instantiated.



## -examples

## -see-also