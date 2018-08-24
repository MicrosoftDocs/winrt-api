---
-api-id: M:Windows.Devices.PointOfService.IReceiptOrSlipJob.PrintBarcode(System.String,System.UInt32,System.UInt32,System.UInt32,Windows.Devices.PointOfService.PosPrinterBarcodeTextPosition,Windows.Devices.PointOfService.PosPrinterAlignment)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void PrintBarcode(System.String data, System.UInt32 symbology, System.UInt32 height, System.UInt32 width, Windows.Devices.PointOfService.PosPrinterBarcodeTextPosition textPosition, Windows.Devices.PointOfService.PosPrinterAlignment alignment)
-->

# Windows.Devices.PointOfService.IReceiptOrSlipJob.PrintBarcode

## -description
Adds an instruction to the print job to print a barcode on the receipt or slip printer station with the specified data and symbology.

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

### -param alignment
The horizontal alignment of the barcode on the page.

## -remarks

## -examples

## -see-also
[ReceiptPrintJob.PrintBarcode](receiptprintjob_printbarcode_1361148756.md), [SlipPrintJob.PrintBarcode](slipprintjob_printbarcode_1361148756.md)