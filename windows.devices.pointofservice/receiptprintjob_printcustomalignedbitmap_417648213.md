---
-api-id: M:Windows.Devices.PointOfService.ReceiptPrintJob.PrintCustomAlignedBitmap(Windows.Graphics.Imaging.BitmapFrame,System.UInt32,System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void PrintCustomAlignedBitmap(Windows.Graphics.Imaging.BitmapFrame bitmap, System.UInt32 alignmentDistance, System.UInt32 width)
-->

# Windows.Devices.PointOfService.ReceiptPrintJob.PrintCustomAlignedBitmap

## -description
Adds an instruction to the print job to print the specified bitmap with the specified width and at the specified distance from the leftmost print column on the receipt printer station.

## -parameters
### -param bitmap
Information about the bitmap that you want to print.

### -param alignmentDistance
The distance from the leftmost print column to the start of the bitmap, expressed in the unit of measurement indicated by the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property.

### -param width
The width to use for printing the bitmap, expressed in the unit of measurement indicated by the [ClaimedPosPriinter.MapMode](claimedposprinter_mapmode.md) property.

## -remarks

## -examples

## -see-also
[PrintCustomAlignedBitmap(BitmapFrame, UInt32)](receiptprintjob_printcustomalignedbitmap_386594225.md), [PrintBitmap(BitmapFrame, PosPrinterAlignment)](receiptprintjob_printbitmap_1311643772.md), [PrintBitmap(BitmapFrame, PosPrinterAlignment, UInt32)](receiptprintjob_printbitmap_1103111072.md), [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md)