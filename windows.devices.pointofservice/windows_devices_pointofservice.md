---
-api-id: N:Windows.Devices.PointOfService
-api-type: winrt namespace
---

# Windows.Devices.PointOfService

## -description
Enables application developers to access Point of Service (POS) peripheral devices. The namespace provides a vendor-neutral interface for accessing POS devices from various manufacturers from the Windows Store app.

<hr>

[**BarcodeScanner**](barcodescanner.md) enables application developers to access barcode scanners to retrieve decoded data from a variety of barcode symbologies such as UPC and QR Codes depending on support from the hardware.

[**CashDrawer**](cashdrawer.md) enables application developers to interact with cash drawers.

[**LineDisplay**](linedisplay.md) enables application developers to control customer facing 2x20 line displays.

[**MagneticStripeReader**](magneticstripereader.md) enables application developers to access magnetic stripe readers to retrieve data from magnetic stripe enabled cards such as credit/debit cards, loyalty cards, access cards, etc.

[**POSPrinter**](posprinter.md) enables application developers to print to network and Bluetooth connected receipt printers using the Epson ESC/POS printer control language.

<hr>

<table>
   <tr><th>Common Members</th><th>Description</th></tr>
   <tr><td>[UnifiedPosErrorData](unifiedposerrordata.md) class</td><td>Provides error information.</td></tr>
   <tr><td>[UnifiedPosErrorReason](unifiedposerrorreason.md) enumeration</td><td>Defines the constants that indicates the reason for the error event.</td></tr>
   <tr><td>[UnifiedPosErrorSeverity](unifiedposerrorseverity.md) enumeration</td><td>Defines the constants that indicates the error severity.</td></tr>
   <tr><td>[UnifiedPosHealthCheckLevel](unifiedposhealthchecklevel.md) enumeration</td><td>Defines the constants that indicates the type of health check that can be performed on the devices.</td></tr>
   <tr><td>[UnifiedPosPowerReportingType](unifiedpospowerreportingtype.md) enumeration</td><td>Defines the constants that indicates power reporting capabilities of the Point of Service (POS) device.</td></tr>
</table>

## -remarks
Applications which require this namespace require the addition of the “pointOfService” [DeviceCapability](https://msdn.microsoft.com/en-us/library/windows/apps/4353c4fd-f038-4986-81ed-d2ec0c6235ef) to the app package manifest.

## -examples

## -see-also
[Cash drawer sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620015), [Magnetic stripe reader sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620017), [POS printer sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620018), [Barcode scanner sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620014)
