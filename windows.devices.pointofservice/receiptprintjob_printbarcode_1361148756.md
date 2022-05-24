---
-api-id: M:Windows.Devices.PointOfService.ReceiptPrintJob.PrintBarcode(System.String,System.UInt32,System.UInt32,System.UInt32,Windows.Devices.PointOfService.PosPrinterBarcodeTextPosition,Windows.Devices.PointOfService.PosPrinterAlignment)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void PrintBarcode(System.String data, System.UInt32 symbology, System.UInt32 height, System.UInt32 width, Windows.Devices.PointOfService.PosPrinterBarcodeTextPosition textPosition, Windows.Devices.PointOfService.PosPrinterAlignment alignment)
-->

# Windows.Devices.PointOfService.ReceiptPrintJob.PrintBarcode

## -description
Adds an instruction to the print job to print a barcode with the specified data and symbology on the receipt printer station.

## -parameters
### -param data
The data to be represented as a barcode.

### -param symbology
The symbology (encoding) of the barcode. This can be determined based on the [BarcodeSymbologies](barcodesymbologies.md) class static methods.

### -param height
The height of the barcode, expressed in the unit of measurement indicated by the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property.

### -param width
The width of the barcode.

This value is interpreted in one of two ways:

The width of the entire barcode, expressed in the unit of measurement indicated by the [ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md) property.


or, (though we discourage using this method) if the value is less than or equal to 6, it is interprested as described below:

ESC/POS control language is used for most Windows POS device communication, and ESC/POS only accepts integers from 2 to 6. Each value contains a matched measurement for the thin and thick elements of a barcode. In order for a barcode to be read properly, the width of the lines is crucial, especially when scaling. Additionally, the minimum width capability varies by printer model.

Actual sizes are dependent on the capabilities of the target printer, but approximate sizes for accepted values are:<table>
   <tr><th>Width Value</th><th>Thin Element</th><th>Thick Element</th></tr>
   <tr><td>2</td><td>0.250 - 0.282 mm</td><td>0.625 - 0.706 mm</td></tr>
   <tr><td>3</td><td>0.375 - 0.423 mm</td><td>1.000 - 1.129 mm</td></tr>
   <tr><td>4</td><td>0.500 - 0.564 mm</td><td>1.250 - 1.411 mm</td></tr>
   <tr><td>5</td><td>0.625 - 0.706 mm</td><td>1.625 - 1.834 mm</td></tr>
   <tr><td>6</td><td>0.750 - 0.847 mm</td><td>2.000 - 2.258 mm</td></tr>
</table>

See the remarks in [POS Printer](posprinter.md) for more information on ESC/POS.

### -param textPosition
The vertical position of the barcode text relative to the barcode.

### -param alignment
The horizontal alignment of the barcode on the page.

## -remarks

## -examples

## -see-also
[ClaimedPosPrinter.MapMode](claimedposprinter_mapmode.md)
