---
-api-id: E:Windows.Devices.Power.Battery.ReportUpdated
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ReportUpdated<Windows.Devices.Power.Battery,  object>
-->

# Windows.Devices.Power.Battery.ReportUpdated

## -description
<!--***in what increments does this change? Can it return a battery  aggregate?***-->
Occurs when the charge, capacity, or status of a battery changes.

## -remarks
The [ReportUpdated](battery_reportupdated.md) event is triggered by any change in status, charge rate, or power capacity on any of the batteries connected to the device. This typically happens immediately for status changes and periodically for all other changes.

## -examples

## -see-also
[Get battery information](http://msdn.microsoft.com/library/a9fb0f39-8827-420a-922d-dcee6fb9c9d2)