---
-api-id: P:Windows.Devices.PointOfService.BarcodeSymbologyAttributes.DecodeLengthKind
-api-type: winrt property
---

<!-- Property syntax.
public BarcodeSymbologyDecodeLengthKind DecodeLengthKind { get;  set; }
-->

# Windows.Devices.PointOfService.BarcodeSymbologyAttributes.DecodeLengthKind

## -description
The kind of decode length supported by the barcode symbology.

## -property-value
This property can contain one the following values:

+ BarcodeSymbologyDecodeLengthKind.Range: symbology supports decode lengths between [DecodeLength1](barcodesymbologyattributes_decodelength1.md) and [DecodeLength2](barcodesymbologyattributes_decodelength2.md) single-byte characters. The order of [DecodeLength1](barcodesymbologyattributes_decodelength1.md) and [DecodeLength2](barcodesymbologyattributes_decodelength2.md) do not matter (either can be higher or lower than the other).
+ BarcodeSymbologyDecodeLengthKind.Discrete: symbology supports decode lengths of either [DecodeLength1](barcodesymbologyattributes_decodelength1.md) or [DecodeLength2](barcodesymbologyattributes_decodelength2.md) single-byte characters.
+ BarcodeSymbologyDecodeLengthKind.AnyLength: symbology supports decode lengths of any number of single-byte characters.

## -remarks

## -see-also

## -examples
