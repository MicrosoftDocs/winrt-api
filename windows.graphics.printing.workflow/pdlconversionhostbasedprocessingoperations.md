---
-api-id: T:Windows.Graphics.Printing.Workflow.PdlConversionHostBasedProcessingOperations
-api-type: winrt enum
---

# Windows.Graphics.Printing.Workflow.PdlConversionHostBasedProcessingOperations

<!--
public enum PdlConversionHostBasedProcessingOperations
-->


## -description

Specifies which PDL conversion processing operations are performed by the host.

## -enum-fields

### -field All: 4294967295

All operations are performed by the host.

### -field None: 0

No operations are performed by the host..

### -field PageRotation: 1

Page rotation is performed by the host.

### -field PageOrdering: 2

Page rotation is performed by the host.

### -field Copies: 4

Document copies are performed by the host.

### -field BlankPageInsertion: 8

Blank page insertion is performed by the host.

## -remarks

This enumeration is used by an overload of the [ConvertPdlAsync](xref:Windows.Graphics.Printing.Workflow.PrintWorkflowPdlConverter.ConvertPdlAsync(Windows.Graphics.Printing.PrintTicket.WorkflowPrintTicket,Windows.Storage.Streams.IInputStream,Windows.Storage.Streams.IOutputStream,Windows.Graphics.Printing.Workflow.PdlConversionHostBasedProcessingOperations)) method.

## -see-also

## -examples


