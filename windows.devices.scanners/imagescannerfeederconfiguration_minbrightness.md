---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.MinBrightness
-api-type: winrt property
---

<!-- Property syntax
public int MinBrightness { get; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.MinBrightness

## -description
Gets the minimum brightness level supported by the scanner's feeder.

## -property-value
The minimum brightness level, typically -1000.

## -remarks
This property's value must be smaller than or equal to the value of the [MaxBrightness](imagescannerfeederconfiguration_maxbrightness.md) property. A scan source that doesn't allow brightness adjustments can have **MinBrightness**, **MaxBrightness** and [DefaultBrightness](imagescannerfeederconfiguration_defaultbrightness.md) set to the same value-oftentimes 0, and the [BrightnessStep](imagescannerfeederconfiguration_brightnessstep.md) value set to 0.

## -examples

## -see-also
