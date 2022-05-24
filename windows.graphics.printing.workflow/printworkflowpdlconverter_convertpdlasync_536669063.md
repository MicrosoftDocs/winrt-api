---
-api-id: M:Windows.Graphics.Printing.Workflow.PrintWorkflowPdlConverter.ConvertPdlAsync(Windows.Graphics.Printing.PrintTicket.WorkflowPrintTicket,Windows.Storage.Streams.IInputStream,Windows.Storage.Streams.IOutputStream,Windows.Graphics.Printing.Workflow.PdlConversionHostBasedProcessingOperations)
-api-type: winrt method
---

# Windows.Graphics.Printing.Workflow.PrintWorkflowPdlConverter.ConvertPdlAsync(Windows.Graphics.Printing.PrintTicket.WorkflowPrintTicket,Windows.Storage.Streams.IInputStream,Windows.Storage.Streams.IOutputStream,Windows.Graphics.Printing.Workflow.PdlConversionHostBasedProcessingOperations)

<!--
public Windows.Foundation.IAsyncAction ConvertPdlAsync (Windows.Graphics.Printing.PrintTicket.WorkflowPrintTicket printTicket, Windows.Storage.Streams.IInputStream inputStream, Windows.Storage.Streams.IOutputStream outputStream, Windows.Graphics.Printing.Workflow.PdlConversionHostBasedProcessingOperations hostBasedProcessingOperations);
-->


## -description


Converts a print document from one page description language (PDL) format to another PDL format, with the ability to specify which conversion operations should be performed by the host.

## -parameters

### -param printTicket

The current XML PrintTicket document containing instructions on how the printer should set its various features for a printing task.

### -param inputStream

The print document that needs to be converted from the original PDL format.

### -param outputStream

The converted print document in the translated PDL format.

### -param hostBasedProcessingOperations

A combination of flags from the [PdlConversionHostBasedProcessingOperations](xref:Windows.Graphics.Printing.Workflow.PdlConversionHostBasedProcessingOperations) enumeration, specifying the operations that should be performed by the host.

## -returns

An object that is used to control the asynchronous operation.

## -remarks

## -see-also

[PdlModificationRequested](printworkflowjobbackgroundsession_pdlmodificationrequested.md), [GetPdlConverter](printworkflowpdlmodificationrequestedeventargs_getpdlconverter_762504533.md)

## -examples


