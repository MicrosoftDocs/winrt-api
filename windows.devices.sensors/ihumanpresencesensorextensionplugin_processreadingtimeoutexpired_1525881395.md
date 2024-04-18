---
-api-id: M:Windows.Devices.Sensors.IHumanPresenceSensorExtensionPlugin.ProcessReadingTimeoutExpired(Windows.Devices.Sensors.HumanPresenceSensorReading)
-api-type: winrt method
---

# Windows.Devices.Sensors.IHumanPresenceSensorExtensionPlugin.ProcessReadingTimeoutExpired(Windows.Devices.Sensors.HumanPresenceSensorReading)

<!--
public void ProcessReadingTimeoutExpired (Windows.Devices.Sensors.HumanPresenceSensorReading Reading);
-->

## -description

Called when the plugin does not complete a call to **[ProcessReading(Windows.Devices.Sensors.HumanPresenceSensorReading)](ihumanpresencesensorextensionplugin_processreading_1396978893.md)** within a pre-defined timeout.

## -parameters

### -param Reading

The **[HumanPresenceSensor](humanpresencesensor.md)** reading.

## -remarks

After calling this method, the sensor stack will proceed with the original reading. If the plugin eventually completes **[ProcessReading(Windows.Devices.Sensors.HumanPresenceSensorReading)](ihumanpresencesensorextensionplugin_processreading_1396978893.md)** for this reading with no errors, the resulting **[HumanPresenceSensorReadingUpdate](humanpresencesensorreadingupdate.md)** object will be ignored.

## -see-also

## -examples
