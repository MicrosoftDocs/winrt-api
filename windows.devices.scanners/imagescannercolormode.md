---
-api-id: T:Windows.Devices.Scanners.ImageScannerColorMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Scanners.ImageScannerColorMode : int
-->

# ImageScannerColorMode

## -description
Specifies the color modes for the scan source.

## -enum-fields
### -field Color:0
24-bit RGB color (3 channels at 8 bits per channel).

### -field Grayscale:1
8 bit or 4 bit grayscale (1 channel at 8 or 4 bits per channel). If the device supports both 4 and 8 bit grayscale the [DefaultColorMode](iimagescannersourceconfiguration_defaultcolormode.md) property will use 8 bit.

### -field Monochrome:2
1 bit bi-tonal, also called monochrome or ‘black and white’ (1 channel at 1 bit per channel).

### -field AutoColor:3
The device automatically detects the right color mode based on the scan content. In this case the decision between color, grayscale and black and white for example relies on the device, and not the app.


## -remarks
If the scanner device doesn't support any of these color modes, the current scan source will be considered unavailable and the app won’t be able to scan from there.

## -examples

## -see-also