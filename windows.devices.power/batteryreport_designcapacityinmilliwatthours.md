---
-api-id: P:Windows.Devices.Power.BatteryReport.DesignCapacityInMilliwattHours
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<int> DesignCapacityInMilliwattHours { get; }
-->

# Windows.Devices.Power.BatteryReport.DesignCapacityInMilliwattHours

## -description
Gets the estimated energy capacity of a new battery of this type.

## -property-value
The estimated energy capacity of a new battery of this type, in milliwatt-hours (mWh).

## -remarks
This property is not supported by all battery controllers. Some battery controllers might return the same value as [FullChargeCapacityInMilliwattHours](batteryreport_fullchargecapacityinmilliwatthours.md) or return no value at all.

When this property is supported, the capacity ratio is the ratio of [FullChargeCapacityInMilliwattHours](batteryreport_fullchargecapacityinmilliwatthours.md) to DesignCapacityInMilliwattHours. [FullChargeCapacityInMilliwattHours](batteryreport_fullchargecapacityinmilliwatthours.md) is used in this way because the full charge capacity typically changes with battery wear.

## -examples

## -see-also
[Get battery information](/previous-versions/windows/apps/dn895210(v=win.10))
