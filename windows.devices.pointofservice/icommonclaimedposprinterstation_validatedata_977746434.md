---
-api-id: M:Windows.Devices.PointOfService.ICommonClaimedPosPrinterStation.ValidateData(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public bool ValidateData(System.String data)
-->

# Windows.Devices.PointOfService.ICommonClaimedPosPrinterStation.ValidateData

## -description
Determines whether a data sequence, possibly including one or more escape sequences, is valid for the printer station, before you use that data sequence when you call the [IPosPrinterJob.Print](iposprinterjob_print_1512698335.md) and [IPosPrinterJob.ExecuteAsync](iposprinterjob_executeasync_2108924004.md) methods.

## -parameters
### -param data
The data sequence that you want to validate before you use it with the [IPosPrinterJob.Print](iposprinterjob_print_1512698335.md) method. This sequence may include printable data and escape sequences.

If the sequence is not valid, and you use it with [IPosPrinterJob.Print](iposprinterjob_print_1512698335.md) anyways, the job fails when you run it with [IPosPrinterJob.ExecuteAsync](iposprinterjob_executeasync_2108924004.md). You cannot remove a print instruction that uses an invalid data sequence after you add the instruction to the job with [IPosPrinterJob.Print](iposprinterjob_print_1512698335.md).

## -returns
True if the data passes validation; otherwise false.

## -remarks

## -examples

## -see-also
[IPosPrinterJob.Print](iposprinterjob_print_1512698335.md), [IPosPrinterJob.ExecuteAsync](iposprinterjob_executeasync_2108924004.md), [ClaimedJournalPrinter.ValidateData](claimedjournalprinter_validatedata_977746434.md), [ClaimedReceiptPrinter.ValidateData](claimedreceiptprinter_validatedata_977746434.md), [ClaimedSlipPrinter.ValidateData](claimedslipprinter_validatedata_977746434.md)