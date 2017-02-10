---
-api-id: M:Windows.Devices.Sensors.ProximitySensor.GetReadingsFromTriggerDetails(Windows.Devices.Sensors.SensorDataThresholdTriggerDetails)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Devices.Sensors.ProximitySensorReading> GetReadingsFromTriggerDetails(Windows.Devices.Sensors.SensorDataThresholdTriggerDetails triggerDetails)
-->

# Windows.Devices.Sensors.ProximitySensor.GetReadingsFromTriggerDetails

## -description
Gets readings from the trigger details in background task.

## -parameters
### -param triggerDetails
The trigger details received from the background task.

## -returns
The collection of proximity data retrieved from the trigger details.

## -remarks
[SensorDataThresholdTriggerDetails](sensordatathresholdtriggerdetails.md) objects are designed to be independent of the sensor that activated the background trigger. This enables you to support all of the sensors your are interested in with a single background task. In order to support this methodology, you need to define this method in all of your sensors that extract data from the background trigger.

## -examples

## -see-also
