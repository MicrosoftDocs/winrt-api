---
-api-id: P:Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.ActualResolution
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Scanners.ImageScannerResolution ActualResolution { get; }
-->

# Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.ActualResolution

## -description
Gets the actual horizontal and vertical scan resolution to be used for the flatbed scanner, in dots-per-inch (DPI).

## -property-value
The horizontal and vertical resolution, in pixels.

## -remarks
The actual resolution is set by the system based on the **DesiredResolution** set by the app, rounded to the nearest resolution supported by the scanner. See **Remarks** in [DesiredResolution](imagescannerflatbedconfiguration_desiredresolution.md).

## -examples

## -see-also
[DesiredResolution](imagescannerflatbedconfiguration_desiredresolution.md)
