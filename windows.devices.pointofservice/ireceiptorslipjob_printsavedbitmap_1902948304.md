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
Adds an instruction to the print job to print a bitmap on the receipt or slip printer station by using the information that you saved about the bitmap and how to print it when you called the [SetBitmap](/uwp/api/windows.devices.pointofservice.ireceiptorslipjob.setbitmap) or [SetCustomAlignedBitmap](/uwp/api/windows.devices.pointofservice.ireceiptorslipjob.setcustomalignedbitmap) method.

## -parameters
### -param bitmapNumber
The number that you assigned to the bitmap that you want to print when you called [SetBitmap](/uwp/api/windows.devices.pointofservice.ireceiptorslipjob.setbitmap) or [SetCustomAlignedBitmap](/uwp/api/windows.devices.pointofservice.ireceiptorslipjob.setcustomalignedbitmap).

## -remarks
The bitmap rotation setting that you specify by calling [IReceiptOrSlipJob.SetPrintRotation](ireceiptorslipjob_setprintrotation_513865495.md) may not apply to bitmaps that you saved to the printer.

## -examples

## -see-also
[SetBitmap](/uwp/api/windows.devices.pointofservice.ireceiptorslipjob.setbitmap), [SetCustomAlignedBitmap](/uwp/api/windows.devices.pointofservice.ireceiptorslipjob.setcustomalignedbitmap), [IReceiptOrSlipJob.SetPrintRotation](ireceiptorslipjob_setprintrotation_513865495.md)