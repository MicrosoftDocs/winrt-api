---
-api-id: P:Windows.Devices.Scanners.IImageScannerSourceConfiguration.MinBrightness
-api-type: winrt property
---

<!-- Property syntax
public int MinBrightness { get; }
-->

# Windows.Devices.Scanners.IImageScannerSourceConfiguration.MinBrightness

## -description
Gets the minimum brightness level supported by the scan source.

## -property-value
The minimum brightness level, typically -1000.

## -remarks
This property's value must be smaller than or equal to the value of the [MaxBrightness](iimagescannersourceconfiguration_maxbrightness.md) property. A scan source that doesn't allow brightness adjustments can have **MinBrightness**, **MaxBrightness** and [DefaultBrightness](iimagescannersourceconfiguration_defaultbrightness.md) set to the same value-oftentimes 0, and the [BrightnessStep](iimagescannersourceconfiguration_brightnessstep.md) value set to 0.

## -examples

## -see-also
