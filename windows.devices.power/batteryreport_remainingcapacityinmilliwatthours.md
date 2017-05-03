---
-api-id: P:Windows.Devices.Power.BatteryReport.RemainingCapacityInMilliwattHours
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<int> RemainingCapacityInMilliwattHours { get; }
-->

# Windows.Devices.Power.BatteryReport.RemainingCapacityInMilliwattHours

## -description
Gets the remaining power capacity of the battery.

## -property-value
The remaining power capacity of the battery, in milliwatt-hours.

## -remarks
To calculate the battery level, divide [RemainingCapacityInMilliwattHours](batteryreport_remainingcapacityinmilliwatthours.md) by [FullChargeCapacityInMilliwattHours](batteryreport_fullchargecapacityinmilliwatthours.md).

## -examples

## -see-also
[Get battery information](http://msdn.microsoft.com/library/a9fb0f39-8827-420a-922d-dcee6fb9c9d2)