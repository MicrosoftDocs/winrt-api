---
-api-id: M:Windows.Devices.PointOfService.ClaimedSlipPrinter.ValidateData(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public bool ValidateData(System.String data)
-->

# Windows.Devices.PointOfService.ClaimedSlipPrinter.ValidateData

## -description
Determines whether a data sequence, possibly including one or more escape sequences, is valid for the slip printer station, before you use that data sequence when you call the [SlipPrintJob.Print](slipprintjob_print.md) and [SlipPrintJob.ExecuteAsync](slipprintjob_executeasync.md) methods.

## -parameters
### -param data
The data sequence that you want to validate before you use it with the [SlipPrintJob.Print](slipprintjob_print.md) method. This sequence may include printable data and escape sequences.

If the sequence is not valid, and you use it with [SlipPrintJob.Print](slipprintjob_print.md) anyways, the job fails when you run it with [SlipPrintJob.ExecuteAsync](slipprintjob_executeasync.md). You cannot remove a print instruction that uses an invalid data sequence after you add the instruction to the job with [SlipPrintJob.Print](slipprintjob_print.md).

## -returns
True if the data passes validation; otherwise false.

## -remarks

## -examples

## -see-also
[ICommonClaimedPosPrinterStation.ValidateData](icommonclaimedposprinterstation_validatedata.md), [SlipPrintJob.Print](slipprintjob_print.md), [SlipPrintJob.ExecuteAsync](slipprintjob_executeasync.md)