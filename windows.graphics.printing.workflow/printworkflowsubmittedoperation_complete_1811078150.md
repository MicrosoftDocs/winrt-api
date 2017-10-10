---
-api-id: M:Windows.Graphics.Printing.Workflow.PrintWorkflowSubmittedOperation.Complete(Windows.Graphics.Printing.Workflow.PrintWorkflowSubmittedStatus)
-api-type: winrt method
---

<!-- Method syntax.
public void PrintWorkflowSubmittedOperation.Complete(PrintWorkflowSubmittedStatus status)
-->

# Windows.Graphics.Printing.Workflow.PrintWorkflowSubmittedOperation.Complete

## -description
Indicates the completion of the print workflow session. This method should be called in the handler for the [PrintWorkflowBackgroundSession.Submitted](PrintWorkflowBackgroundSession_Submitted.md) event when all work relating to the print task has been completed or when an error occurred that requires the process to be aborted.

## -parameters
### -param status
Indicates the status of the completed print workflow procedure. This will determine whether the printing pipeline should continue or abort.

## -remarks
This method marks the end of the print workflow session and therefore should only be called once.

## -see-also

## -examples

