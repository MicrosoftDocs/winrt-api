---
-api-id: M:Windows.Devices.PointOfService.IReceiptOrSlipJob.SetPrintArea(Windows.Foundation.Rect)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetPrintArea(Windows.Foundation.Rect value)
-->

# Windows.Devices.PointOfService.IReceiptOrSlipJob.SetPrintArea

## -description
Sets the area of the page on which the receipt or slip printer station can print the job.

## -parameters
### -param value
The area of the page on which the receipt or slip printer station can print the job.

## -remarks
When you call this method for a print job, all instructions in the print job run within the specified print area, including the instructions that you added to the job before you called IReceiptOrSlipJob.SetPrintArea.

## -examples

## -see-also
[ClaimedReceiptPrinter.PrintArea](claimedreceiptprinter_printarea.md), [ClaimedSlipPrinter.PrintArea](claimedslipprinter_printarea.md), [ICommonReceiptSlipCapabilities.IsPrintAreaSupported](icommonreceiptslipcapabilities_isprintareasupported.md)
