---
-api-id: P:Windows.Graphics.Printing.Workflow.PrintWorkflowJobStartingEventArgs.IsIppCompressionEnabled
-api-type: winrt property
---

# Windows.Graphics.Printing.Workflow.PrintWorkflowJobStartingEventArgs.IsIppCompressionEnabled

<!--
public bool IsIppCompressionEnabled { get; }
-->


## -description

Gets a value that specifies whether Internet Printing Protocol (IPP) compression is enabled for the current printer job operation.

## -property-value

True if IPP compression is enabled; otherwise, false.

## -remarks

If an app implements its own compression, it can use this property to detect if the system IPP compression is enabled. If IPP compression is enabled, the app can call [DisableIppCompressionForJob](printworkflowjobstartingeventargs_disableippcompressionforjob_1896220985.md) to disable IPP compression.

## -see-also

## -examples


