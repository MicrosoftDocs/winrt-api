---
-api-id: P:Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.MinContrast
-api-type: winrt property
---

<!-- Property syntax
public int MinContrast { get; }
-->

# Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.MinContrast

## -description
Gets the minimum contrast level supported by the scanner's flatbed.

## -property-value
The minimum contrast level, typically -1000.

## -remarks
This property's value must be smaller than or equal to the value of the [MaxContrast](imagescannerflatbedconfiguration_maxcontrast.md) property. A scan source that doesn't allow contrast adjustments can have **MinContrast**, **MaxContrast** and [DefaultContrast](imagescannerflatbedconfiguration_defaultcontrast.md) set to the same value-oftentimes 0, and the [ContrastStep](imagescannerflatbedconfiguration_contraststep.md) value set to 0.

## -examples

## -see-also
