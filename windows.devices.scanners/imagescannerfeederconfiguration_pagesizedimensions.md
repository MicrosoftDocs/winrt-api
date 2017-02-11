---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.PageSizeDimensions
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Size PageSizeDimensions { get; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.PageSizeDimensions

## -description
Gets the dimensions (width and height) and orientation of the selected page size, in mil units (1/1000").

## -property-value
The page size.

## -remarks
When the [AutoDetectPageSize](imagescannerfeederconfiguration_autodetectpagesize.md) property is False this property describes the dimensions (width and height) and orientation of the page size, in mil (1/1000”) units. For example, a Portrait NorthAmericaLetter having dimensions 8.5" x 11” has a PageSizeDimensions.Width value of 8500 units and a PageSizeDimensions.Height value of 11000 units, while a Landscape NorthAmericaLetter having dimensions 11" x 8.5” has a PageSizeDimensions.Width value of 11000 units and a PageSizeDimensions.Height value of 8500 units.

When the **AutoDetectPageSize** property is True the value of this property is automatically set to MaximumScanArea.Width and MaximumScanArea.Height and the app should ignore it.

## -examples

## -see-also
