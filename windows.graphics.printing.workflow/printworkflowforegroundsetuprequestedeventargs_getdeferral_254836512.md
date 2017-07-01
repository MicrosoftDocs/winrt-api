---
-api-id: M:Windows.Graphics.Printing.Workflow.PrintWorkflowForegroundSetupRequestedEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax.
public Deferral PrintWorkflowForegroundSetupRequestedEventArgs.GetDeferral()
-->

# Windows.Graphics.Printing.Workflow.PrintWorkflowForegroundSetupRequestedEventArgs.GetDeferral

## -description
Gets a deferral object for managing the work done on the corresponding [PrintWorkflowForegroundSession.SetupRequested](PrintWorkflowforegroundsession_setuprequested.md) event.

## -returns
A deferral object.

## -remarks
A deferral should be used if any asynchronous work is being done in this event handler, so that the next event in the sequence isn't raised until this work is completed.

## -see-also

## -examples

