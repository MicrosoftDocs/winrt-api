---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.DefaultFormat
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Scanners.ImageScannerFormat DefaultFormat { get; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.DefaultFormat

## -description
Gets the default file format for the scanner's feeder at the beginning of a new scan session.

## -property-value
The file type.

## -remarks
All WIA scanner devices support the Windows Device Independent Bitmap (DIB) format.

By default, these values in this order will be selected based on the file formats the device supports, from the smallest file size (in bytes) to the largest size:


+ 1. Jpeg
+ 2. Png
+ 3. Bitmap


## -examples

## -see-also
