---
-api-id: P:Windows.Graphics.Printing.Workflow.PrintWorkflowJobIssueDetectedEventArgs.SkipSystemErrorToast
-api-type: winrt property
---

# Windows.Graphics.Printing.Workflow.PrintWorkflowJobIssueDetectedEventArgs.SkipSystemErrorToast

<!--
public bool SkipSystemErrorToast { get; set; }
-->


## -description

Gets a sets a value that specifies whether the default system toast notification for the printer job issue should be skipped.

## -property-value

True if the system toast notification should be skipped; otherwise, false.

## -remarks

Setting this property to true in the handler for [PrintWorkflowJobBackgroundSession.JobIssueDetected](printworkflowjobbackgroundsession_jobissuedetected.md) enables apps to launch their own custom toast notification without the user receiving redundant notifications.

## -see-also

## -examples


