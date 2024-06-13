---
-api-id: P:Windows.Devices.Power.PowerGridData.IsLowUserExperienceImpact
-api-type: winrt property
---

# Windows.Devices.Power.PowerGridData.IsLowUserExperienceImpact

<!--
public bool IsLowUserExperienceImpact { get; }
-->


## -description

Gets a value indicating whether Windows predicts that the user will be away from their device, or not doing resource-intensive work. When making a decision about what time to time-shift a workload to, you can use this value to determine when you'll have the least impact on user experience.

## -property-value

`True` if Windows predicts that the user will be away, and you're free to time-shift any workload to this time without impairing user experience. `False` is Windows predicts that the user will be using their device, and you should decide whether time-shifting to this time will negatively impact user experience.

## -remarks

## -see-also

## -examples
