---
-api-id: M:Windows.Devices.PointOfService.SlipPrintJob.PrintBarcodeCustomAlign(System.String,System.UInt32,System.UInt32,System.UInt32,Windows.Devices.PointOfService.PosPrinterBarcodeTextPosition,System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void PrintBarcodeCustomAlign(System.String data, System.UInt32 symbology, System.UInt32 height, System.UInt32 width, Windows.Devices.PointOfService.PosPrinterBarcodeTextPosition textPosition, System.UInt32 alignmentDistance)
-->

# Windows.Devices.PointOfService.SlipPrintJob.PrintBarcodeCustomAlign

## -description
Adds an instruction to the print job to print a barcode on the slip printer station with the specified data, symbology, and custom alignment.

## -parameters
### -param data
The data to represent as a barcode.

### -param symbology
The symbology (encoding) of the barcode.

### -param height
The height of the barcode, in pixels.

### -param width
The width of the barcode, in pixels.

### -param textPosition
The vertical position of the barcode text relative to the barcode.

### -param alignmentDistance
The distance from the leftmost print column to the start of the barcode, expressed in the unit of measurement indicated by the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property.

## -remarks

## -examples

## -see-also
[IReceiptOrSlipJob.PrintBarcodeCustomAlign](ireceiptorslipjob_printbarcodecustomalign.md)