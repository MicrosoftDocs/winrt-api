---
-api-id: M:Windows.Devices.PointOfService.ReceiptPrintJob.SetPrintArea(Windows.Foundation.Rect)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetPrintArea(Windows.Foundation.Rect value)
-->

# Windows.Devices.PointOfService.ReceiptPrintJob.SetPrintArea

## -description
Sets the area of the page on which the receipt printer station can print the job.

## -parameters
### -param value
The area of the page on which the receipt printer can print the job.

## -remarks
When you call this method for a print job, all instructions in the print job run within the specified print area, including the instructions that you added to the job before you called [ReceiptPrintJob.SetPrintArea](receiptprintjob_setprintarea.md).

## -examples

## -see-also
[IReceiptOrSlipJob.SetPrintArea](ireceiptorslipjob_setprintarea.md), [ClaimedReceiptPrinter.PrintArea](claimedreceiptprinter_printarea.md), [ReceiptPrinterCapabilities.IsPrintAreaSupported](receiptprintercapabilities_isprintareasupported.md)