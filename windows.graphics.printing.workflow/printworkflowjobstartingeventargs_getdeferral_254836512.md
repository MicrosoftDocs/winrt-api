---
-api-id: M:Windows.Graphics.Printing.Workflow.PrintWorkflowJobStartingEventArgs.GetDeferral
-api-type: winrt method
---

# Windows.Graphics.Printing.Workflow.PrintWorkflowJobStartingEventArgs.GetDeferral

<!--
public Windows.Foundation.Deferral GetDeferral ();
-->


## -description

Requests that the print job operation be delayed and gets a deferral object that will be invoked upon completion of the deferred action.

## -returns

The deferral object.

## -remarks

The print job operation is delayed until the app calls the [Deferral.Complete](/uwp/api/windows.foundation.deferral.complete) method.

## -see-also

## -examples


