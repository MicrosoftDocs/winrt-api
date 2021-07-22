---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.DefaultBrightness
-api-type: winrt property
---

<!-- Property syntax
public int DefaultBrightness { get; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.DefaultBrightness

## -description
Gets the default brightness level for the scanner's feeder.

## -property-value
The default brightness level for the scanner.

## -remarks
A scan source that doesn't allow brightness adjustments can have [MinBrightness](imagescannerfeederconfiguration_minbrightness.md), [MaxBrightness](imagescannerfeederconfiguration_maxbrightness.md) and **DefaultBrightness** set to the same value-oftentimes 0, and the [BrightnessStep](imagescannerfeederconfiguration_brightnessstep.md) value set to 0.

## -examples

## -see-also
