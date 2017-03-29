---
-api-id: M:Windows.Devices.PointOfService.ReceiptPrintJob.SetPrintRotation(Windows.Devices.PointOfService.PosPrinterRotation,System.Boolean)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetPrintRotation(Windows.Devices.PointOfService.PosPrinterRotation value, System.Boolean includeBitmaps)
-->

# Windows.Devices.PointOfService.ReceiptPrintJob.SetPrintRotation

## -description
Sets the rotation of the text or image on the page for the receipt printer station.

## -parameters
### -param value
The rotation of the text or image on the page for the receipt printer station.

### -param includeBitmaps
Whether bitmaps should also be rotated. This setting takes effect only for subsequent calls to [PrintBitmap](receiptprintjob_printbitmap.md), and may not apply to saved bitmaps that you print using [PrintSavedBitmap](receiptprintjob_printsavedbitmap.md).

## -remarks
This rotation setting persists beyond the current print job.

## -examples

## -see-also
