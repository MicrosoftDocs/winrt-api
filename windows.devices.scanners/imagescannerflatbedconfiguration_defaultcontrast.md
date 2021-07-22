---
-api-id: P:Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.DefaultContrast
-api-type: winrt property
---

<!-- Property syntax
public int DefaultContrast { get; }
-->

# Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.DefaultContrast

## -description
Gets the default contrast level for the scanner's flatbed.

## -property-value
The default contrast level.

## -remarks
A scan source that doesn't allow contrast adjustments can have [MinContrast](imagescannerflatbedconfiguration_mincontrast.md), [MaxContrast](imagescannerflatbedconfiguration_maxcontrast.md) and **DefaultContrast** set to the same value-oftentimes 0, and the [ContrastStep](imagescannerflatbedconfiguration_contraststep.md) value set to 0.

## -examples

## -see-also
