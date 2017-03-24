---
-api-id: M:Windows.Devices.PointOfService.SlipPrintJob.PrintBitmap(Windows.Graphics.Imaging.BitmapFrame,Windows.Devices.PointOfService.PosPrinterAlignment,System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void PrintBitmap(Windows.Graphics.Imaging.BitmapFrame bitmap, Windows.Devices.PointOfService.PosPrinterAlignment alignment, System.UInt32 width)
-->

# Windows.Devices.PointOfService.SlipPrintJob.PrintBitmap

## -description
Adds an instruction to the print job to print the specified bitmap with the specified width and a standard horizontal placement on the slip printer station.

## -parameters
### -param bitmap
Information about the bitmap that you want to print.

### -param alignment
An enumeration value that specifies a standard horizontal placement on the page for the bitmap, such as left-aligned, centered, or right-aligned.

### -param width
The width to use for printing the bitmap, expressed in the unit of measurement indicated by the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property.

## -remarks

## -examples

## -see-also
[PrintBitmap(BitmapFrame, PosPrinterAlignment)](slipprintjob_printbitmap_1311643772.md), [PrintCustomAlignedBitmap(BitmapFrame, UInt32)](slipprintjob_printcustomalignedbitmap_386594225.md), [PrintCustomAlignedBitmap(BitmapFrame, UInt32, UInt32)](slipprintjob_printcustomalignedbitmap_417648213.md), [PosPrinterAlignment](posprinteralignment.md), [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md)