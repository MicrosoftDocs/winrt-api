---
-api-id: M:Windows.Devices.PointOfService.IReceiptOrSlipJob.PrintSavedBitmap(System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void PrintSavedBitmap(System.UInt32 bitmapNumber)
-->

# Windows.Devices.PointOfService.IReceiptOrSlipJob.PrintSavedBitmap

## -description
Adds an instruction to the print job to print a bitmap on the receipt or slip printer station by using the information that you saved about the bitmap and how to print it when you called the [SetBitmap](ireceiptorslipjob_setbitmap.md) or [SetCustomAlignedBitmap](ireceiptorslipjob_setcustomalignedbitmap.md) method.

## -parameters
### -param bitmapNumber
The number that you assigned to the bitmap that you want to print when you called [SetBitmap](ireceiptorslipjob_setbitmap.md) or [SetCustomAlignedBitmap](ireceiptorslipjob_setcustomalignedbitmap.md).

## -remarks
The bitmap rotation setting that you specify by calling [IReceiptOrSlipJob.SetPrintRotation](ireceiptorslipjob_setprintrotation.md) may not apply to bitmaps that you saved to the printer.

## -examples

## -see-also
[SetBitmap](ireceiptorslipjob_setbitmap.md), [SetCustomAlignedBitmap](ireceiptorslipjob_setcustomalignedbitmap.md), [IReceiptOrSlipJob.SetPrintRotation](ireceiptorslipjob_setprintrotation.md)