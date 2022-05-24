---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.Brightness
-api-type: winrt property
---

<!-- Property syntax
public int Brightness { get;  set; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.Brightness

## -description
Gets or sets the current brightness level for capturing image data from the scanner's feeder. At the beginning of a new scan session, this property is set to the [DefaultBrightness](imagescannerfeederconfiguration_defaultbrightness.md) property.

## -property-value
The current brightness level.

## -remarks
Your app can set the value of this property to any [Int32](/dotnet/api/system.int32?view=dotnet-uwp-10.0&preserve-view=true) value between the [MinBrightness](imagescannerfeederconfiguration_minbrightness.md) and [MaxBrightness](imagescannerfeederconfiguration_maxbrightness.md) values, and also relates to the [BrightnessStep](imagescannerfeederconfiguration_brightnessstep.md) value with this equation:

**Brightness = MinBrightness + (N * BrightnessStep)**

where N is a positive integer smaller than or equal to **(MaxBrightness - MinBrightness) / BrightnessStep**.

The app can return the brightness level to default by setting the value of this property to [DefaultBrightness](imagescannerfeederconfiguration_defaultbrightness.md).

If the scanner doesn't allow brightness adjustments, **MinBrightness**, **MaxBrightness** and **DefaultBrightness** are set to the same value-oftentimes 0, the **BrightnessStep** value is 0, and the app can't set the **Brightness** property to a value other than **DefaultBrightness**.

## -examples

## -see-also
