---
-api-id: M:Windows.Devices.PointOfService.IReceiptOrSlipJob.SetBitmap(System.UInt32,Windows.Graphics.Imaging.BitmapFrame,Windows.Devices.PointOfService.PosPrinterAlignment)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetBitmap(System.UInt32 bitmapNumber, Windows.Graphics.Imaging.BitmapFrame bitmap, Windows.Devices.PointOfService.PosPrinterAlignment alignment)
-->

# Windows.Devices.PointOfService.IReceiptOrSlipJob.SetBitmap

## -description
Saves information about a bitmap and a standard horizontal placement that you want to use to print that bitmap on the receipt or slip printer station, so that you can use the [PrintSavedBitmap](ireceiptorslipjob_printsavedbitmap.md) method to add that information to the print job later.

## -parameters
### -param bitmapNumber
The number that you want to assign to this bitmap. You can set two bitmaps, numbered 1 and 2. Use this number with the [PrintSavedBitmap](ireceiptorslipjob_printsavedbitmap.md) method later to add the print instructions to the print job.

### -param bitmap
Information about the bitmap that you want to print.

### -param alignment
An enumeration value that specifies a standard horizontal placement on the page for the bitmap, such as left-aligned, centered, or right-aligned.

## -remarks
If the printer for the print job has non-volatile bitmap storage, this method saves the bitmap to the printer hardware, which can cause wear and damage to the flash storage for the printer.

## -examples

## -see-also
[SetBitmap(UInt32, BitmapFrame, PosPrinterAlignment, UInt32)](ireceiptorslipjob_setbitmap_49606997.md), [SetCustomAlignedBitmap(UInt32, BitmapFrame, UInt32)](ireceiptorslipjob_setcustomalignedbitmap_1134515791.md), [SetCustomAlignedBitmap(UInt32, BitmapFrame, UInt32, UInt32)](ireceiptorslipjob_setcustomalignedbitmap_1547903367.md), [PosPrinterAlignment](posprinteralignment.md), [PrintSavedBitmap](ireceiptorslipjob_printsavedbitmap.md)