---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.MaxNumberOfPages
-api-type: winrt property
---

<!-- Property syntax
public uint MaxNumberOfPages { get;  set; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.MaxNumberOfPages

## -description
Gets or sets the maximum number of pages-not images, the app can scan in one scan job, before the scanner stops.

## -property-value
The number of pages.

## -remarks
The default value is 1. If this property is 0, the scanner must scan until the feeder tray is empty. Each scanned page can produce one or more images. For example when scanning duplex with [AutoCroppingMode](imagescannerfeederconfiguration_autocroppingmode.md) set to [ImageScannerAutoCroppingMode.Disabled](imagescannerautocroppingmode.md) there are two images to acquire for each scanned page (one image from the front and another image from the back side of the scanned page).

## -examples

## -see-also
