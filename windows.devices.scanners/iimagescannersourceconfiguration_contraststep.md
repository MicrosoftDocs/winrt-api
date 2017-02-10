---
-api-id: P:Windows.Devices.Scanners.IImageScannerSourceConfiguration.ContrastStep
-api-type: winrt property
---

<!-- Property syntax
public uint ContrastStep { get; }
-->

# Windows.Devices.Scanners.IImageScannerSourceConfiguration.ContrastStep

## -description
Gets the step size at which the contrast levels of the data source can increase or decrease between the minimum and maximum values.

## -property-value
The step size to increment or decrement. The typical value is 1.

## -remarks
If the scanner doesn't allow contrast changes, then the [MinContrast](iimagescannersourceconfiguration_mincontrast.md), [MaxContrast](iimagescannersourceconfiguration_maxcontrast.md) and [DefaultContrast](iimagescannersourceconfiguration_defaultcontrast.md) are set to the same value-oftentimes 0, and the **ContrastStep** value is set to 0. Your app can determine if the scan source doesn't support contrast adjustments by reading the **ContrastStep** value. If the value is greater than 0, then the scan source supports contrast adjustments.

## -examples

## -see-also
