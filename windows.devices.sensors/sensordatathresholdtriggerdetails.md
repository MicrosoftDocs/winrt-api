---
-api-id: T:Windows.Devices.Sensors.SensorDataThresholdTriggerDetails
-api-type: winrt class
---

<!-- Class syntax.
public class SensorDataThresholdTriggerDetails : Windows.Devices.Sensors.ISensorDataThresholdTriggerDetails
-->

# Windows.Devices.Sensors.SensorDataThresholdTriggerDetails

## -description
Provides data for what sensor triggered the data threshold monitoring task.

## -remarks
In order to support the background trigger of sensors based on data threshold triggers, you will need to implement a method like [GetReadingsFromTriggerDetails](pedometer_getreadingsfromtriggerdetails.md). You will need to do this for every sensor you want to respond to the data threshold trigger.

## -examples

## -see-also
