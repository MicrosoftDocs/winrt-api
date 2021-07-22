---
-api-id: P:Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.DefaultBrightness
-api-type: winrt property
---

<!-- Property syntax
public int DefaultBrightness { get; }
-->

# Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.DefaultBrightness

## -description
Gets the default brightness level for the scanner's flatbed.

## -property-value
The default brightness level for the scanner.

## -remarks
A scan source that doesn't allow brightness adjustments can have [MinBrightness](imagescannerflatbedconfiguration_minbrightness.md), [MaxBrightness](imagescannerflatbedconfiguration_maxbrightness.md) and **DefaultBrightness** set to the same value-oftentimes 0, and the [BrightnessStep](imagescannerflatbedconfiguration_brightnessstep.md) value set to 0.

## -examples

## -see-also
