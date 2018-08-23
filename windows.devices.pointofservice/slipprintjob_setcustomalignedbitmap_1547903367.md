---
-api-id: M:Windows.Devices.PointOfService.SlipPrintJob.SetCustomAlignedBitmap(System.UInt32,Windows.Graphics.Imaging.BitmapFrame,System.UInt32,System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetCustomAlignedBitmap(System.UInt32 bitmapNumber, Windows.Graphics.Imaging.BitmapFrame bitmap, System.UInt32 alignmentDistance, System.UInt32 width)
-->

# Windows.Devices.PointOfService.SlipPrintJob.SetCustomAlignedBitmap

## -description
Saves information about a bitmap, along with the width and the distance from the leftmost print column that you want to use to print that bitmap on the slip printer station, so that you can use the [PrintSavedBitmap](slipprintjob_printsavedbitmap_1902948304.md) method to add that information to the print job later.

## -parameters
### -param bitmapNumber
The number that you want to assign to this bitmap. You can set two bitmaps, numbered 1 and 2. Use this number with the [PrintSavedBitmap](slipprintjob_printsavedbitmap_1902948304.md) method later to add the print instructions to the print job.

### -param bitmap
Information about the bitmap that you want to print.

### -param alignmentDistance
The distance from the leftmost print column to the start of the bitmap, expressed in the unit of measurement indicated by the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property.

### -param width
The width to use for printing the bitmap, expressed in the unit of measurement indicated by the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property.

## -remarks

## -examples

## -see-also
[SetBitmap(UInt32, BitmapFrame, PosPrinterAlignment)](slipprintjob_setbitmap_489195165.md), [SetBitmap(UInt32, BitmapFrame, PosPrinterAlignment, UInt32)](slipprintjob_setbitmap_49606997.md), [SetCustomAlignedBitmap(UInt32, BitmapFrame, UInt32)](slipprintjob_setcustomalignedbitmap_1134515791.md), [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md), [PrintSavedBitmap](slipprintjob_printsavedbitmap_1902948304.md)