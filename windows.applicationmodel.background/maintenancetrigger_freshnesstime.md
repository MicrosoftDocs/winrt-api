---
-api-id: P:Windows.ApplicationModel.Background.MaintenanceTrigger.FreshnessTime
-api-type: winrt property
---

<!-- Property syntax
public uint FreshnessTime { get; }
-->

# Windows.ApplicationModel.Background.MaintenanceTrigger.FreshnessTime

## -description
Gets the interval of a maintenance trigger.

## -property-value
The number of minutes to wait before scheduling the background task. The system schedules the task within 15 minutes after [FreshnessTime](timetrigger_freshnesstime.md) elapses.

## -remarks
The provided value acts as a suggested value, because it may change depending on system polices in place. Examples of system policies that could override this value include Battery Saver, Game Mode, or the system detecting that the application is not being used very often. The list of system policies that affect this value can also change from release to release.

Passing in a value greater than 30 days (in minutes) may result in an argument exception.

## -examples

## -see-also
