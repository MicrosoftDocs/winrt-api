---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.DefaultColorMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Scanners.ImageScannerColorMode DefaultColorMode { get; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.DefaultColorMode

## -description
Gets the default color mode for the scanner's feeder.

## -property-value
The color mode.

## -remarks
When a new scan session begins, this property chooses the default color mode based on the pixel data types and bit depths that each scanner device supports. This is the order of priority:


+ AutoColor
+ Color
+ Grayscale
+ BlackAndWhite
If the scanner device doesn't support any of the standard color modes, the current scan source will be considered unavailable and the app won’t be able to scan from there.

## -examples

## -see-also
