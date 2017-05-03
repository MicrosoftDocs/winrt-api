---
-api-id: P:Windows.Devices.PointOfService.BarcodeScannerReport.ScanDataType
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public uint ScanDataType { get; }
-->

# Windows.Devices.PointOfService.BarcodeScannerReport.ScanDataType

## -description
Gets the decoded barcode label type. Possible values are defined in the [BarcodeSymbologies](barcodesymbologies.md) class.

## -property-value
The specific barcode symbology.

## -remarks
The return value of this property depends on the value of [IsDecodeDataEnabled](claimedbarcodescanner_isdecodedataenabled.md) property. If [IsDecodeDataEnabled](claimedbarcodescanner_isdecodedataenabled.md) is true, this property contains the barcode symbology. If [IsDecodeDataEnabled](claimedbarcodescanner_isdecodedataenabled.md) is false, this property contains the [BarcodeSymbology.Unknown](barcodesymbologies_unknown.md) value.

## -examples

## -see-also
