---
-api-id: M:Windows.Devices.Scanners.ImageScanner.ScanPreviewToStreamAsync(Windows.Devices.Scanners.ImageScannerScanSource,Windows.Storage.Streams.IRandomAccessStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Scanners.ImageScannerPreviewResult> ScanPreviewToStreamAsync(Windows.Devices.Scanners.ImageScannerScanSource scanSource, Windows.Storage.Streams.IRandomAccessStream targetStream)
-->

# Windows.Devices.Scanners.ImageScanner.ScanPreviewToStreamAsync

## -description
Scans one image from the specified scan source and applies the lowest scan resolution with the selected image file format.

## -parameters
### -param scanSource
The image scan source.

### -param targetStream
The scanned image file.

## -returns
The progress of the scan and the scanned file format.

## -remarks
Attempting to preview from a feeder that supports preview but is empty at the time will result in a successful completion of the async call. The app should check for the returned [ImageScannerPreviewResult.Succeeded](imagescannerpreviewresult.md) result before attempting to read data from the stream, especially when scanning from the feeder.

## -examples

## -see-also
