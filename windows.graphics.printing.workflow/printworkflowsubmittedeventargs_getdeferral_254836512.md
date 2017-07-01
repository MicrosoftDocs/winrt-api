---
-api-id: M:Windows.Graphics.Printing.Workflow.PrintWorkflowSubmittedEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax.
public Deferral PrintWorkflowSubmittedEventArgs.GetDeferral()
-->

# Windows.Graphics.Printing.Workflow.PrintWorkflowSubmittedEventArgs.GetDeferral

## -description
Gets a deferral object for managing the work done on the corresponding [PrintWorkflowBackgroundSession.Submitted](PrintWorkflowbackgroundsession_submitted.md) event.

## -returns
A deferral object.

## -remarks
A deferral should be used if any asynchronous work is being done in this event handler, so that the next event in the sequence isn't raised until this work is completed.

## -see-also

## -examples

