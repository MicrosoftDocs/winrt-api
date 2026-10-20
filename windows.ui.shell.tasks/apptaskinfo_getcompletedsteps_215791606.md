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

This method is useful when updating a task that was created with [AppTaskContent.CreateSequenceOfSteps](apptaskcontent_createsequenceofsteps_2102567378.md). Use the returned steps along with [GetExecutingStep](apptaskinfo_getexecutingstep_99219571.md) to create updated content.

## -see-also

## -examples


