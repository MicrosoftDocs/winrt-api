---
-api-id: P:Windows.Devices.Scanners.IImageScannerSourceConfiguration.DesiredResolution
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Scanners.ImageScannerResolution DesiredResolution { get;  set; }
-->

# Windows.Devices.Scanners.IImageScannerSourceConfiguration.DesiredResolution

## -description
Gets or sets the horizontal and vertical scan resolution for the scan source that the app requests, in DPI.

## -property-value
The horizontal and vertical resolution, in pixels.

## -remarks
This property value can be [MinResolution](iimagescannersourceconfiguration_minresolution.md), [MaxResolution](iimagescannersourceconfiguration_maxresolution.md), or [OpticalResolution](iimagescannersourceconfiguration_opticalresolution.md). But, if your app sets this value to other resolutions, this property will choose the closest resolution values. See [ActualResolution](iimagescannersourceconfiguration_actualresolution.md) property.

## -examples

## -see-also
