---
-api-id: M:Windows.System.Power.Diagnostics.BackgroundEnergyDiagnostics.ComputeTotalEnergyUsage
-api-type: winrt method
---

<!-- Method syntax
public ulong ComputeTotalEnergyUsage()
-->

# Windows.System.Power.Diagnostics.BackgroundEnergyDiagnostics.ComputeTotalEnergyUsage

## -description
Computes the total cumulative energy usage of the background task since the last reset, expressed as a percentage of normal.

> [!IMPORTANT]
> This method consumes significant CPU resources. We recommend using this method only for debugging purposes.

## -returns
The total cumulative energy usage of the background task since the last reset, expressed as a percentage of normal.

## -remarks
Reset the energy usage total by calling [ResetTotalEnergyUsage](backgroundenergydiagnostics_resettotalenergyusage.md).

The energy usage of a background task is classified into one of these predefined levels, from lowest to highest energy consumption: [LowUsageLevel](../windows.system.power/backgroundenergymanager_lowusagelevel.md), [NearMaxAcceptableUsageLevel](../windows.system.power/backgroundenergymanager_nearmaxacceptableusagelevel.md), [MaxAcceptableUsageLevel](../windows.system.power/backgroundenergymanager_maxacceptableusagelevel.md), [ExcessiveUsageLevel](../windows.system.power/backgroundenergymanager_excessiveusagelevel.md), [NearTerminationUsageLevel](../windows.system.power/backgroundenergymanager_nearterminationusagelevel.md), or [TerminationUsageLevel](../windows.system.power/backgroundenergymanager_terminationusagelevel.md).

## -examples

## -see-also
