---
-api-id: P:Windows.Devices.Scanners.IImageScannerSourceConfiguration.Brightness
-api-type: winrt property
---

<!-- Property syntax
public int Brightness { get;  set; }
-->

# Windows.Devices.Scanners.IImageScannerSourceConfiguration.Brightness

## -description
Configures the current brightness level for capturing image data from the scan source. On a new scan session, the value of this property is the [DefaultBrightness](iimagescannersourceconfiguration_defaultbrightness.md) property.

## -property-value
The brightness level.

## -remarks
This property's value must be between [MinBrightness](iimagescannersourceconfiguration_minbrightness.md) and [MaxBrightness](iimagescannersourceconfiguration_maxbrightness.md), and is related to [BrightnessStep](iimagescannersourceconfiguration_brightnessstep.md) with this equation:

**Brightness = MinBrightness + (N*BrightnessStep)**

where N is a positive integer smaller than or equal to **(MaxBrightness - MinBrightness) / BrightnessStep**.

Your app can return the brightness level to default by setting the value of this property to the [DefaultBrightness](iimagescannersourceconfiguration_defaultbrightness.md) property value. If the scanner doesn't allow brightness changes, **MinBrightness**, **MaxBrightness** and **DefaultBrightness** are set to the same value-oftentimes 0, the **BrightnessStep** is set to 0, and the app can't change the **Brightness** property to a different value other than **DefaultBrightness**.

## -examples

## -see-also
