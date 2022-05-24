---
-api-id: P:Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.MaxBrightness
-api-type: winrt property
---

<!-- Property syntax
public int MaxBrightness { get; }
-->

# Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.MaxBrightness

## -description
Gets the maximum brightness level supported by the scanner's flatbed.

## -property-value
The maximum brightness level, typically 1000.

## -remarks
This property's value must be greater than or equal to the value of the [MinBrightness](imagescannerflatbedconfiguration_minbrightness.md) property. A scan source that doesn't allow brightness adjustments can have **MinBrightness**, **MaxBrightness** and [DefaultBrightness](imagescannerflatbedconfiguration_defaultbrightness.md) set to the same value-oftentimes 0, and the [BrightnessStep](imagescannerflatbedconfiguration_brightnessstep.md) value set to 0.

## -examples

## -see-also
