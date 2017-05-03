---
-api-id: M:Windows.Devices.PointOfService.IReceiptOrSlipJob.SetCustomAlignedBitmap(System.UInt32,Windows.Graphics.Imaging.BitmapFrame,System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetCustomAlignedBitmap(System.UInt32 bitmapNumber, Windows.Graphics.Imaging.BitmapFrame bitmap, System.UInt32 alignmentDistance)
-->

# Windows.Devices.PointOfService.IReceiptOrSlipJob.SetCustomAlignedBitmap

## -description
Saves information about a bitmap and the distance from the leftmost print column at which you want to print that bitmap on the receipt or slip printer station, so that you can use the [PrintSavedBitmap](ireceiptorslipjob_printsavedbitmap.md) method to add that information to the print job later.

## -parameters
### -param bitmapNumber
The number that you want to assign to this bitmap. You can set two bitmaps, numbered 1 and 2. Use this number with the [PrintSavedBitmap](ireceiptorslipjob_printsavedbitmap.md) method later to add the print instructions to the print job.

### -param bitmap
Information about the bitmap that you want to print.

### -param alignmentDistance
The distance from the leftmost print column to the start of the bitmap, expressed in the unit of measurement indicated by the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property.

## -remarks

## -examples

## -see-also
[SetCustomAlignedBitmap(UInt32, BitmapFrame, UInt32, UInt32)](ireceiptorslipjob_setcustomalignedbitmap_1547903367.md), [SetBitmap(UInt32, BitmapFrame, PosPrinterAlignment)](ireceiptorslipjob_setbitmap_489195165.md), [SetBitmap(UInt32, BitmapFrame, PosPrinterAlignment, UInt32)](ireceiptorslipjob_setbitmap_49606997.md), [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md), [PrintSavedBitmap](ireceiptorslipjob_printsavedbitmap.md)