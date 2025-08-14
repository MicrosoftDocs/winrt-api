---
-api-id: P:Windows.ApplicationModel.Background.BackgroundWorkCost.AppEnergyUseLevel
-api-type: winrt property
---

# Windows.ApplicationModel.Background.BackgroundWorkCost.AppEnergyUseLevel

<!--
public static Windows.ApplicationModel.Background.EnergyUseLevel AppEnergyUseLevel { get; }
-->

## -description

Gets the energy consumption level of the background task.

## -property-value

The energy consumption level of the background task, returned as a value of the [EnergyUseLevel](energyuselevel.md) enumeration.

## -remarks

This property allows a developer to check if their application's background tasks have been throttled in modern standby.

If the **AppEnergyUseLevel** is **EnergyUseLevel.OverBudget**, it indicates that an application's energy use is over the budget and its background tasks are subject to being throttled in modern standby. Once the system is not in modern standby, those tasks that were throttled may be activated.

## -see-also

## -examples
