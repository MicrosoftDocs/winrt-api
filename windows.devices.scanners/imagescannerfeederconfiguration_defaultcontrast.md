---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.DefaultContrast
-api-type: winrt property
---

<!-- Property syntax
public int DefaultContrast { get; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.DefaultContrast

## -description
Gets the default contrast level for the scanner's feeder.

## -property-value
The default contrast level.

## -remarks
A scan source that doesn't allow contrast adjustments can have [MinContrast](imagescannerfeederconfiguration_mincontrast.md), [MaxContrast](imagescannerfeederconfiguration_maxcontrast.md) and **DefaultContrast** set to the same value-oftentimes 0, and the [ContrastStep](imagescannerfeederconfiguration_contraststep.md) value set to 0.

## -examples

## -see-also
