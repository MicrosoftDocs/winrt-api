---
-api-id: M:Windows.Graphics.Printing.Workflow.PrintWorkflowPdlModificationRequestedEventArgs.CreateJobOnPrinterWithAttributesBuffer(Windows.Storage.Streams.IBuffer,System.String,Windows.Storage.Streams.IBuffer,Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy,Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy)
-api-type: winrt method
---

# Windows.Graphics.Printing.Workflow.PrintWorkflowPdlModificationRequestedEventArgs.CreateJobOnPrinterWithAttributesBuffer(Windows.Storage.Streams.IBuffer,System.String,Windows.Storage.Streams.IBuffer,Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy,Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy)

<!--
public Windows.Graphics.Printing.Workflow.PrintWorkflowPdlTargetStream CreateJobOnPrinterWithAttributesBuffer (Windows.Storage.Streams.IBuffer jobAttributesBuffer, string targetContentType, Windows.Storage.Streams.IBuffer operationAttributesBuffer, Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy jobAttributesMergePolicy, Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy operationAttributesMergePolicy);
-->


## -description

## -parameters

### -param jobAttributesBuffer

A serialized Internet Printing Protocol (IPP) job attribute group, as per the definition in the IPP specification.

### -param targetContentType

The target content type for the job.

### -param operationAttributesBuffer

A serialized Internet Printing Protocol (IPP) operation attribute group, as per the definition in the IPP specification.

### -param jobAttributesMergePolicy

A member of the [PrintWorkflowAttributesMergePolicy](xref:Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy) enumeration specifying how PSA-provided job attributes are merged with PrintTicket attributes.

### -param operationAttributesMergePolicy

A member of the [PrintWorkflowAttributesMergePolicy](xref:Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy) enumeration specifying how PSA-provided operation attributes are merged with PrintTicket attributes.

## -returns

The target stream for the job.

## -remarks

## -see-also

## -examples


