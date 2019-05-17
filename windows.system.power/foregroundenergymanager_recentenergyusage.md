---
-api-id: P:Windows.System.Power.ForegroundEnergyManager.RecentEnergyUsage
-api-type: winrt property
---

<!-- Property syntax
public uint RecentEnergyUsage { get; }
-->

# Windows.System.Power.ForegroundEnergyManager.RecentEnergyUsage

## -description
Gets the nearest predefined energy level of the foreground app for the current 30 minute period, equal to [LowUsageLevel](foregroundenergymanager_lowusagelevel.md), [NearMaxAcceptableUsageLevel](foregroundenergymanager_nearmaxacceptableusagelevel.md), [MaxAcceptableUsageLevel](foregroundenergymanager_maxacceptableusagelevel.md), or [ExcessiveUsageLevel](foregroundenergymanager_excessiveusagelevel.md).

## -property-value
The nearest predefined energy level of the foreground app for the current 30 minute period.

## -remarks
The RecentEnergyUsage property is a more accurate measure of energy usage than [RecentEnergyUsageLevel](foregroundenergymanager_recentenergyusagelevel.md). The RecentEnergyUsage value will typically fall between predefined energy levels. The [RecentEnergyUsageLevel](foregroundenergymanager_recentenergyusagelevel.md) will always equal the nearest predefined energy level.

## -examples

## -see-also
