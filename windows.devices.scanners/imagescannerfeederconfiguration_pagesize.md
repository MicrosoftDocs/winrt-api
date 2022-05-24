---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.PageSize
-api-type: winrt property
---

<!-- Property syntax
public Windows.Graphics.Printing.PrintMediaSize PageSize { get;  set; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.PageSize

## -description
Gets or sets the currently selected page size to scan from the feeder.

## -property-value
The page size.

## -remarks
When the [AutoDetectPageSize](imagescannerfeederconfiguration_autodetectpagesize.md) property is True the scanner device automatically detects at scan time the size of the document pages to scan and the values of the PageSize and [PageOrientation](imagescannerfeederconfiguration_pageorientation.md) properties are ignored.

When the [AutoCroppingMode](imagescannerfeederconfiguration_autocroppingmode.md) property is SingleRegion or MultiRegion, the scanner device will detect crop regions (and scan them to separate images) while the feeder feeds and scans the specified document size.

## -examples

## -see-also
