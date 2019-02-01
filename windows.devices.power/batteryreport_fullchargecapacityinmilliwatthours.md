---
-api-id: P:Windows.Devices.Power.BatteryReport.FullChargeCapacityInMilliwattHours
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<int> FullChargeCapacityInMilliwattHours { get; }
-->

# Windows.Devices.Power.BatteryReport.FullChargeCapacityInMilliwattHours

## -description
Gets the fully-charged energy capacity of the battery.

## -property-value
The fully-charged energy capacity of the battery, in milliwatt-hours (mWh).

> Note: Some devices report their battery capacity in milliamp-hours (mAh) instead of mWh. As a rough heuristic, if the value reported is lower than 4400 it is likely represented in mAh, otherwise it is in mWh.

## -remarks
[FullChargeCapacityInMilliwattHours](batteryreport_fullchargecapacityinmilliwatthours.md) is used by the capacity ratio to estimate battery health.

## -examples

## -see-also
[Get battery information](https://msdn.microsoft.com/library/a9fb0f39-8827-420a-922d-dcee6fb9c9d2)
