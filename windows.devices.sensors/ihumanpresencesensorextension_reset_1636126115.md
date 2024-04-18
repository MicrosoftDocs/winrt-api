---
-api-id: M:Windows.Devices.Sensors.IHumanPresenceSensorExtension.Reset
-api-type: winrt method
---

# Windows.Devices.Sensors.IHumanPresenceSensorExtension.Reset

<!--
public void Reset ();
-->

## -description

Resets a **[HumanPresenceSensor](humanpresencesensor.md)** stream if not responding correctly.

## -remarks

Any code required to reset the plugin should go here.

If Reset fails, the sensor stack will bypass the plugin for subsequent sensor readings. The plugin is considered in a bad state when three calls in a row to **[ProcessReading(Windows.Devices.Sensors.HumanPresenceSensorReading)](ihumanpresencesensorextensionplugin_processreading_1396978893.md)** result in a timeout.

## -see-also

[Stop](ihumanpresencesensorextension_stop_1201535524.md), [Start](ihumanpresencesensorextension_start_1587696324.md)

## -examples
