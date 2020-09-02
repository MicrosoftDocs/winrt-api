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
The ReportUpdated event is triggered by any change in status, charge rate, or power capacity on any of the batteries connected to the device. This typically happens immediately for status changes and periodically for all other changes.

## -examples

## -see-also
[Get battery information](/previous-versions/windows/apps/dn895210(v=win.10))
