---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.DesiredResolution
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Scanners.ImageScannerResolution DesiredResolution { get;  set; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.DesiredResolution

## -description
Gets or sets the horizontal and vertical scan resolution for the scanner's Feeder that the app requests, in DPI.

## -property-value
The horizontal and vertical resolution, in pixels.

## -remarks
This property value can be [MinResolution](imagescannerfeederconfiguration_minresolution.md), [MaxResolution](imagescannerfeederconfiguration_maxresolution.md), or [OpticalResolution](imagescannerfeederconfiguration_opticalresolution.md). But, if your app sets this value to other resolutions, this property will choose the closest resolution values. See [ActualResolution](imagescannerfeederconfiguration_actualresolution.md) property.

## -examples

## -see-also
