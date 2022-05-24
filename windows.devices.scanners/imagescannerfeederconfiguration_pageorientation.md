---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.PageOrientation
-api-type: winrt property
---

<!-- Property syntax
public Windows.Graphics.Printing.PrintOrientation PageOrientation { get;  set; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.PageOrientation

## -description
Gets or sets the currently selected page orientation that tells how to place the documents in the scanner's feeder input tray.

## -property-value
The orientation of the page.

## -remarks
Some devices may not support all orientation values for all [PageSize](imagescannerfeederconfiguration_pagesize.md) values. For example, a [MaxScanArea.Width](imagescannerfeederconfiguration_maxscanarea.md) of 8500 (8.5”) and MaxScanArea.Height of 1100 (11”) can have a PageSize of NorthAmericaLetter and a PageOrientation of Portrait, but can't be Landscape. When the [AutoDetectPageSize](imagescannerfeederconfiguration_autodetectpagesize.md) property is True the scanner device automatically detects at scan time the size of the document pages being scanned and the values of the PageSize and PageOrientation properties are ignored. When the [AutoCroppingMode](imagescannerfeederconfiguration_autocroppingmode.md) property is SingleRegion or MultipleRegion, the scanner device will detect crop regions (and scan them to separate images) while the feeder feeds and scans the specified document size.

## -examples

## -see-also
