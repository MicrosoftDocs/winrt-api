---
-api-id: E:Windows.Devices.Sensors.ActivitySensor.ReadingChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReadingChanged<Windows.Devices.Sensors.ActivitySensor,  Windows.Devices.Sensors.ActivitySensorReadingChangedEventArgs>
-->

# Windows.Devices.Sensors.ActivitySensor.ReadingChanged

## -description
Occurs each time the sensor reports a new sensor reading.

## -remarks
When you add a callback function, you receive an initial callback. However, there is a case where you will not receive this initial callback.


+ Add a callback function.
+ Remove the callback function.
+ Add another callback function (or the original one a second time)


In this sequence of events, the second callback function will not receive the initial callback. It will receive callback notifications normally when the [ActivitySensor](activitysensor.md) reports a new reading; only the initial callback will be missed.

## -examples

## -see-also
