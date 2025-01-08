---
-api-id: E:Windows.Graphics.Printing.Workflow.PrintWorkflowJobBackgroundSession.JobIssueDetected
-api-type: winrt event
---

# Windows.Graphics.Printing.Workflow.PrintWorkflowJobBackgroundSession.JobIssueDetected

<!--
public event Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.Workflow.PrintWorkflowJobBackgroundSession,Windows.Graphics.Printing.Workflow.PrintWorkflowJobIssueDetectedEventArgs> JobIssueDetected;
-->


## -description

Raised when an error or warning is detected in the the current printer job operation.

## -remarks

In the handler for this event, apps can call [SkipSystemErrorToast](printworkflowjobissuedetectedeventargs_skipsystemerrortoast.md) to suppress the default system toast notification for the issue. This enables apps to launch their own custom toast notification without the user receiving redundant notifications.

## -see-also

## -examples


