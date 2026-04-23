---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskInfo.GetCompletedSteps
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskInfo.GetCompletedSteps

<!--
public string[] GetCompletedSteps ();
-->


## -description

Gets the sequence of steps that have been completed for this task.

## -returns

An array of strings that represent the completed steps in order.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

This method is useful when updating a task that was created with [AppTaskContent.CreateSequenceOfSteps](apptaskcontent_createsequenceofsteps_2102567378.md). Use the returned steps along with [GetExecutingStep](apptaskinfo_getexecutingstep_99219571.md) to create updated content.

## -see-also

## -examples


