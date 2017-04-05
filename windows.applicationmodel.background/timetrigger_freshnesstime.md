---
-api-id: P:Windows.ApplicationModel.Background.TimeTrigger.FreshnessTime
-api-type: winrt property
---

<!-- Property syntax
public uint FreshnessTime { get; }
-->

# Windows.ApplicationModel.Background.TimeTrigger.FreshnessTime

## -description
Gets the interval of a time event trigger.

## -property-value
Specifies the number of minutes to wait before scheduling the background task. The minimum value for **FreshnessTime** is 15 minutes. The system schedules the task within 15 minutes after **FreshnessTime** elapses.

## -remarks
The system uses a 15-minute tick frequency for timer requests. A time-triggered background task is scheduled on the next tick after **FreshnessTime** elapses. If the [OneShot](timetrigger_oneshot.md) property is false, **FreshnessTime** specifies the interval for a recurring task.


> [!NOTE]
> To understand the timeframe within which the time trigger may fire, consider a **FreshnessTime** set to 15 minutes. Because the system schedules the task within 15 minutes after *FreshnessTime* elapses, it may be up to 30 minutes before the time trigger fires.

## -examples

## -see-also
