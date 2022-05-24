---
-api-id: P:Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.DesiredResolution
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Scanners.ImageScannerResolution DesiredResolution { get;  set; }
-->

# Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.DesiredResolution

## -description
Gets or sets the horizontal and vertical scan resolution for the scanner's flatbed that the app requests, in DPI.

## -property-value
The horizontal and vertical resolution, in pixels.

## -remarks
The actual resolution used for scanning (see [ActualResolution](imagescannerflatbedconfiguration_actualresolution.md)) will be set to the closest resolution supported by the scanner.

Scanners support either:
* A fixed list of resolutions (for example, 75x75dpi, 150x150dpi, 300x300dpi, 450x450dpi, and 600x600dpi), or
* A resolution range between [MinResolution](imagescannerflatbedconfiguration_minresolution.md) and [MaxResolution](imagescannerflatbedconfiguration_maxresolution.md) in *resolution-step* increments. For example, 75x75dpi up to 600x600dpi, in increments of 25dpi.

For the fixed list example above, setting **DesiredResolution** to 125x125dpi (for example) would result in an **ActualResolution** of 150x150dpi being used for scanning, because that's the closest match in that example list of supported resolutions (rounding up, if equidistant from supported resolution values).

For the resolution range example above, setting **DesiredResolution** to 130x130dpi (for example) would result in an **ActualResolution** of 125x125dpi being used for scanning, because that's the closest supported matching resolution in that example range.

You can also set **DesiredResolution** to [OpticalResolution](imagescannerflatbedconfiguration_opticalresolution.md).

## -examples

## -see-also
[ActualResolution](imagescannerflatbedconfiguration_actualresolution.md)
