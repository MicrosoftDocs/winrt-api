---
-api-id: M:Windows.Devices.Sensors.IHumanPresenceSensorExtension.ProcessReading(Windows.Devices.Sensors.HumanPresenceSensorReading)
-api-type: winrt method
---

# Windows.Devices.Sensors.IHumanPresenceSensorExtension.ProcessReading(Windows.Devices.Sensors.HumanPresenceSensorReading)

<!--
public Windows.Devices.Sensors.HumanPresenceSensorReadingUpdate ProcessReading (Windows.Devices.Sensors.HumanPresenceSensorReading reading);
-->

## -description

Updates a **[HumanPresenceSensor](humanpresencesensor.md)** reading from the sensor stack and returns an updated reading to the sensor stack for processing.

### -param Reading

The **[HumanPresenceSensor](humanpresencesensor.md)** reading.

## -returns

The updated **[HumanPresenceSensor](humanpresencesensor.md)** reading.

## -remarks

This method will not be called for a new sensor reading until any previous sensor reading has been processed or timed out.

## -see-also

## -examples
