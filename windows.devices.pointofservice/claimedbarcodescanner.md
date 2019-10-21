---
-api-id: T:Windows.Devices.PointOfService.ClaimedBarcodeScanner
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ClaimedBarcodeScanner : Windows.Devices.PointOfService.IClaimedBarcodeScanner, Windows.Devices.PointOfService.IClaimedBarcodeScanner1, Windows.Devices.PointOfService.IClaimedBarcodeScanner2, Windows.Foundation.IClosable
-->

# Windows.Devices.PointOfService.ClaimedBarcodeScanner

## -description
Represents the claimed barcode scanner.

## -remarks
The object is created when [ClaimScannerAsync](barcodescanner_claimscannerasync_558793678.md) method completes.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | GetSymbologyAttributesAsync |
| 1703 | 15063 | SetSymbologyAttributesAsync |
| 1803 | 17134 | HideVideoPreview |
| 1803 | 17134 | IsVideoPreviewShownOnEnable |
| 1803 | 17134 | ShowVideoPreviewAsync |
| 1809 | 17763 | Closed |

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md)
