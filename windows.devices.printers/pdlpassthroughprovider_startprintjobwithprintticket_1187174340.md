---
-api-id: M:Windows.Devices.Printers.PdlPassthroughProvider.StartPrintJobWithPrintTicket(System.String,System.String,Windows.Storage.Streams.IInputStream,Windows.Devices.Printers.PageConfigurationSettings)
-api-type: winrt method
---

# Windows.Devices.Printers.PdlPassthroughProvider.StartPrintJobWithPrintTicket(System.String,System.String,Windows.Storage.Streams.IInputStream,Windows.Devices.Printers.PageConfigurationSettings)

<!--
public Windows.Devices.Printers.PdlPassthroughTarget StartPrintJobWithPrintTicket (string jobName, string pdlContentType, Windows.Storage.Streams.IInputStream printTicket, Windows.Devices.Printers.PageConfigurationSettings pageConfigurationSettings);
-->


## -description

Starts a PDL pass-through print job with a print ticket.

## -parameters

### -param jobName

The job name.

### -param pdlContentType

Represents the PDL format for the print job.

### -param printTicket

A print ticket stream containing options for the print job.

### -param pageConfigurationSettings

Specifies where page configuration (size and orientation) need to be read from&mdash;either the Print Ticket or the PDL content. If *pageConfigurationSettings* is null, then all fields will be read from the Print Ticket.

## -returns

## -remarks

## -see-also

## -examples
