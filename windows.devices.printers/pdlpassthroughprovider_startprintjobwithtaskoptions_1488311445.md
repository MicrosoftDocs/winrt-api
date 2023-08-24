---
-api-id: M:Windows.Devices.Printers.PdlPassthroughProvider.StartPrintJobWithTaskOptions(System.String,System.String,Windows.Graphics.Printing.PrintTaskOptions,Windows.Devices.Printers.PageConfigurationSettings)
-api-type: winrt method
---

# Windows.Devices.Printers.PdlPassthroughProvider.StartPrintJobWithTaskOptions(System.String,System.String,Windows.Graphics.Printing.PrintTaskOptions,Windows.Devices.Printers.PageConfigurationSettings)

<!--
public Windows.Devices.Printers.PdlPassthroughTarget StartPrintJobWithTaskOptions (string jobName, string pdlContentType, Windows.Graphics.Printing.PrintTaskOptions taskOptions, Windows.Devices.Printers.PageConfigurationSettings pageConfigurationSettings);
-->


## -description

Starts a PDL pass-through print job with Print Task options.

## -parameters

### -param jobName

The job name.

### -param pdlContentType

Represents the PDL format for the print job.

### -param taskOptions

Print Task options containing options for the print job.

### -param pageConfigurationSettings

Specifies where page configuration (size and orientation) need to be read from&mdash;either the Print Task options or the PDL content. If *pageConfigurationSettings* is null, then all fields will be read from the Print Task options.

## -returns

## -remarks

## -see-also

## -examples
