---
-api-id: N:Windows.Devices.PointOfService
-api-type: winrt namespace
---

# Windows.Devices.PointOfService

## -description

Enables application developers to access Point of Service (POS) peripheral devices. The namespace provides a vendor-neutral interface for accessing POS devices from various manufacturers from the UWP app.

Also see the [UnifiedPOS](https://www.omg.org/retail/unified-pos.htm) architectural specification.

|Important classes|Description|
|-|-|
|[BarcodeScanner](barcodescanner.md)|Enables application developers to access barcode scanners to retrieve decoded data from a variety of barcode symbologies such as UPC and QR Codes depending on support from the hardware.|
|[CashDrawer](cashdrawer.md)|Enables application developers to interact with cash drawers.|
|[LineDisplay](linedisplay.md)|Enables application developers to control customer facing 2x20 line displays.|
|[MagneticStripeReader](magneticstripereader.md)|Enables application developers to access magnetic stripe readers to retrieve data from magnetic stripe enabled cards such as credit/debit cards, loyalty cards, access cards, etc.|
|[POSPrinter](posprinter.md)|Enables application developers to print to network and Bluetooth connected receipt printers using the Epson ESC/POS printer control language.|

<br/>

|Common APIs|Description|
|-|-|
|[UnifiedPosErrorData](unifiedposerrordata.md) class|Provides error information.|
|[UnifiedPosErrorReason](unifiedposerrorreason.md) enumeration|Defines the constants that indicates the reason for the error event.|
|[UnifiedPosErrorSeverity](unifiedposerrorseverity.md) enumeration|Defines the constants that indicates the error severity.|
|[UnifiedPosHealthCheckLevel](unifiedposhealthchecklevel.md) enumeration|Defines the constants that indicates the type of health check that can be performed on the devices.|
|[UnifiedPosPowerReportingType](unifiedpospowerreportingtype.md) enumeration|Defines the constants that indicates power reporting capabilities of the Point of Service (POS) device.|

## -remarks

Applications that use this namespace require the declaration of the `pointOfService` [DeviceCapability](/uwp/schemas/appxpackage/appxmanifestschema/element-devicecapability) in the app package manifest.

## -examples

## -see-also

[Cash drawer sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CashDrawer), [Magnetic stripe reader sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MagneticStripeReader), [POS printer sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/PosPrinter), [Barcode scanner sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BarcodeScanner), [UnifiedPOS architectural specification](https://www.omg.org/retail/unified-pos.htm)