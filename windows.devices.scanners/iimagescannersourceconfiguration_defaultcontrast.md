---
-api-id: P:Windows.Devices.Scanners.IImageScannerSourceConfiguration.DefaultContrast
-api-type: winrt property
---

<!-- Property syntax
public int DefaultContrast { get; }
-->

# Windows.Devices.Scanners.IImageScannerSourceConfiguration.DefaultContrast

## -description
Gets the default contrast level for the scan source.

## -property-value
The default contrast level.

## -remarks
A scan source that doesn't allow contrast adjustments can have [MinContrast](iimagescannersourceconfiguration_mincontrast.md), [MaxContrast](iimagescannersourceconfiguration_maxcontrast.md) and **DefaultContrast** set to the same value-oftentimes 0, and the [ContrastStep](iimagescannersourceconfiguration_contraststep.md) value set to 0.

## -examples

## -see-also
