---
-api-id: M:Windows.ApplicationModel.Background.TimeTrigger.#ctor(System.UInt32,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public TimeTrigger(System.UInt32 freshnessTime, System.Boolean oneShot)
-->

# Windows.ApplicationModel.Background.TimeTrigger.TimeTrigger

## -description
Initializes a new instance of a time event trigger.

## -parameters
### -param freshnessTime
Specifies the number of minutes to wait before scheduling the background task. The system schedules the task within 15 minutes after *freshnessTime* elapses. If the [OneShot](timetrigger_oneshot.md) property is false, *freshnessTime* specifies the interval between recurring tasks.

> [!NOTE]
> If *FreshnessTime* is set to less than 15 minutes, an exception is thrown when attempting to register the background task.

### -param oneShot
True if the time event trigger will be used once; false if it will be used each time *freshnessTime* elapses.

## -remarks

## -examples

## -see-also
