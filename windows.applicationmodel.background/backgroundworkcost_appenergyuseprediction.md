---
-api-id: P:Windows.ApplicationModel.Background.BackgroundWorkCost.AppEnergyUsePrediction
-api-type: winrt property
---

# Windows.ApplicationModel.Background.BackgroundWorkCost.AppEnergyUsePrediction

<!--
public static Windows.ApplicationModel.Background.EnergyUseLevel AppEnergyUsePrediction { get; }
-->

## -description

Gets the predicted energy consumption of the background task.

## -property-value

The predicted energy consumption of the background task, returned as a value of the [EnergyUseLevel](energyuselevel.md) enumeration.

## -remarks

This property allows a developer to check if their application's background tasks may be throttled in modern standby.

The **AppEnergyUsePrediction** indicates the energy use by its background tasks in modern standby, and provides a diagnostic tool for developers before any system decisions are made. If the **AppEnergyUsePrediction** is **EnergyUseTrend.OverBudget**, it indicates the application is running background tasks at a rate that will cause its energy use to be over budget. Developers can monitor this trend and reduce work done in modern standby before being throttled.

## -see-also

## -examples
