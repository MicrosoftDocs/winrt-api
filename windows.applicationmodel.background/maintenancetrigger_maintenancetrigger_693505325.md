---
-api-id: M:Windows.ApplicationModel.Background.MaintenanceTrigger.#ctor(System.UInt32,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public MaintenanceTrigger(System.UInt32 freshnessTime, System.Boolean oneShot)
-->

# Windows.ApplicationModel.Background.MaintenanceTrigger.MaintenanceTrigger

## -description
Initializes a new instance of a maintenance trigger.

## -parameters
### -param freshnessTime
The number of minutes to wait before scheduling the background task. The system schedules the task within 15 minutes after *freshnessTime* elapses.

### -param oneShot
True if the maintenance trigger is used once; false if it is used each time the *freshnessTime* interval elapses.

## -remarks

## -examples

## -see-also
