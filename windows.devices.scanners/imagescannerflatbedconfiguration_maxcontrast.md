---
-api-id: P:Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.MaxContrast
-api-type: winrt property
---

<!-- Property syntax
public int MaxContrast { get; }
-->

# Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.MaxContrast

## -description
Gets the maximum contrast level supported by the scanner's flatbed.

## -property-value
The maximum contrast level, typically 1000.

## -remarks
This property's value must be greater than or equal to the value of the [MinContrast](imagescannerflatbedconfiguration_mincontrast.md) property. A scan source that doesn't allow contrast adjustments can have **MinContrast**, **MaxContrast** and [DefaultContrast](imagescannerflatbedconfiguration_defaultcontrast.md) set to the same value-oftentimes 0, and the [ContrastStep](imagescannerflatbedconfiguration_contraststep.md) value set to 0.

## -examples

## -see-also
