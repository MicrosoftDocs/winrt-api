---
-api-id: M:Windows.Devices.PointOfService.ReceiptPrintJob.PrintSavedBitmap(System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void PrintSavedBitmap(System.UInt32 bitmapNumber)
-->

# Windows.Devices.PointOfService.ReceiptPrintJob.PrintSavedBitmap

## -description
Adds an instruction to the print job to print a bitmap on the receipt printer station by using the bitmap and information saved to the printer via [SetBitmap](receiptprintjob_setbitmap.md) or [SetCustomAlignedBitmap](receiptprintjob_setcustomalignedbitmap.md).

## -parameters
### -param bitmapNumber
The number that you assigned to the bitmap that you want to print when you called [SetBitmap](receiptprintjob_setbitmap.md) or [SetCustomAlignedBitmap](receiptprintjob_setcustomalignedbitmap.md).

## -remarks
The bitmap rotation setting that you specify by calling [ReceiptPrintJob.SetPrintRotation](receiptprintjob_setprintrotation.md) may not apply to bitmaps that you saved to the printer.

## -examples

## -see-also
[SetBitmap](receiptprintjob_setbitmap.md), [SetCustomAlignedBitmap](receiptprintjob_setcustomalignedbitmap.md), [ReceiptPrintJob.SetPrintRotation](receiptprintjob_setprintrotation.md)