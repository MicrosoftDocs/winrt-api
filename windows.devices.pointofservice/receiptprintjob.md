---
-api-id: T:Windows.Devices.PointOfService.ReceiptPrintJob
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ReceiptPrintJob : Windows.Devices.PointOfService.IPosPrinterJob, Windows.Devices.PointOfService.IReceiptOrSlipJob, Windows.Devices.PointOfService.IReceiptPrintJob
-->

# Windows.Devices.PointOfService.ReceiptPrintJob

## -description
Represents a set of printing instructions that you want to run on the receipt printer.

## -remarks
To create a new print job for the receipt printer, call [ClaimedReceiptPrinter.CreateJob](claimedreceiptprinter_createjob.md).
The created print job object is valid as long as the ClaimedReceiptPrinter object that created it is valid.

## -examples

## -see-also
[IReceiptOrSlipJob](ireceiptorslipjob.md), [IPosPrinterJob](iposprinterjob.md), [ClaimedReceiptPrinter.CreateJob](claimedreceiptprinter_createjob.md)
