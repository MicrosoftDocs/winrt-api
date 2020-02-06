---
-api-id: P:Windows.Devices.PointOfService.BarcodeScannerReport.ScanDataLabel
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer ScanDataLabel { get; }
-->

# Windows.Devices.PointOfService.BarcodeScannerReport.ScanDataLabel

## -description
Gets the decoded barcode label, which does not include the header, checksum, and other miscellaneous information.

## -property-value
The data stream containing the decoded barcode label.

## -remarks
If [IsDecodeDataEnabled](claimedbarcodescanner_isdecodedataenabled.md) is true, then this property contains the decoded barcode label. If [IsDecodeDataEnabled](claimedbarcodescanner_isdecodedataenabled.md) is false, then this property is set to `null`.

## -examples

For a code example showing how to retrieve a string from an **IBuffer**, see [IBuffer interface](/uwp/api/windows.storage.streams.ibuffer#examples)

## -see-also