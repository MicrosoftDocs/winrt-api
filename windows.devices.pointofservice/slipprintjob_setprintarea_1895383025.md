---
-api-id: M:Windows.Devices.PointOfService.SlipPrintJob.SetPrintArea(Windows.Foundation.Rect)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetPrintArea(Windows.Foundation.Rect value)
-->

# Windows.Devices.PointOfService.SlipPrintJob.SetPrintArea

## -description
Sets the area of the page on which the slip printer station can print the job.

## -parameters
### -param value
The area of the page on which the slip printer station can print the job.

## -remarks
When you call this method for a print job, all instructions in the print job run within the specified print area, including the instructions that you added to the job before you called SlipPrintJob.SetPrintArea.

## -examples

## -see-also
[IReceiptOrSlipJob.SetPrintArea](ireceiptorslipjob_setprintarea_1895383025.md), [ClaimedSlipPrinter.PrintArea](claimedslipprinter_printarea.md), [SlipPrinterCapabilities.IsPrintAreaSupported](slipprintercapabilities_isprintareasupported.md)
