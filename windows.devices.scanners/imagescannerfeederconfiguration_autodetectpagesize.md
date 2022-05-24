---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.AutoDetectPageSize
-api-type: winrt property
---

<!-- Property syntax
public bool AutoDetectPageSize { get;  set; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.AutoDetectPageSize

## -description
Gets or sets the page size automatic detection feature for the scanner's feeder.

## -property-value
True if the page size automatic detection feature is enabled; otherwise False.

## -remarks
This property can be True only if [CanAutoDetectPageSize](imagescannerfeederconfiguration_canautodetectpagesize.md) property is True. When this property is True the [PageSize](imagescannerfeederconfiguration_pagesize.md) and [PageOrientation](imagescannerfeederconfiguration_pageorientation.md) values are ignored.

## -examples

## -see-also
