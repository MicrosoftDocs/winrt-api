---
-api-id: P:Windows.Devices.Scanners.IImageScannerSourceConfiguration.DefaultBrightness
-api-type: winrt property
---

<!-- Property syntax
public int DefaultBrightness { get; }
-->

# Windows.Devices.Scanners.IImageScannerSourceConfiguration.DefaultBrightness

## -description
Gets the default brightness level for the scan source.

## -property-value
The default brightness level for the scanner.

## -remarks
A scan source that doesn't allow brightness adjustments can have [MinBrightness](iimagescannersourceconfiguration_minbrightness.md), [MaxBrightness](iimagescannersourceconfiguration_maxbrightness.md) and **DefaultBrightness** set to the same value-oftentimes 0, and the [BrightnessStep](iimagescannersourceconfiguration_brightnessstep.md) value set to 0.

## -examples

## -see-also
