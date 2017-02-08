---
-api-id: P:Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.DesiredResolution
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Scanners.ImageScannerResolution DesiredResolution { get;  set; }
-->

# Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.DesiredResolution

## -description
Gets or sets the horizontal and vertical scan resolution for the scanner's Flatbed that the app requests, in DPI.

## -property-value
The horizontal and vertical resolution, in pixels.

## -remarks
This property value can be [MinResolution](imagescannerflatbedconfiguration_minresolution.md), [MaxResolution](imagescannerflatbedconfiguration_maxresolution.md), or [OpticalResolution](imagescannerflatbedconfiguration_opticalresolution.md). But, if your app sets this value to other resolutions, this property will choose the closest resolution values. See [ActualResolution](imagescannerflatbedconfiguration_actualresolution.md) property.

## -examples

## -see-also
