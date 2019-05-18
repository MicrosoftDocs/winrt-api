---
-api-id: T:Windows.Devices.PointOfService.ReceiptPrinterCapabilities
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ReceiptPrinterCapabilities : Windows.Devices.PointOfService.ICommonPosPrintStationCapabilities, Windows.Devices.PointOfService.ICommonReceiptSlipCapabilities, Windows.Devices.PointOfService.IReceiptPrinterCapabilities
-->

# Windows.Devices.PointOfService.ReceiptPrinterCapabilities

## -description
Represents the capabilities of receipt station of a point-of-service printer.

## -remarks
To get the capabilities of the receipt station of a point-of-service printer, use [PosPrinterCapabilities.Receipt](posprintercapabilities_receipt.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | IsReversePaperFeedByLineSupported |
| 1903 | 18362 | IsReversePaperFeedByMapModeUnitSupported |
| 1903 | 18362 | IsReverseVideoSupported |
| 1903 | 18362 | IsStrikethroughSupported |
| 1903 | 18362 | IsSubscriptSupported |
| 1903 | 18362 | IsSuperscriptSupported |

## -examples

## -see-also
[ICommonReceiptSlipCapabilities](icommonreceiptslipcapabilities.md), [ICommonPosPrintStationCapabilities](icommonposprintstationcapabilities.md), [PosPrinterCapabilities.Receipt](posprintercapabilities_receipt.md)
