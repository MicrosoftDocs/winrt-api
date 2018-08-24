---
-api-id: M:Windows.Devices.PointOfService.IReceiptOrSlipJob.SetPrintRotation(Windows.Devices.PointOfService.PosPrinterRotation,System.Boolean)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetPrintRotation(Windows.Devices.PointOfService.PosPrinterRotation value, System.Boolean includeBitmaps)
-->

# Windows.Devices.PointOfService.IReceiptOrSlipJob.SetPrintRotation

## -description
Sets the rotation of the text or image on the page for the receipt or slip printer station.

## -parameters
### -param value
The rotation of the text or image on the page.

### -param includeBitmaps
Whether bitmaps should be rotated as well. This setting takes effect only for subsequent calls to [PrintBitmap](/uwp/api/windows.devices.pointofservice.ireceiptorslipjob.printbitmap), and may not apply to saved bitmaps that you print using [PrintSavedBitmap](ireceiptorslipjob_printsavedbitmap_1902948304.md).

## -remarks
This rotation setting persists beyond the current print job.

## -examples

## -see-also
