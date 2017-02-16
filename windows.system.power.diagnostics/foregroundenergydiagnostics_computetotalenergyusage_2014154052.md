---
-api-id: M:Windows.System.Power.Diagnostics.ForegroundEnergyDiagnostics.ComputeTotalEnergyUsage
-api-type: winrt method
---

<!-- Method syntax
public ulong ComputeTotalEnergyUsage()
-->

# Windows.System.Power.Diagnostics.ForegroundEnergyDiagnostics.ComputeTotalEnergyUsage

## -description
Computes the total cumulative energy usage of the foreground app since the last reset, expressed as a percentage of normal.

> [!IMPORTANT]
> This method consumes significant CPU resources. We recommend using this method only for debugging purposes.

## -returns
The total cumulative energy usage of the foreground app since the last reset, expressed as a percentage of normal.

## -remarks
> [!IMPORTANT]
> This method consumes significant CPU resources. We recommend using this method only for debugging purposes.

Reset the energy usage total by calling [ResetTotalEnergyUsage](foregroundenergydiagnostics_resettotalenergyusage.md).

The energy usage of a foreground app is classified into one these predefined levels, from lowest to highest energy consumption: [LowUsageLevel](../windows.system.power/foregroundenergymanager_lowusagelevel.md), [NearMaxAcceptableUsageLevel](../windows.system.power/foregroundenergymanager_nearmaxacceptableusagelevel.md), [MaxAcceptableUsageLevel](../windows.system.power/foregroundenergymanager_maxacceptableusagelevel.md), or [ExcessiveUsageLevel](../windows.system.power/foregroundenergymanager_excessiveusagelevel.md).

## -examples

## -see-also
