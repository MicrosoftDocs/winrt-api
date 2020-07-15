---
-api-id: T:Windows.Devices.PointOfService.PosPrinter
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PosPrinter : Windows.Devices.PointOfService.IPosPrinter, Windows.Foundation.IClosable
-->

# Windows.Devices.PointOfService.PosPrinter

## -description
Represents a point-of-service printer.

## -remarks
To get a PosPrinter object, use the [FromIdAsync](posprinter_fromidasync_1322863552.md) or [GetDefaultAsync](posprinter_getdefaultasync_1549573963.md) static methods.

See the [POS printer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/PosPrinter) for an example implementation.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | GetDeviceSelector(PosConnectionTypes) |
| 1903 | 18362 | GetFontProperty |
| 1903 | 18362 | SupportedBarcodeSymbologies |

## -examples

## -see-also
[FromIdAsync](posprinter_fromidasync_1322863552.md), [GetDefaultAsync](posprinter_getdefaultasync_1549573963.md)
