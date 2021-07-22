---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.MinContrast
-api-type: winrt property
---

<!-- Property syntax
public int MinContrast { get; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.MinContrast

## -description
Gets the minimum contrast level supported by the scanner's feeder.

## -property-value
The minimum contrast level, typically -1000.

## -remarks
This property's value must be smaller than or equal to the value of the [MaxContrast](imagescannerfeederconfiguration_maxcontrast.md) property. A scan source that doesn't allow contrast adjustments can have **MinContrast**, **MaxContrast** and [DefaultContrast](imagescannerfeederconfiguration_defaultcontrast.md) set to the same value-oftentimes 0, and the [ContrastStep](imagescannerfeederconfiguration_contraststep.md) value set to 0.

## -examples

## -see-also
