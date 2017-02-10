---
-api-id: P:Windows.System.Power.BackgroundEnergyManager.RecentEnergyUsage
-api-type: winrt property
---

<!-- Property syntax
public uint RecentEnergyUsage { get; }
-->

# Windows.System.Power.BackgroundEnergyManager.RecentEnergyUsage

## -description
Gets the energy usage of the app's background task for the current 30 minute period, expressed as a percentage of normal.

## -property-value
The energy usage of the app's background task for the current 30 minute period, expressed as a percentage of normal.

## -remarks
The [RecentEnergyUsage](backgroundenergymanager_recentenergyusage.md) property is a more accurate measure of energy usage than [RecentEnergyUsageLevel](backgroundenergymanager_recentenergyusagelevel.md). The [RecentEnergyUsage](backgroundenergymanager_recentenergyusage.md) value will typically fall between predefined energy levels. The [RecentEnergyUsageLevel](backgroundenergymanager_recentenergyusagelevel.md) will always equal the nearest predefined energy level.

## -examples

## -see-also
