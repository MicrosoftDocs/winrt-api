---
-api-id: P:Windows.Devices.Scanners.IImageScannerSourceConfiguration.MaxBrightness
-api-type: winrt property
---

<!-- Property syntax
public int MaxBrightness { get; }
-->

# Windows.Devices.Scanners.IImageScannerSourceConfiguration.MaxBrightness

## -description
Gets the maximum brightness level supported by the scan source.

## -property-value
The maximum brightness level, typically 1000.

## -remarks
This property's value must be greater than or equal to the value of the [MinBrightness](iimagescannersourceconfiguration_minbrightness.md) property. A scan source that doesn't allow brightness adjustments can have **MinBrightness**, **MaxBrightness** and [DefaultBrightness](iimagescannersourceconfiguration_defaultbrightness.md) set to the same value-oftentimes 0, and the [BrightnessStep](iimagescannersourceconfiguration_brightnessstep.md) value set to 0.

## -examples

## -see-also
