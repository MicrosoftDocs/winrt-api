---
-api-id: M:Windows.Graphics.Printing.Workflow.PrintWorkflowUILauncher.LaunchAndCompleteUIAsync
-api-type: winrt method
---

# Windows.Graphics.Printing.Workflow.PrintWorkflowUILauncher.LaunchAndCompleteUIAsync

<!--
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Printing.Workflow.PrintWorkflowUICompletionStatus> LaunchAndCompleteUIAsync ();
-->


## -description

Shows the print workflow job UI for gathering user input that the print workflow app needs to complete the conversion to the page description language (PDL) format indicated by the printer. This is an async operation that will be completed only after the UI is closed.

## -returns

An asynchronous operation that, on successful completion, returns a [PrintWorkflowUICompletionStatus](printworkflowuicompletionstatus.md) object that indicates the completion status of the UI.

## -remarks

This method will fail if the [IsUILaunchEnabled](printworkflowuilauncher_isuilaunchenabled_2011926829.md) method returns false.

## -see-also

## -examples


