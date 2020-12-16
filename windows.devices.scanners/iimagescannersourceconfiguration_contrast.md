---
-api-id: P:Windows.Devices.Scanners.IImageScannerSourceConfiguration.Contrast
-api-type: winrt property
---

<!-- Property syntax
public int Contrast { get;  set; }
-->

# Windows.Devices.Scanners.IImageScannerSourceConfiguration.Contrast

## -description
Sets or gets the current contrast level for capturing image data from the scan source. At the beginning of a new scan session this property is set to the [DefaultContrast](iimagescannersourceconfiguration_defaultcontrast.md) property.

## -property-value
The contrast level.

## -remarks
Your app can set the value of this property to any [Int32](/dotnet/api/system.int32?view=dotnet-uwp-10.0&preserve-view=true) value between the [MinContrast](iimagescannersourceconfiguration_mincontrast.md) and [MaxContrast](iimagescannersourceconfiguration_maxcontrast.md) values, and also relates to the [ContrastStep](iimagescannersourceconfiguration_contraststep.md) value with this equation:

**Contrast = MinContrast + (N * ContrastStep)**

where N is a positive integer smaller than or equal to **(MaxContrast - MinContrast) / ContrastStep**.

The app can return the contrast level to default by setting the value of this property to [DefaultContrast](iimagescannersourceconfiguration_defaultcontrast.md).

If the scanner doesn't allow contrast adjustments, **MinContrast**, **MaxContrast** and **DefaultContrast** are set to the same value-oftentimes 0, the [ContrastStep](iimagescannersourceconfiguration_contraststep.md) value is 0, and the app can't set the **Contrast** property to a value other than **DefaultContrast**.

## -examples

## -see-also
