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
Adds an instruction to the print job to print a bitmap on the receipt printer station by using the bitmap and information saved to the printer via [SetBitmap](/uwp/api/windows.devices.pointofservice.receiptprintjob.setbitmap) or [SetCustomAlignedBitmap](/uwp/api/windows.devices.pointofservice.receiptprintjob.setcustomalignedbitmap).

## -parameters
### -param bitmapNumber
The number that you assigned to the bitmap that you want to print when you called [SetBitmap](/uwp/api/windows.devices.pointofservice.receiptprintjob.setbitmap) or [SetCustomAlignedBitmap](/uwp/api/windows.devices.pointofservice.receiptprintjob.setcustomalignedbitmap).

## -remarks
The bitmap rotation setting that you specify by calling [ReceiptPrintJob.SetPrintRotation](receiptprintjob_setprintrotation_513865495.md) may not apply to bitmaps that you saved to the printer.

## -examples

## -see-also
[SetBitmap](/uwp/api/windows.devices.pointofservice.receiptprintjob.setbitmap), [SetCustomAlignedBitmap](/uwp/api/windows.devices.pointofservice.receiptprintjob.setcustomalignedbitmap), [ReceiptPrintJob.SetPrintRotation](receiptprintjob_setprintrotation_513865495.md)