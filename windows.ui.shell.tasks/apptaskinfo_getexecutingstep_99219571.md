---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskInfo.GetExecutingStep
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskInfo.GetExecutingStep

<!--
public string GetExecutingStep ();
-->


## -description

Gets the step that is currently executing for this task.

## -returns

The currently executing step.

## -remarks

This method is useful when updating a task that was created with [AppTaskContent.CreateSequenceOfSteps](apptaskcontent_createsequenceofsteps_2102567378.md). Use the returned step along with [GetCompletedSteps](apptaskinfo_getcompletedsteps_215791606.md) to create updated content.

## -see-also

## -examples


