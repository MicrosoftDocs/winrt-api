---
-api-id: M:Windows.Graphics.Printing.Workflow.PrintWorkflowPdlModificationRequestedEventArgs.CreateJobOnPrinterWithAttributes(Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,Windows.Devices.Printers.IppAttributeValue}},System.String,Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,Windows.Devices.Printers.IppAttributeValue}},Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy,Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy)
-api-type: winrt method
---

# Windows.Graphics.Printing.Workflow.PrintWorkflowPdlModificationRequestedEventArgs.CreateJobOnPrinterWithAttributes(Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,Windows.Devices.Printers.IppAttributeValue}},System.String,Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,Windows.Devices.Printers.IppAttributeValue}},Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy,Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy)

<!--
public Windows.Graphics.Printing.Workflow.PrintWorkflowPdlTargetStream CreateJobOnPrinterWithAttributes (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,Windows.Devices.Printers.IppAttributeValue>> jobAttributes, string targetContentType, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,Windows.Devices.Printers.IppAttributeValue>> operationAttributes, Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy jobAttributesMergePolicy, Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy operationAttributesMergePolicy);
-->


## -description

## -parameters

### -param jobAttributes

A list of Internet Printing Protocol (IPP) job attributes, as per the definition in the IPP specification.

### -param targetContentType

The target content type for the job.

### -param operationAttributes

A collection operation job attributes.

### -param jobAttributesMergePolicy

A member of the [PrintWorkflowAttributesMergePolicy](xref:Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy) enumeration specifying how PSA-provided job attributes are merged with PrintTicket attributes.

### -param operationAttributesMergePolicy

A member of the [PrintWorkflowAttributesMergePolicy](xref:Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy) enumeration specifying how PSA-provided operation attributes are merged with PrintTicket attributes.

## -returns

The target stream for the job.

## -remarks

## -see-also

## -examples


