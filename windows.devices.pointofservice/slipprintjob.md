---
-api-id: T:Windows.Devices.PointOfService.SlipPrintJob
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SlipPrintJob : Windows.Devices.PointOfService.IPosPrinterJob, Windows.Devices.PointOfService.IReceiptOrSlipJob
-->

# Windows.Devices.PointOfService.SlipPrintJob

## -description
Represents a set of printing instructions that you want to run on the slip printer station.

## -remarks
To create a new print job for the slip printer, call [ClaimedSlipPrinter.CreateJob](claimedslipprinter_createjob_1417454808.md).
The created print job object is valid as long as the ClaimedSlipPrinter object that created it is valid.

## -examples

## -see-also
[IReceiptOrSlipJob](ireceiptorslipjob.md), [IPosPrinterJob](iposprinterjob.md), [ClaimedSlipPrinter.CreateJob](claimedslipprinter_createjob_1417454808.md)
