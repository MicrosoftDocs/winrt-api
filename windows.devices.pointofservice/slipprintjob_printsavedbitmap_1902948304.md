---
-api-id: M:Windows.Devices.PointOfService.SlipPrintJob.PrintSavedBitmap(System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void PrintSavedBitmap(System.UInt32 bitmapNumber)
-->

# Windows.Devices.PointOfService.SlipPrintJob.PrintSavedBitmap

## -description
Adds an instruction to the print job to print a bitmap on the slip printer station by using the information that you saved about the bitmap and how to print it when you called the [SetBitmap](slipprintjob_setbitmap.md) or [SetCustomAlignedBitmap](slipprintjob_setcustomalignedbitmap.md) method.

## -parameters
### -param bitmapNumber
The number that you assigned to the bitmap that you want to print when you called [SetBitmap](slipprintjob_setbitmap.md) or [SetCustomAlignedBitmap](slipprintjob_setcustomalignedbitmap.md).

## -remarks
The bitmap rotation setting that you specify by calling [SlipPrintJob.SetPrintRotation](slipprintjob_setprintrotation.md) may not apply to bitmaps that you saved to the printer.

## -examples

## -see-also
[SetBitmap](slipprintjob_setbitmap.md), [SetCustomAlignedBitmap](slipprintjob_setcustomalignedbitmap.md), [SlipPrintJob.SetPrintRotation](slipprintjob_setprintrotation.md)