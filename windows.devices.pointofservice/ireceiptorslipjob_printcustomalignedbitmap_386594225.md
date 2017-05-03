---
-api-id: M:Windows.Devices.PointOfService.IReceiptOrSlipJob.PrintCustomAlignedBitmap(Windows.Graphics.Imaging.BitmapFrame,System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void PrintCustomAlignedBitmap(Windows.Graphics.Imaging.BitmapFrame bitmap, System.UInt32 alignmentDistance)
-->

# Windows.Devices.PointOfService.IReceiptOrSlipJob.PrintCustomAlignedBitmap

## -description
Adds an instruction to the print job to print the specified bitmap at the specified distance from the leftmost print column on the receipt or slip printer station.

## -parameters
### -param bitmap
Information about the bitmap that you want to print.

### -param alignmentDistance
The distance from the leftmost print column to the start of the bitmap, expressed in the unit of measurement indicated by the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property.

## -remarks

## -examples

## -see-also
[IReceiptOrSlipJob.PrintCustomAlignedBitmap(BitmapFrame, UInt32, UInt32)](ireceiptorslipjob_printcustomalignedbitmap_417648213.md), [ReceiptPrintJob.PrintCustomAlignedBitmap(BitmapFrame, UInt32)](receiptprintjob_printcustomalignedbitmap_386594225.md), [SlipPrintJob.PrintCustomAlignedBitmap(BitmapFrame, UInt32)](slipprintjob_printcustomalignedbitmap_386594225.md), [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md)