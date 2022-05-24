---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.MaxScanArea
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Size MaxScanArea { get; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.MaxScanArea

## -description
Gets the maximum scan area dimensions in inches. The maximum scan width is the widest a document can be in order for the scanner's feeder to scan it.

## -property-value
The width and height of the area.

## -remarks
For feeder scan sources, there are restrictions for the maximum scan area: 
+ The currently selected page size, if page size auto-detection is not enabled.
+ The dimensions of the selected page size, which becomes the new maximum dimensions of the permissible scan area.
 These limits are dictated by hardware for feeder, flatbed, and other types of scan sources.

## -examples

## -see-also
