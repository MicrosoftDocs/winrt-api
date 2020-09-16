---
-api-id: P:Windows.Devices.Scanners.ImageScannerScanResult.ScannedFiles
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Storage.StorageFile> ScannedFiles { get; }
-->

# Windows.Devices.Scanners.ImageScannerScanResult.ScannedFiles

## -description
Gets the list of scanned image files that was produced by the completed scan job.

## -property-value
A list of scanned image files from the completed scan job. If there is no scanned file, the [IVectorView<T>.Size](../windows.foundation.collections/ivectorview_1_size.md) property will be 0.

## -remarks
When nothing is scanned, the **IVectorView&lt;T&gt;.Size** property will be set to 0. The app should check the size to make sure there are actual files before attempting to access the files.

## -examples

## -see-also
